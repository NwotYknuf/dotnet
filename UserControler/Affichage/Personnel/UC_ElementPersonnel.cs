using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dotnet.UserControler.Affichage
{
    public partial class UC_ElementPersonnel : UC_ElementP
    {
        private personnel _personnel;

        public UC_ElementPersonnel()
        {
            InitializeComponent();
        }

        public UC_ElementPersonnel(UC_OngletPersonnels cadre, personnel p) : base(cadre)
        {
            _personnel = p;
            InitializeComponent();
            gBAffElement.Text = "";
            tBNom.Text = _personnel.nom;
            tBPrenom.Text = _personnel.prenom;
            //tBCategorie.Text = _personnel.categorie.ToString();
        }

        private void panel_DoubleClick(object sender, EventArgs e)
        {
            // Afficher les informations du personnel et la liste des cours qu'il présente

            _cadre.affichePersonnelSelectionne(_personnel);
        }

        private void pBModifier_Click(object sender, EventArgs e)
        {

        }

        private void pBSupprimer_Click(object sender, EventArgs e)
        {

        }
    }
}
