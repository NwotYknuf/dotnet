using dotnet.UserControler.Affichage.Personnel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dotnet.Fenetres.Suppression
{
    public partial class FenetreSupprimerPersonnel : FenetreSupprimer
    {
        private UC_ElementPersonnel _cadre;
        private personnel _personnel;

        public FenetreSupprimerPersonnel()
        {
            InitializeComponent();
        }

        public FenetreSupprimerPersonnel(UC_ElementPersonnel cadre, personnel p)
        {
            InitializeComponent();
            _cadre = cadre;
            _personnel = p;

            lTitre.Text = "Êtes vous sûr de vouloir supprimer le personnel suivant : ";
            lNomElement.Text = _personnel.nom + " " + _personnel.prenom;
        }

        private void bAnnuler_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void bValider_Click(object sender, EventArgs e)
        {
            _cadre.suppressionConfirmee(_personnel);
            this.Dispose();
        }
    }
}
