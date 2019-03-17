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
    public partial class UC_AjoutCours : UC_Ajout
    {
        public UC_AjoutCours()
        {
            InitializeComponent();
        }

        public UC_AjoutCours(UC_OngletDiplomes cadre) : base(cadre)
        {
            InitializeComponent();
            //this.gBTitre.Text = "Ajouter un cours : ";
        }

        private void bCreer_Click(object sender, EventArgs e)
        {
            // Ajouter un cours
        }
    }
}
