using dotnet.UserControler.Affichage;
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
    public partial class FenetreSupprimerAnnee : FenetreSupprimer
    {
        private UC_ElementAnnee _cadre;
        private annee _annee;

        public FenetreSupprimerAnnee()
        {
            InitializeComponent();
        }

        public FenetreSupprimerAnnee(UC_ElementAnnee cadre, annee a)
        {
            InitializeComponent();
            _cadre = cadre;
            _annee = a;

            lTitre.Text = "Êtes vous sûr de vouloir supprimer l'année suivante : ";
            lNomElement.Text = _annee.nom;
        }

        private void bAnnuler_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void bValider_Click(object sender, EventArgs e)
        {
            _cadre.suppressionConfirmee(_annee);
            this.Dispose();
        }
    }
}
