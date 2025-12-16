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
using ScottPlot.WinForms;

namespace Projet_de_Session
{
    public partial class FormGraphique : Form, IVueGraphique
    {
        public FormGraphique()
        {
            InitializeComponent();
        }

        public void AjouterVecteur(decimal coordonne_i, decimal coordonne_j)
        {
            List<decimal> xs = new List<decimal>(2);
            xs.Add(0);
            xs.Add(coordonne_i);

            List<decimal> ys = new List<decimal>(2);
            ys.Add(0);
            ys.Add(coordonne_j);

            FormsPlotGraphique.Plot.Add.Scatter(xs, ys);
            return;
        }

        public void ModifierMinX(double xmin, double xmax)
        {
            FormsPlotGraphique.Plot.Axes.SetLimitsX(xmin, xmax);
            return;
        }

        public void ModifierMaxX(double xmin, double xmax)
        {
            FormsPlotGraphique.Plot.Axes.SetLimitsX(xmin, xmax);
            return;
        }

        public void ModifierMinY(double xmin, double xmax)
        {
            FormsPlotGraphique.Plot.Axes.SetLimitsX(xmin, xmax);
            return;
        }

        public void ModifierMaxY(double xmin, double xmax)
        {
            FormsPlotGraphique.Plot.Axes.SetLimitsX(xmin, xmax);
            return;
        }

        public void ModifierAutoX()
        {
            FormsPlotGraphique.Plot.Axes.AutoScaleX();
            return;
        }

        public void ModifierAutoY()
        {
            FormsPlotGraphique.Plot.Axes.AutoScaleY();
            return;
        }

        public void EffacerGraphiqueClique()
        {
            FormsPlotGraphique.Plot.Clear();
            return;
        }
    }
}
