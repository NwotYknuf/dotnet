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
using System.Data.Entity.Migrations;

namespace dotnet.UserControler
{
    public partial class UC_OngletGestion : UC_Onglet
    {
        public UC_OngletGestion()
        {
            InitializeComponent();
        }

        private void UC_OngletGestion_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns[0].ReadOnly = true;

            toolTip1.SetToolTip(this.pBAjoutLigne, "Ajouter une catégorie (ligne)");
            toolTip1.SetToolTip(this.pBAjoutColonne, "Ajouter un type de cours (colonne)");
            toolTip1.SetToolTip(this.pBRetraitLigne, "Retirer une catégorie (ligne)");
            toolTip1.SetToolTip(this.pBRetraitColonne, "Retirer un type de cours (colonne)");
            toolTip1.SetToolTip(this.pBEnregistrer, "Enregistrer les modifications du tableau");

            initialiserTableau();
            initialiserValeurs();

            pBEnregistrer.Visible = false;
        }

        public DataGridView getDataGridView1()
        {
            return dataGridView1;
        }

        private void initialiserTableau()
        {
            var categories = Database.instance.categorie;
            var typesCours = Database.instance.type_cours;

            foreach (type_cours tC in typesCours)
            {
                dataGridView1.Columns.Add("Column" + dataGridView1.Columns.Count, tC.nom);
                dataGridView1.Columns[dataGridView1.ColumnCount - 1].MinimumWidth = 100;
            }

            foreach (categorie c in categories)
            {
                //Remplissage de :
                // Colonne 1 : Catégories
                dataGridView1.Rows.Add(c.nom);
                // Colonne 2 : nombre d'heures imposées de la catégorie
                dataGridView1.Rows[dataGridView1.RowCount - 1].Cells[1].Value = c.nbrHeureDues;
            }
        }

        private void initialiserValeurs()
        {
            // Remplie les ratios entre catégorie et type de cours :
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                for (int i = 2; i < dataGridView1.Columns.Count; i++)
                {
                    String nomColonne = dataGridView1.Columns[i].HeaderText;
                    String nomLigne = row.Cells[0].Value.ToString();

                    type_cours typC = Requetes.retrouveTypeDeCoursViaTexte(nomColonne);
                    categorie cat = Requetes.retrouveCategorieViaTexte(nomLigne);

                    equivalent_td equivalent = Requetes.obtientEquivalentTD(typC, cat);

                    row.Cells[i].Value = equivalent.ratio;
                }
            }
        }

        private void viderTableau()
        {
            int nbLigne = (dataGridView1.Rows.Count - 1);
            for (int i = nbLigne; i >= 0; i--)
            {
                    dataGridView1.Rows.RemoveAt(i);
            }
            int nbColonne = (dataGridView1.Columns.Count-1);
            for (int i = nbColonne; i >= 2; i--)
            {
                dataGridView1.Columns.RemoveAt(i);
            }
        }

        private void pBAjoutLigne_Click(object sender, EventArgs e)
        {
            new FenetreAjout("Entrez le nom de la catégorie :", this, "ligne").Show();
        }

        private void pBAjoutColonne_Click(object sender, EventArgs e)
        {
            new FenetreAjout("Entrez le nom du type de cours :", this, "colonne").Show();
        }

        private void pBRetraitLigne_Click(object sender, EventArgs e)
        {
            new FenetreRetrait("Quelle catégorie voulez-vous retirer ?", this, "ligne").Show();
        }

        private void pBRetraitColonne_Click(object sender, EventArgs e)
        {
            new FenetreRetrait("Quel type de cours voulez-vous retirer ?", this, "colonne").Show();
        }

        private void pBEnregistrer_Click(object sender, EventArgs e)
        {

            if (remplieDeChiffres())
            {
                lErreur.Visible = false;

                enregistrer();

                MessageBox.Show("Les informations ont bien été mises à jour.");
                pBEnregistrer.Visible = false;
            }
            else
            {
                lErreur.Visible = true;
            }
        }

        private void enregistrer()
        {
                //Enregistrer dans les tables les modifications et / ou ajouts

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    String nomColonne, nomLigne;

                    // Enregistre le nombre d'heures dans la classe Categorie :
                    nomLigne = row.Cells[0].Value.ToString();

                    categorie categorie = Requetes.retrouveCategorieViaTexte(nomLigne);

                    categorie.nbrHeureDues = Convert.ToInt32(row.Cells[1].Value);

                    // Enregistre les ratios entre catégories et type de cours dans la classe equivalent_td
                    for (int i = 2; i < dataGridView1.Columns.Count; i++)
                    {
                        nomColonne = dataGridView1.Columns[i].HeaderText;
                        nomLigne = row.Cells[0].Value.ToString();

                        type_cours typC = Requetes.retrouveTypeDeCoursViaTexte(nomColonne);
                        categorie cat = Requetes.retrouveCategorieViaTexte(nomLigne);

                        equivalent_td equivalent = new equivalent_td();

                        if (row.Cells[i].Value.ToString().Contains('.')) // Format décimal avec un point comme virgule (a.aaaa)
                            equivalent.ratio = Math.Round(Convert.ToDouble(row.Cells[i].Value.ToString().Replace('.', ',')), 6);

                        else if (row.Cells[i].Value.ToString().Contains('/')) // Format décimal sous forme de fraction (a/b)
                        {
                            String[] data = row.Cells[i].Value.ToString().Split('/');
                            equivalent.ratio = Math.Round((Convert.ToDouble(data[0]) / Convert.ToDouble(data[1])), 6);
                        }

                        else // Format décimal classique avec une virgule (a,aaaa)
                            equivalent.ratio = Math.Round(Convert.ToDouble(row.Cells[i].Value), 6);

                        equivalent.id_categ = cat.id;
                        equivalent.id_type_cours = typC.id;

                        equivalent.categorie = cat;
                        equivalent.type_cours = typC;

                        // Ajoute ou met à jour
                        Requetes.ajouterEquivalentTD(equivalent);
                    }
                }

                // Sauvegarde les modifications
                Requetes.enregistreLaBDD();
                Actualiser();            
        }
        
        private bool remplieDeChiffres()
        {
            bool remplieDeChiffres = false;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (Utilitaires.conditionsRespecteesNombre(row.Cells[1].Value.ToString()))
                {
                    for (int i = 2; i < dataGridView1.Columns.Count; i++)
                    {
                        if (Utilitaires.conditionsRespecteesNombreDecimaux(row.Cells[i].Value.ToString()))
                            remplieDeChiffres = true;
                        else
                            return false;
                    }
                }
                else
                    return false;
            }
            return remplieDeChiffres;
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            pBEnregistrer.Visible = true;
        }

        public void ajout(String element, String nom)
        {
            if (element == "colonne") // Colonne : Type de Cours
            {                
                // Tableau
                dataGridView1.Columns.Add("Column" + dataGridView1.Columns.Count, nom);
                // Toutes les valeurs à 0 par défaut
                foreach(DataGridViewRow dgvr in dataGridView1.Rows)
                {
                    dgvr.Cells[dataGridView1.Columns.Count - 1].Value = 0.0; 
                }

                // BDD
                type_cours typCoursAAjouter = new type_cours();
                typCoursAAjouter.nom = nom;

                Requetes.ajouterTypeDeCours(typCoursAAjouter);
            }
            else // Ligne : Categorie 
            {
                // Tableau
                dataGridView1.Rows.Add(nom);
                // Toutes les valeurs à 0 par défaut
                for (int i = 1; i < dataGridView1.Columns.Count; i++)
                {
                    dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[i].Value = 0.0; 
                }

                // BDD
                categorie catAAjouter = new categorie();
                catAAjouter.nom = nom;

                Requetes.ajouterCategorie(catAAjouter);
            }

            // Sauvegarde les modifications
            Requetes.enregistreLaBDD();

            enregistrer();
        }

        public void retrait(String element, String nom, int index)
        {
            if (element == "colonne") // Colonne : Type de Cours
            {
                // Tableau
                dataGridView1.Columns.RemoveAt(index + 2); // + 2 car les deux premières colonnes du tableau ne doivent pas être comptée

                // BDD
                //Requete pour retrouver le type_cours possedant le nom choisi
                type_cours typeDeCoursARetirer = Requetes.retrouveTypeDeCoursViaTexte(nom);

                if (Requetes.peutSupprimer(typeDeCoursARetirer)) {
                    Requetes.retirerTypeDeCours(typeDeCoursARetirer);
                }
                else {
                    MessageBox.Show("Il existe encore des cours de ce type, suppression impossible");
                }

            }
            else // Ligne : Categorie
            {
                // Tableau
                dataGridView1.Rows.RemoveAt(index);

                // BDD
                //Requete pour retrouver la categorie possedant le nom choisi
                categorie catARetirer = Requetes.retrouveCategorieViaTexte(nom);

                if (Requetes.peutSupprimer(catARetirer)) {
                    Requetes.retirerCategorie(catARetirer);
                }
                else {
                    MessageBox.Show("Il existe encore des proffesseurs de cette categorie, suppression impossible");
                }
            }

            // Sauvegarde les modifications
            Requetes.enregistreLaBDD();

            enregistrer();
        }

        public override void Actualiser()
        {
            viderTableau();
            initialiserTableau();
            initialiserValeurs();
        }

        private void pBAjoutColonne_MouseEnter(object sender, EventArgs e)
        {
            changeCouleurDeFondFoncee(pBAjoutColonne);
        }

        private void pBAjoutColonne_MouseLeave(object sender, EventArgs e)
        {
            changeCouleurDeFondClaire(pBAjoutColonne);
        }

        private void pBRetraitColonne_MouseEnter(object sender, EventArgs e)
        {
            changeCouleurDeFondFoncee(pBRetraitColonne);
        }

        private void pBRetraitColonne_MouseLeave(object sender, EventArgs e)
        {
            changeCouleurDeFondClaire(pBRetraitColonne);
        }

        private void pBAjoutLigne_MouseEnter(object sender, EventArgs e)
        {
            changeCouleurDeFondFoncee(pBAjoutLigne);
        }

        private void pBAjoutLigne_MouseLeave(object sender, EventArgs e)
        {
            changeCouleurDeFondClaire(pBAjoutLigne);
        }

        private void pBRetraitLigne_MouseEnter(object sender, EventArgs e)
        {
            changeCouleurDeFondFoncee(pBRetraitLigne);
        }

        private void pBRetraitLigne_MouseLeave(object sender, EventArgs e)
        {
            changeCouleurDeFondClaire(pBRetraitLigne);
        }

        private void pBEnregistrer_MouseEnter(object sender, EventArgs e)
        {
            changeCouleurDeFondFoncee(pBEnregistrer);
        }

        private void pBEnregistrer_MouseLeave(object sender, EventArgs e)
        {
            changeCouleurDeFondClaire(pBEnregistrer);
        }

        private void changeCouleurDeFondFoncee(PictureBox pb)
        {
            pb.BackColor = SystemColors.ControlLight;
        }

        private void changeCouleurDeFondClaire(PictureBox pb)
        {
            pb.BackColor = SystemColors.Control;
        }
    }
}
