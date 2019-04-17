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
    public partial class FenetreSupprimerTypeDeCours : FenetreSupprimer
    {
        private FenetreRetrait _fen;
        private type_cours _tc;

        public FenetreSupprimerTypeDeCours()
        {
            InitializeComponent();
        }

        public FenetreSupprimerTypeDeCours(FenetreRetrait f, type_cours tc)
        {
            InitializeComponent();
            _fen = f;
            _tc = tc;

            lTitre.Text = "Êtes vous sûr de vouloir supprimer le type de cours suivant : ";
            lNomElement.Text = _tc.nom;
        }

        private void bAnnuler_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void bValider_Click(object sender, EventArgs e)
        {
            _fen.suppressionConfirmee();
            this.Dispose();
        }
    }
}
