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
            //this.gBTitre.Text = "Ajouter un personnel : ";
        }

        private void bCreer_Click(object sender, EventArgs e)
        {
            if ((Utilitaires.conditionsRespectees(tBNom.Text, true, false, false, false, 2, 50)) &&
                (Utilitaires.conditionsRespectees(tBPrenom.Text, true, false, false, false, 2, 50)) &&
                (Utilitaires.conditionsRespecteesEmail(tBAdresseEmail.Text)) &&
                (Utilitaires.conditionsRespectees(tBAdressePost.Text, true, true, true, false, 2, 50)) &&
                (Utilitaires.conditionsRespecteesTelephone(tBTelephone.Text)) &&
                (Utilitaires.conditionsRespectees(cBCategorie.Text, cBCategorie)))
            {
                lErreur.Visible = false;

                // Ajouter un personnel
                personnel per = new personnel();
                per.nom = this.tBNom.Text;
                per.prenom = this.tBPrenom.Text;
                per.email = this.tBAdresseEmail.Text;
                per.adresse = this.tBAdressePost.Text;
                per.telephone = this.tBTelephone.Text;

                categorie cat = Database.instance.categorie.Where(s => s.nom == cBCategorie.Text).FirstOrDefault<categorie>();
                cat.personnel.Add(per);

                per.categorie = cat;

                // Ajouter à la BDD
                Database.instance.personnel.Add(per);

                Requetes.enregistreLaBDD();

                MessageBox.Show("Le personnel " + per.nom + " " + per.prenom + " a été ajouté avec succès.");
            }
            else
                lErreur.Visible = true;
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
        }
    }
}
