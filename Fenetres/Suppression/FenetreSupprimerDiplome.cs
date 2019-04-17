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
    public partial class FenetreSupprimerDiplome : FenetreSupprimer
    {
        private UC_ElementDiplome _cadre;
        private diplome _diplome;

        public FenetreSupprimerDiplome()
        {
            InitializeComponent();
        }

        public FenetreSupprimerDiplome(UC_ElementDiplome cadre, diplome d)
        {
            InitializeComponent();
            _cadre = cadre;
            _diplome = d;

            lTitre.Text = "Êtes vous sûr de vouloir supprimer le diplome suivant : ";
            lNomElement.Text = _diplome.nom;
        }

        private void bAnnuler_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void bValider_Click(object sender, EventArgs e)
        {
            _cadre.suppressionConfirmee(_diplome);
            this.Dispose();
        }
    }
}
