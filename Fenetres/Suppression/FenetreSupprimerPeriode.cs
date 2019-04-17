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
    public partial class FenetreSupprimerPeriode : FenetreSupprimer
    {
        private UC_ElementPeriode _cadre;
        private periode _periode;

        public FenetreSupprimerPeriode()
        {
            InitializeComponent();
        }

        public FenetreSupprimerPeriode(UC_ElementPeriode cadre, periode p)
        {
            InitializeComponent();
            _cadre = cadre;
            _periode = p;

            lTitre.Text = "Êtes vous sûr de vouloir supprimer la période suivante : ";
            lNomElement.Text = _periode.nom;
        }

        private void bAnnuler_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void bValider_Click(object sender, EventArgs e)
        {
            _cadre.suppressionConfirmee(_periode);
            this.Dispose();
        }
    }
}
