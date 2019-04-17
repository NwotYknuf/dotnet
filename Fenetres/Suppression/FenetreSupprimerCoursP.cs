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
    public partial class FenetreSupprimerCoursP : FenetreSupprimer
    {
        private UC_ElementCoursPersonnel _cadre;
        private cours _cours;

        public FenetreSupprimerCoursP()
        {
            InitializeComponent();
        }

        public FenetreSupprimerCoursP(UC_ElementCoursPersonnel cadre, cours c)
        {
            InitializeComponent();
            _cadre = cadre;
            _cours = c;

            lTitre.Text = "Êtes vous sûr de vouloir supprimer le cours suivant : ";
            lNomElement.Text = _cours.nom;
        }

        private void bAnnuler_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void bValider_Click(object sender, EventArgs e)
        {
            _cadre.suppressionConfirmee(_cours);
            this.Dispose();
        }
    }
}
