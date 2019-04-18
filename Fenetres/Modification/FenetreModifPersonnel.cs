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

namespace dotnet.Fenetres.Modification
{
    public partial class FenetreModifPersonnel : FenetreModif
    {
        private UC_ElementPersonnel _cadre;
        private personnel _personnel;

        public FenetreModifPersonnel()
        {
            InitializeComponent();
        }

        public FenetreModifPersonnel(UC_ElementPersonnel cadre, personnel p)
        {
            InitializeComponent();
            _cadre = cadre;
            _personnel = p;

            tBNom.Text = _personnel.nom;
            tBPrenom.Text = _personnel.prenom;
            tBTelephone.Text = _personnel.telephone;
            tBAdresseEmail.Text = _personnel.email;
            tBAdressePost.Text = _personnel.adresse;

            initialiseCBCategorie();
        }

        private void initialiseCBCategorie()
        {
            var categories = Database.instance.categorie;
            foreach (categorie c in categories)
                cBCategorie.Items.Add(c.nom);

            cBCategorie.SelectedIndex = cBCategorie.Items.IndexOf(_personnel.categorie.nom);
        }

        private void bAnnuler_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void bValider_Click(object sender, EventArgs e)
        {
            if ((Utilitaires.conditionsRespectees(tBNom.Text, true, false, false, false, 2, 50)) &&
                (Utilitaires.conditionsRespectees(tBPrenom.Text, true, false, false, false, 2, 50)) &&
                (Utilitaires.conditionsRespecteesEmail(tBAdresseEmail.Text)) &&
                (Utilitaires.conditionsRespecteesAdressePostale(tBAdressePost.Text)) &&
                (Utilitaires.conditionsRespecteesTelephone(tBTelephone.Text)) &&
                (Utilitaires.conditionsRespectees(cBCategorie.Text, cBCategorie)))
            {
                lErreur.Visible = false;

                //Modification d'un personnel
                _personnel.nom = this.tBNom.Text;
                _personnel.prenom = this.tBPrenom.Text;
                _personnel.email = this.tBAdresseEmail.Text;
                _personnel.adresse = this.tBAdressePost.Text;
                _personnel.telephone = this.tBTelephone.Text;

                categorie catActuelle = Database.instance.categorie.Where(s => s.nom == _personnel.categorie.nom).FirstOrDefault<categorie>();
                catActuelle.personnel.Remove(_personnel);

                categorie catNouvelle = Database.instance.categorie.Where(s => s.nom == cBCategorie.Text).FirstOrDefault<categorie>();
                _personnel.categorie = catNouvelle;
                catNouvelle.personnel.Add(_personnel);

                // Ajouter à la BDD
                _cadre.modificationConfirmee();

                MessageBox.Show("Le personnel " + _personnel.nom + " " + _personnel.prenom + " a été modifié avec succès.");

                this.Dispose();
            }
            else
            {
                lErreur.Visible = true;
            }
        }
    }
}
