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
        private readonly IVueGraphique _vueGraphique;

        public PresentateurPrincipal(
            ModelControlesVecteurs controlesVecteurs,
            IVueControles vueControles,
            IVueGraphique vueGraphique)
        {
            _controlesVecteurs = controlesVecteurs;
            _vueControles = vueControles;
            _vueGraphique = vueGraphique;

            _vueControles.AjouterVecteurClique += VueControles_AjouterVecteurClique;
            _vueControles.CalculerAddSousClique += VueControles_CalculerAddSousClique;
            _vueControles.CalculerProduitClique += VueControles_CalculerProduitClique;

            _vueGraphique.ModifierValeurMinX += VueGraphique_ModifierMinX;
            _vueGraphique.ModifierValeurMaxX += VueGraphique_ModifierMaxX;
            _vueGraphique.ModifierValeurMinY += VueGraphique_ModifierMinY;
            _vueGraphique.ModifierValeurMaxY += VueGraphique_ModifierMaxY;
            _vueGraphique.ModifierAutoXClique += VueGraphique_ModifierAutoX;
            _vueGraphique.ModifierAutoYClique += VueGraphique_ModifierAutoY;
            _vueGraphique.EffacerGraphiqueClique += VueGraphique_EffacerGraphiqueClique;
        }

        private void VueControles_AjouterVecteurClique(object sender, EventArgs e)
        {
            decimal i = _vueControles.LectureIVecteur();
            decimal j = _vueControles.LectureJVecteur();

            _controlesVecteurs.AjouterVecteur(_vueControles.LectureNomVecteur(), i, j);
            _vueControles.AjouterEntrerListe(_vueControles.LectureNomVecteur());
            _vueGraphique.AjouterVecteur(i, j, _vueControles.LectureNomVecteur());

            if (_vueControles.LectureAutoX())
                _vueGraphique.ModifierAutoX();

            if (_vueControles.LectureAutoY())
                _vueGraphique.ModifierAutoY();
        }

        private void VueControles_CalculerAddSousClique(object sender, EventArgs e)
        {
            Tuple<decimal,decimal> add_sous_vecteur = _controlesVecteurs.CalculerAddSous(_vueControles.LectureAddSousSelectionner(), _vueControles.LectureIndexVecteurXSelectionnerAddSous(), 
                _vueControles.LectureIndexVecteurYSelectionnerAddSous(), _vueControles.LectureMultiplicateurX(), _vueControles.LectureMultiplicateurY());

            _vueGraphique.AjouterVecteur(add_sous_vecteur.Item1, add_sous_vecteur.Item2, _vueControles.LectureNomVecteur());
            _vueControles.AjouterEntrerListe(_controlesVecteurs.LectureDernierVecteur());

            _vueGraphique.Refresh();
        }

        private void VueControles_CalculerProduitClique(object sender, EventArgs e)
        {
            _vueControles.AfficherProduit(_controlesVecteurs.CalculerProduit(_vueControles.LectureProduitSelectionner(), _vueControles.LectureIndexVecteurXSelectionnerProduit(),
                _vueControles.LectureIndexVecteurYSelectionnerProduit()));
        }

        private void VueGraphique_ModifierMinX(object sender, EventArgs e)
        {
            _vueGraphique.ModifierMinX((double)_vueControles.LectureMinX(), (double)_vueControles.LectureMaxX());
            return;
        }

        private void VueGraphique_ModifierMaxX(object sender, EventArgs e)
        {
            _vueGraphique.ModifierMaxX((double)_vueControles.LectureMinX(), (double)_vueControles.LectureMaxX());
            return;
        }

        private void VueGraphique_ModifierMinY(object sender, EventArgs e)
        {
            _vueGraphique.ModifierMinY((double)_vueControles.LectureMinY(), (double)_vueControles.LectureMaxY());
            return;
        }

        private void VueGraphique_ModifierMaxY(object sender, EventArgs e)
        {
            _vueGraphique.ModifierMaxY((double)_vueControles.LectureMinY(), (double)_vueControles.LectureMaxY());
            return;
        }

        private void VueGraphique_ModifierAutoX(object sender, EventArgs e)
        {
            _vueGraphique.ModifierAutoX();
            return;
        }

        private void VueGraphique_ModifierAutoY(object sender, EventArgs e)
        {
            _vueGraphique.ModifierAutoY();
            return;
        }

        private void VueGraphique_EffacerGraphiqueClique(object sender, EventArgs e)
        {
            _vueGraphique.EffacerGraphique();
            return;
        }
    }
}
