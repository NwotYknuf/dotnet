using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dotnet.UserControler.Affichage.Personnel
{
    public partial class UC_ElementAjoutCours : UC_ElementP
    {
        private personnel _personnel;

        public UC_ElementAjoutCours()
        {
            InitializeComponent();
        }

        public UC_ElementAjoutCours(UC_OngletPersonnels cadre, personnel p) : base(cadre)
        {
            InitializeComponent();
            _personnel = p;
        }

        private void pBAjouterCours_Click(object sender, EventArgs e)
        {
            _cadre.ajouterCours(_personnel);
        }

        private void UC_ElementAjoutCours_Load(object sender, EventArgs e)
        {

            toolTip1.SetToolTip(this.pBAjouterCours, "Ajouter un cours au personnel " + _personnel.nom + _personnel.prenom);
        }
    }
}
