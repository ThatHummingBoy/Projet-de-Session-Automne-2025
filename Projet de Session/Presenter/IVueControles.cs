using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet_de_Session.Presenter
{
    public interface IVueControles
    {
        event EventHandler AjouterVecteurClique;
        event EventHandler CalculerAddSousClique;
        event EventHandler CalculerProduitClique;
        event EventHandler ChangerValeurMinX;
        event EventHandler ChangerValeurMaxX;
        event EventHandler ChangerValeurMinY;
        event EventHandler ChangerValeurMaxY;

        decimal LectureIVecteur();
        decimal LectureJVecteur();
        string LectureNomVecteur();
        decimal LectureMultiplicateurX();
        decimal LectureMultiplicateurY();
        decimal LectureMinX();
        decimal LectureMaxX();
        decimal LectureMinY();
        decimal LectureMaxY();
        int LectureAddSousSelectionner();
        int LectureProduitSelectionner();
        int LectureIndexVecteurXSelectionnerAddSous();
        int LectureIndexVecteurYSelectionnerAddSous();
        int LectureIndexVecteurXSelectionnerProduit();
        int LectureIndexVecteurYSelectionnerProduit();
    }
}
