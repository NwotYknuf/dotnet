using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dotnet.Fenetres;
using dotnet.Fenetres.Suppression;
using dotnet.Fenetres.Modification;

namespace dotnet.UserControler.Affichage
{
    public partial class UC_ElementAnnee : UC_ElementD
    {
        private annee _annee;

        public UC_ElementAnnee()
        {
            InitializeComponent();
        }

        public UC_ElementAnnee(UC_OngletDiplomes cadre, annee a) : base(cadre) {
            _annee = a;
            InitializeComponent();
            gBAffElement.Text = _annee.nom;
            tBDesc.Text = _annee.description;
        }

        private void panel_DoubleClick(object sender, EventArgs e)
        {
            // Afficher les périodes de l'année séléctionnée
            _cadre.afficheAnneeSelectionnee(_annee);
        }

        private void pBModifier_Click(object sender, EventArgs e)
        {
            new FenetreModifAnnee(this, _annee).Show();
        }

        private void pBSupprimer_Click(object sender, EventArgs e)
        {
            new FenetreSupprimerAnnee(this, _annee).Show();
        }

        public void suppressionConfirmee(annee a)
        {
            Requetes.retirerAnnee(a);
            Requetes.enregistreLaBDD();
            _cadre.Actualiser();
        }

        public void modificationConfirmee()
        {
            Requetes.enregistreLaBDD();
            _cadre.Actualiser();
        }

        private void panel_MouseEnter(object sender, EventArgs e)
        {
            panel.BackColor = Utilitaires.couleurBleuTurquoiseFonce();
        }

        private void panel_MouseLeave(object sender, EventArgs e)
        {
            panel.BackColor = Utilitaires.couleurBleuTurquoise();
        }

        private void panel_MouseHover(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.Hand;
        }
    }
}
