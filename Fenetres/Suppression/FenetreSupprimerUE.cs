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
    public partial class FenetreSupprimerUE : FenetreSupprimer
    {
        private UC_ElementUE _cadre;
        private ue _ue;

        public FenetreSupprimerUE()
        {
            InitializeComponent();
        }

        public FenetreSupprimerUE(UC_ElementUE cadre, ue u)
        {
            InitializeComponent();
            _cadre = cadre;
            _ue = u;

            lTitre.Text = "Êtes vous sûr de vouloir supprimer l'UE suivante : ";
            lNomElement.Text = _ue.nom;
        }

        private void bAnnuler_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void bValider_Click(object sender, EventArgs e)
        {
            _cadre.suppressionConfirmee(_ue);
            this.Dispose();
        }
    }
}
