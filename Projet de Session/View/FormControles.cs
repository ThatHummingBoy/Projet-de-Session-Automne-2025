using Projet_de_Session.Presenter;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet_de_Session
{
    public partial class FormControles : Form, IVueControles
    {
       public EventHandler AjouterVecteurClique;
       public EventHandler CalculerAddSousClique;
       public EventHandler CalculerProduitClique;
       public EventHandler ChangerValeurMinX;
       public EventHandler ChangerValeurMaxX;
       public EventHandler ChangerValeurMinY;
       public EventHandler ChangerValeurMaxY;

        public FormControles()
        {
            InitializeComponent();

            buttonAjouterVecteur.Click += (s, e) =>
            {
                AjouterVecteurClique?.Invoke(this, EventArgs.Empty);
            };

            buttonCalculerAddSous.Click += (s, e) =>
            {
                CalculerAddSousClique?.Invoke(this, EventArgs.Empty);
            };

            buttonCalculerProduit.Click += (s, e) =>
            {
                CalculerProduitClique?.Invoke(this, EventArgs.Empty);
            };

            numericUpDownGraphiqueXmin.ValueChanged += (s, e) =>
            {
                ChangerValeurMinX?.Invoke(this, EventArgs.Empty);
            };

            numericUpDownGraphiqueXmax.ValueChanged += (s, e) =>
            {
                ChangerValeurMaxX?.Invoke(this, EventArgs.Empty);
            };

            numericUpDownGraphiqueYmin.ValueChanged += (s, e) =>
            {
                ChangerValeurMinY?.Invoke(this, EventArgs.Empty);
            };

            numericUpDownGraphiqueYmax.ValueChanged += (s, e) =>
            {
                ChangerValeurMaxY?.Invoke(this, EventArgs.Empty);
            };
        }

        public decimal LectureIVecteur()
        {
            return numericUpDownI.Value;
        }

        public decimal LectureJVecteur()
        {
            return numericUpDownJ.Value;
        }

        public int LectureAddSousSelectionner()
        {
            if (radioButtonAddition.Checked)
            {
                return 0;
            }
            else if (radioButtonSous.Checked)
            {
                return 1;
            }
            else
            {
                return 2;
            }
        }

        public int LectureProduitSelectionner()
        {
            if (radioButtonVectoriel.Checked)
            {
                return 0;
            }
            else if (radioButtonScalaire.Checked)
            {
                return 1;
            }
            else
            {
                return 2;
            }
        }

        public int LectureIndexVecteurXSelectionnerAddSous()
        {
            return comboBoxXAddSous.SelectedIndex;
        }

        public int LectureIndexVecteurYSelectionnerAddSous()
        {
            return comboBoxYAddSous.SelectedIndex;
        }

        public int LectureIndexVecteurXSelectionnerProduit()
        {
            return comboBoxXProduit.SelectedIndex;
        }

        public int LectureIndexVecteurYSelectionnerProduit()
        {
            return comboBoxYProduit.SelectedIndex;
        }

        public decimal LectureMultiplicateurX()
        {
            return numericUpDownXAddSous.Value;
        }

        public decimal LectureMultiplicateurY()
        {
            return numericUpDownYAddSous.Value;
        }

        public string LectureNomVecteur()
        {
            return textBoxNomVecteur.Text;
        }

        public decimal LectureMinX()
        {
            return numericUpDownGraphiqueXmin.Value;
        }

        public decimal LectureMaxX()
        {
            return numericUpDownGraphiqueXmax.Value;
        }

        public decimal LectureMinY()
        {
            return numericUpDownGraphiqueYmin.Value;
        }

        public decimal LectureMaxY()
        {
            return numericUpDownGraphiqueYmax.Value;
        }
    }
}
