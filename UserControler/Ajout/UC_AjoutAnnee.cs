using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dotnet.UserControler.Ajout
{
    public partial class UC_AjoutAnnee : UC_AjoutD
    {
        public UC_AjoutAnnee()
        {
            InitializeComponent();
        }

        public UC_AjoutAnnee(UC_OngletDiplomes cadre) : base(cadre)
        {
            InitializeComponent();
            //this.gBTitre.Text = "Ajouter une année : ";
        }

        private void bCreer_Click(object sender, EventArgs e)
        {
            // Créer une année
        }
    }
}
