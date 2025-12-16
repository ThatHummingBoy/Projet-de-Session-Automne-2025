using Projet_de_Session.Model;
using Projet_de_Session.Presenter;
using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet_de_Session
{
    internal static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var modelcontrolesvecteurs = new ModelControlesVecteurs();
            var formControles = new FormControles();
            var formGraphique = new FormGraphique();

            var presentateur = new PresentateurPrincipal(
                modelcontrolesvecteurs,
                formControles,
                formGraphique);

            Application.Run(new MultiFormContext(new FormControles(), new FormGraphique()));
        }
    }

    public class MultiFormContext : ApplicationContext
    {
        private int openForms;
        public MultiFormContext(params Form[] forms)
        {
            openForms = forms.Length;

            foreach (var form in forms)
            {
                form.FormClosed += (s, args) =>
                {
                    //Quand le « starting » dans le dernier forms, le program arrête.
                    if(Interlocked.Decrement(ref openForms) == 0)
                        ExitThread();
                };

                form.Show();
            }
        }
    }
}
