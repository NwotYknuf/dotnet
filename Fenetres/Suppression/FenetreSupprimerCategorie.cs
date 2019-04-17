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
    public partial class FenetreSupprimerCategorie : FenetreSupprimer
    {
        private FenetreRetrait _fen;
        private categorie _cat;
        
        public FenetreSupprimerCategorie()
        {
            InitializeComponent();
        }

        public FenetreSupprimerCategorie(FenetreRetrait f, categorie c)
        {
            InitializeComponent();
            _fen = f;
            _cat = c;

            lTitre.Text = "Êtes vous sûr de vouloir supprimer la catégorie suivante : ";
            lNomElement.Text = _cat.nom;
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
