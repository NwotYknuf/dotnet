using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dotnet
{
    public partial class FenetrePrincipale : Form
    {
        public FenetrePrincipale()
        {
            InitializeComponent();
        }

        private void FenetrePrincipale_Load(object sender, EventArgs e)
        {
            ucAccueil1.BringToFront();
        }

        private void miAcceuil_Click(object sender, EventArgs e)
        {
            ucAccueil1.BringToFront();
        }

        private void miDiplome_Click(object sender, EventArgs e)
        {
            ucListeDiplome1.BringToFront();
        }

        private void miPersonnel_Click(object sender, EventArgs e)
        {
            ucListePersonnel1.BringToFront();
        }

        private void miGestion_Click(object sender, EventArgs e)
        {
            ucGestion1.BringToFront();
        }

        private void miRecherche_Click(object sender, EventArgs e)
        {
            ucRecherche1.BringToFront();
        }
    }
}
