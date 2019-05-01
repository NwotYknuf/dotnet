using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dotnet.UserControler.Ajout
{
    public partial class UC_AjoutPersonnel : UC_AjoutP
    {
        public UC_AjoutPersonnel()
        {
            InitializeComponent();
        }

        public UC_AjoutPersonnel(UC_OngletPersonnels cadre) : base(cadre)
        {
            InitializeComponent();
        }
        
        private void UC_AjoutPersonnel_Load(object sender, EventArgs e)
        {
            initialiseCBCategorie();
        }
        private void initialiseCBCategorie()
        {
            var categories = Database.instance.categorie;
            foreach (categorie c in categories)
                cBCategorie.Items.Add(c.nom);

            cBCategorie.SelectedIndex = 0;
        }

        private void bCreer_Click(object sender, EventArgs e)
        {
            if (
                (Utilitaires.conditionsRespectees(tBNom.Text, true, false, false, false, 2, 50)) &&
                (Utilitaires.conditionsRespectees(tBPrenom.Text, true, false, false, false, 2, 50)) &&
                (Utilitaires.conditionsRespecteesEmail(tBAdresseEmail.Text)) &&
                (Utilitaires.conditionsRespecteesAdressePostale(tBAdressePost.Text)) &&
                (Utilitaires.conditionsRespecteesTelephone(tBTelephone.Text)) &&
                (Utilitaires.conditionsRespectees(cBCategorie.Text, cBCategorie))) {
                    lErreur.Visible = false;

                    // Créer un personnel
                    personnel per = new personnel();
                    per.nom = this.tBNom.Text;
                    per.prenom = this.tBPrenom.Text;
                    per.email = this.tBAdresseEmail.Text;
                    per.adresse = this.tBAdressePost.Text;
                    per.telephone = this.tBTelephone.Text;

                    categorie cat = Requetes.retrouveCategorieViaTexte(cBCategorie.Text);
                    cat.personnel.Add(per);

                    per.categorie = cat;

                    // Ajouter à la BDD
                    Requetes.ajouterPersonnel(per);
                    Requetes.enregistreLaBDD();
                    MessageBox.Show("Le personnel " + per.nom + " " + per.prenom + " a été ajouté avec succès.");
                    _cadre.Actualiser();
            }
            else{
                lErreur.Visible = true;
            }
        }

        private void tBAdresseEmail_Enter(object sender, EventArgs e)
        {
            if (tBAdresseEmail.Text == "nom.prenom@exemple.com")
            {
                tBAdresseEmail.Text = "";
                tBAdresseEmail.ForeColor = SystemColors.WindowText;
            }
        }

        private void tBAdressePost_Enter(object sender, EventArgs e)
        {
            if (tBAdressePost.Text == "3 rue Augustin Fresnel 57073 METZ")
            {
                tBAdressePost.Text = "";
                tBAdressePost.ForeColor = SystemColors.WindowText;
            }
        }
    }
}
