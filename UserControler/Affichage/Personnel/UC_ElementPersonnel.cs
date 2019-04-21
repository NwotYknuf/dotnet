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

namespace dotnet.UserControler.Affichage.Personnel
{
    public partial class UC_ElementPersonnel : UC_ElementP
    {
        private personnel _personnel;

        public UC_ElementPersonnel()
        {
            InitializeComponent();
        }

        public UC_ElementPersonnel(UC_OngletPersonnels cadre, personnel p) : base(cadre)
        {
            _personnel = p;
            InitializeComponent();
            gBAffElement.Text = "";
            tBNom.Text = _personnel.nom;
            tBPrenom.Text = _personnel.prenom;
            tBTelephone.Text = _personnel.telephone;
            tBAdresseEmail.Text = _personnel.email;
            tBAdressePost.Text = _personnel.adresse;
            tBCategorie.Text = Requetes.obtientCategorieduPersonnel(_personnel).nom;
            tBNbHeuresAttrib.Text = Requetes.nbrHeureAttribuees(_personnel).ToString();
            tBNbHeuresNonAttrib.Text = Requetes.nbrHeureManquantes(_personnel).ToString();
        }

        public void nonModifiable()
        {
            this.panel.MouseEnter -= new System.EventHandler(this.panel_MouseEnter);
            this.panel.MouseLeave -= new System.EventHandler(this.panel_MouseLeave);
            this.panel.MouseHover -= new System.EventHandler(this.panel_MouseHover);
            this.panel.DoubleClick -= new System.EventHandler(this.panel_DoubleClick);
            
            tBNom.Enabled = false;
            tBPrenom.Enabled = false;
            tBTelephone.Enabled = false;
            tBAdresseEmail.Enabled = false;
            tBAdressePost.Enabled = false;
            tBCategorie.Enabled = false;
            tBNbHeuresAttrib.Enabled = false;
            tBNbHeuresNonAttrib.Enabled = false;
        }

        private void panel_DoubleClick(object sender, EventArgs e)
        {
            // Afficher les informations du personnel et la liste des cours qu'il présente
            _cadre.affichePersonnelSelectionne(_personnel);
        }

        private void pBModifier_Click(object sender, EventArgs e)
        {
            new FenetreModifPersonnel(this, _personnel).Show();
        }

        private void pBSupprimer_Click(object sender, EventArgs e)
        {
            new FenetreSupprimerPersonnel(this, _personnel).Show();
        }

        public void suppressionConfirmee(personnel p)
        {
            Requetes.retirerPersonnel(p);
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
