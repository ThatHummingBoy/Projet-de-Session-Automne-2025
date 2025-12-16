using Microsoft.Win32.SafeHandles;
using Projet_de_Session.Presenter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_de_Session.Model
{
    public class ModelControlesVecteurs
    {
        List<Tuple<decimal, decimal>> coordonnees;
        List<string> noms;

        public void CalculerAddSous(int choix_operateur, int vecteur1, int vecteur2, decimal multiplicateur1, decimal multiplicateur2)
        {
            if (choix_operateur == 0)
            {
                coordonnees.Add(new Tuple<decimal, decimal>(((multiplicateur1 * coordonnees[vecteur1].Item1) + (multiplicateur2 * coordonnees[vecteur2].Item2)), 
                    ((multiplicateur1 * coordonnees[vecteur1].Item2) + (multiplicateur2 * coordonnees[vecteur2].Item2))));
                noms.Add($"({noms[vecteur1]}) + ({noms[vecteur2]})");
            }
            else if (choix_operateur == 1)
            {
                coordonnees.Add(new Tuple<decimal, decimal>(((multiplicateur1 * coordonnees[vecteur1].Item1) - (multiplicateur2 * coordonnees[vecteur2].Item2)),
                    ((multiplicateur1 * coordonnees[vecteur1].Item2) - (multiplicateur2 * coordonnees[vecteur2].Item2))));
                noms.Add($"({noms[vecteur1]}) - ({noms[vecteur2]})");
            }
            else if (choix_operateur == 2)
            {
                return;
            }
        }

        public double CalculerProduit(int choix_operateur, int vecteur1, int vecteur2)
        {
            if (choix_operateur == 0)
            {
                return (double)((coordonnees[vecteur1].Item1 * coordonnees[vecteur2].Item2) - (coordonnees[vecteur2].Item1 * coordonnees[vecteur1].Item2));
            }
            else if (choix_operateur == 1)
            {
                return (double)((coordonnees[vecteur1].Item1 * coordonnees[vecteur2].Item1) + (coordonnees[vecteur1].Item2 * coordonnees[vecteur2].Item2));
            }
            else
                return double.NaN;
        }

        public void AjouterVecteur(string nom, decimal coordonne_i, decimal coordonne_j)
        {
            coordonnees.Add(new Tuple<decimal, decimal>(coordonne_i, coordonne_j));
            noms.Add(nom);
        }
    }
}
