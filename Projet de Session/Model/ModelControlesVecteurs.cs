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

        public ModelControlesVecteurs()
        {
            coordonnees = new List<Tuple<decimal, decimal>>();
            noms = new List<string>();
        }

        public Tuple<decimal, decimal> CalculerAddSous(int choix_operateur, int vecteur1, int vecteur2, decimal multiplicateur1, decimal multiplicateur2)
        {
            decimal nouv_i = 0;
            decimal nouv_j = 0;

            if (choix_operateur == 0)
            {
                nouv_i = ((multiplicateur1 * coordonnees[vecteur1].Item1) + (multiplicateur2 * coordonnees[vecteur2].Item1));
                nouv_j = ((multiplicateur1 * coordonnees[vecteur1].Item2) + (multiplicateur2 * coordonnees[vecteur2].Item2));
                
                noms.Add($"({noms[vecteur1]}) + ({noms[vecteur2]})");
            }
            else if (choix_operateur == 1)
            {
                nouv_i = ((multiplicateur1 * coordonnees[vecteur1].Item1) - (multiplicateur2 * coordonnees[vecteur2].Item1));
                nouv_j = ((multiplicateur1 * coordonnees[vecteur1].Item2) - (multiplicateur2 * coordonnees[vecteur2].Item2));

                noms.Add($"({noms[vecteur1]}) - ({noms[vecteur2]})");
            }
            else if (choix_operateur == 2)
            {
                return new Tuple<decimal, decimal>(0, 0);
            }

            coordonnees.Add(new Tuple<decimal, decimal>(nouv_j, nouv_i));

            return new Tuple<decimal, decimal>(nouv_i, nouv_j);
        }

        public decimal CalculerProduit(int choix_operateur, int vecteur1, int vecteur2)
        {
            if (choix_operateur == 0)
            {
                return (coordonnees[vecteur1].Item1 * coordonnees[vecteur2].Item2) - (coordonnees[vecteur2].Item1 * coordonnees[vecteur1].Item2);
            }
            else if (choix_operateur == 1)
            {
                return (coordonnees[vecteur1].Item1 * coordonnees[vecteur2].Item1) + (coordonnees[vecteur1].Item2 * coordonnees[vecteur2].Item2);
            }
            else
                return 0;
        }

        public void AjouterVecteur(string nom, decimal coordonne_i, decimal coordonne_j)
        {
            coordonnees.Add(new Tuple<decimal, decimal>(coordonne_i, coordonne_j));
            noms.Add(nom);
        }

        public string LectureDernierVecteur()
        {
            return noms.Last();
        }
    }
}
