using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dotnet.UserControler.Affichage;

namespace dotnet.Fenetres.Suppression
{
    public partial class FenetreSupprimerEC : FenetreSupprimer
    {
        private UC_ElementEC _cadre;
        private ec _ec;

        public FenetreSupprimerEC()
        {
            InitializeComponent();
        }

        public FenetreSupprimerEC(UC_ElementEC cadre, ec e)
        {
            InitializeComponent();
            _cadre = cadre;
            _ec = e;

            lTitre.Text = "Êtes vous sûr de vouloir supprimer l'EC suivante : ";
            lNomElement.Text = _ec.nom;
        }

        private void bAnnuler_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void bValider_Click(object sender, EventArgs e)
        {
            _cadre.suppressionConfirmee(_ec);
            this.Dispose();
        }
    }
}
