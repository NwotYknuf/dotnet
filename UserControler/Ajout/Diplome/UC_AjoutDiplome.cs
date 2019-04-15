using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dotnet.UserControler.Ajout {
    public partial class UC_AjoutDiplome : UC_AjoutD
    {
        
        public UC_AjoutDiplome() {
            InitializeComponent();
        }

        public UC_AjoutDiplome(UC_OngletDiplomes cadre) : base(cadre) {
            InitializeComponent();
            //this.gBTitre.Text = "Ajouter un Diplome : ";
        }

        private void bCreer_Click(object sender, EventArgs e)
        {
            if ((Utilitaires.conditionsRespectees(tBNom.Text, true, true, true, false, 2, 100)) &&
                (Utilitaires.conditionsRespectees(rtBDesc.Text, true, true, true, true, 2, 100)))
            {
                lErreur.Visible = false;
                // Ajouter un diplome

            }
            else
            {
                lErreur.Visible = true;
            }
        }
    }
}
