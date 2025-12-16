using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projet_de_Session.Model;

namespace Projet_de_Session.Presenter
{
    public class PresentateurPrincipal
    {
        private readonly ModelControlesVecteurs _controlesVecteurs;
        private readonly IVueControles _vueControles;
        private readonly IVueGraphique _vuesGraphique;

        public PresentateurPrincipal(
            ModelControlesVecteurs controlesVecteurs,
            IVueControles vueControles,
            IVueGraphique vueGraphique)
        {
            _controlesVecteurs = controlesVecteurs;
            _vueControles = vueControles;
            _vuesGraphique = vueGraphique;

            _vueControles.AjouterVecteurClique += VueControles_AjouterVecteurClique;
            _vueControles.CalculerAddSousClique += VueControles_CalculerAddSousClique;
            _vueControles.CalculerProduitClique += VueControles_CalculerProduitClique;

            _vuesGraphique.ModifierValeurMinX += VueGraphique_ModifierMinX;
            _vuesGraphique.ModifierValeurMaxX += VueGraphique_ModifierMaxX;
            _vuesGraphique.ModifierValeurMinY += VueGraphique_ModifierMinY;
            _vuesGraphique.ModifierValeurMaxY += VueGraphique_ModifierMaxY;
            _vuesGraphique.ModifierAutoXClique += VueGraphique_ModifierAutoX;
            _vuesGraphique.ModifierAutoYClique += VueGraphique_ModifierAutoY;
            _vuesGraphique.EffacerGraphiqueClique += VueGraphique_EffacerGraphiqueClique;
        }

        private void VueControles_AjouterVecteurClique(object sender, EventArgs e)
        {
            decimal i = _vueControles.LectureIVecteur();
            decimal j = _vueControles.LectureJVecteur();

            _controlesVecteurs.AjouterVecteur(_vueControles.LectureNomVecteur(), i, j);
            _vuesGraphique.AjouterVecteur(i, j);
        }

        private void VueControles_CalculerAddSousClique(object sender, EventArgs e)
        {
            _controlesVecteurs.CalculerAddSous(_vueControles.LectureAddSousSelectionner(), _vueControles.LectureIndexVecteurXSelectionnerAddSous(), 
                _vueControles.LectureIndexVecteurYSelectionnerAddSous(), _vueControles.LectureMultiplicateurX(), _vueControles.LectureMultiplicateurY());
        }

        private void VueControles_CalculerProduitClique(object sender, EventArgs e)
        {
            _controlesVecteurs.CalculerProduit(_vueControles.LectureProduitSelectionner(), _vueControles.LectureIndexVecteurXSelectionnerProduit(),
                _vueControles.LectureIndexVecteurYSelectionnerProduit());
        }

        private void VueGraphique_ModifierMinX(object sender, EventArgs e)
        {
            _vuesGraphique.ModifierMinX((double)_vueControles.LectureMinX(), (double)_vueControles.LectureMaxX());
            return;
        }

        private void VueGraphique_ModifierMaxX(object sender, EventArgs e)
        {
            _vuesGraphique.ModifierMinX((double)_vueControles.LectureMinX(), (double)_vueControles.LectureMaxX());
            return;
        }

        private void VueGraphique_ModifierMinY(object sender, EventArgs e)
        {
            _vuesGraphique.ModifierMinY((double)_vueControles.LectureMinY(), (double)_vueControles.LectureMaxY());
            return;
        }

        private void VueGraphique_ModifierMaxY(object sender, EventArgs e)
        {
            _vuesGraphique.ModifierMinY((double)_vueControles.LectureMinY(), (double)_vueControles.LectureMaxY());
            return;
        }

        private void VueGraphique_ModifierAutoX(object sender, EventArgs e)
        {
            _vuesGraphique.ModifierAutoX();
            return;
        }

        private void VueGraphique_ModifierAutoY(object sender, EventArgs e)
        {
            _vuesGraphique.ModifierAutoY();
            return;
        }

        private void VueGraphique_EffacerGraphiqueClique(object sender, EventArgs e)
        {
            _vuesGraphique.EffacerGraphique();
            return;
        }
    }
}
