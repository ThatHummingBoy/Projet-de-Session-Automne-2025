using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_de_Session.Presenter
{
    public interface IVueGraphique
    {
        event EventHandler ModifierValeurMinX;
        event EventHandler ModifierValeurMinY;
        event EventHandler ModifierValeurMaxX;
        event EventHandler ModifierValeurMaxY;
        event EventHandler ModifierAutoXClique;
        event EventHandler ModifierAutoYClique;
        event EventHandler EffacerGraphiqueClique;

        void AjouterVecteur(decimal coordonne_i, decimal coordonne_j, string nom_vecteur);
        void ModifierMinX(double xmin, double xmax);
        void ModifierMaxX(double xmin, double xmax);
        void ModifierMinY(double xmin, double xmax);
        void ModifierMaxY(double xmin, double xmax);
        void ModifierAutoX();
        void ModifierAutoY();
        void EffacerGraphique();
        void Refresh();
    }
}
