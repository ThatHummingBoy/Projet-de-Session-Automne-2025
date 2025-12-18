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

        public event EventHandler ModifierValeurMinX;
        public event EventHandler ModifierValeurMinY;
        public event EventHandler ModifierValeurMaxX;
        public event EventHandler ModifierValeurMaxY;
        public event EventHandler ModifierAutoXClique;
        public event EventHandler ModifierAutoYClique;
        public event EventHandler EffacerGraphiqueClique;

        public void AjouterVecteur(decimal coordonne_i, decimal coordonne_j, string nom_vecteur)
        {
            // Convertir en double[] pour ScottPlot
            double[] xs = new double[] { 0.0, (double)coordonne_i };
            double[] ys = new double[] { 0.0, (double)coordonne_j };

            // Ajouter la série en fournissant un label pour qu'une entrée de légende soit créée automatiquement
            // Selon la version de ScottPlot, l'appel peut être Plot.Add.Scatter(...) ou Plot.AddScatter(...).
            // Ici on utilise l'API existante dans le fichier : Plot.Add.Scatter(..., label: ...)
            FormsPlotGraphique.Plot.Add.Scatter(xs, ys);
            FormsPlotGraphique.Plot.Add.Legend();
            FormsPlotGraphique.Plot.ShowLegend();

            FormsPlotGraphique.Refresh();
            return;
        }

        public void ModifierMinX(double xmin, double xmax)
        {
            FormsPlotGraphique.Plot.Axes.SetLimitsX(xmin, xmax);
            RefreshGraphique();
            return;
        }

        public void ModifierMaxX(double xmin, double xmax)
        {
            FormsPlotGraphique.Plot.Axes.SetLimitsX(xmin, xmax);
            RefreshGraphique();
            return;
        }

        public void ModifierMinY(double xmin, double xmax)
        {
            FormsPlotGraphique.Plot.Axes.SetLimitsY(xmin, xmax);
            RefreshGraphique();
            return;
        }

        public void ModifierMaxY(double xmin, double xmax)
        {
            FormsPlotGraphique.Plot.Axes.SetLimitsY(xmin, xmax);
            RefreshGraphique();
            return;
        }

        public void ModifierAutoX()
        {
            FormsPlotGraphique.Plot.Axes.AutoScaleX();
            RefreshGraphique();
            return;
        }

        public void ModifierAutoY()
        {
            FormsPlotGraphique.Plot.Axes.AutoScaleY();
            RefreshGraphique();
            return;
        }

        public void EffacerGraphique()
        {
            FormsPlotGraphique.Plot.Clear();
            RefreshGraphique();
            return;
        }

        public void RefreshGraphique()
        {
            FormsPlotGraphique.Refresh();
        }
    }
}
