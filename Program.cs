using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dotnet
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Bonjour

            try {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new FenetrePrincipale());
            }
            catch (PasDeConnexion e) {
                MessageBox.Show("La connexion avec la base de données n'a pas pu être etablie.\nL'application va se fermer.", "Erreur");
            }
            
        }
    }
}
