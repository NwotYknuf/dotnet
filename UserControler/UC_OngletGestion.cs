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

namespace dotnet
{
    public partial class UC_OngletGestion : UserControl
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
            
            var categories = Database.instance.categorie;
            var typesCours = Database.instance.type_cours;
                        
            foreach (type_cours tC in typesCours)
            {
                dataGridView1.Columns.Add("Column" + dataGridView1.Columns.Count, tC.nom);
            }

            foreach (categorie c in categories)
            {
                dataGridView1.Rows.Add(c.nom);
            }

            initialiserValeurs();
            
            pBEnregistrer.Visible = false;
        }

        public DataGridView getDataGridView1()
        {
            return dataGridView1;
        }

        public void ajout(String element, String nom)
        {
            if (element == "colonne") // Colonne : Type de Cours
            {                
                // Tableau
                dataGridView1.Columns.Add("Column" + dataGridView1.Columns.Count, nom);
                foreach(DataGridViewRow dgvr in dataGridView1.Rows)
                {
                    dgvr.Cells[dataGridView1.Columns.Count - 1].Value = 0.0; // Toutes les valeurs à 0 par défaut
                }

                // BDD
                type_cours typCoursAAjouter = new type_cours();
                typCoursAAjouter.nom = nom;

                Database.instance.type_cours.Add(typCoursAAjouter);
            }
            else // Ligne : Categorie 
            {
                // Tableau
                dataGridView1.Rows.Add(nom);
                for (int i = 1; i < dataGridView1.Columns.Count; i++)
                {
                    dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[i].Value = 0.0; // Toutes les valeurs à 0 par défaut
                }

                // BDD
                categorie catAAjouter = new categorie();
                catAAjouter.nom = nom;

                Database.instance.categorie.Add(catAAjouter);
            }

            // Sauvegarde les modifications
            Database.instance.SaveChanges();
        }

        public void retrait(String element, String nom, int index)
        {
            if (element == "colonne") // Colonne : Type de Cours
            {
                // Tableau
                dataGridView1.Columns.RemoveAt(index + 1);

                // BDD
                //Requete pour retrouver le type_cours possedant le nom choisi
                type_cours typeDeCoursARetirer = Database.instance.type_cours.Where(s => s.nom == nom).FirstOrDefault<type_cours>();

                Database.instance.type_cours.Remove(typeDeCoursARetirer);
            }
            else // Ligne : Categorie
            {
                // Tableau
                dataGridView1.Rows.RemoveAt(index);

                // BDD
                //Requete pour retrouver la categorie possedant le nom choisi
                categorie catARetirer = Database.instance.categorie.Where(s => s.nom == nom).FirstOrDefault<categorie>();

                Database.instance.categorie.Remove(catARetirer);
            }

            // Sauvegarde les modifications
            Database.instance.SaveChanges();
        }

        private void initialiserValeurs()
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                for (int i = 1; i < dataGridView1.Columns.Count; i++)
                {
                    String nomColonne = dataGridView1.Columns[i].HeaderText;
                    String nomLigne = row.Cells[0].Value.ToString();

                    type_cours typC = Database.instance.type_cours.Where(s => s.nom == nomColonne).FirstOrDefault<type_cours>();
                    categorie cat = Database.instance.categorie.Where(s => s.nom == nomLigne).FirstOrDefault<categorie>();

                    equivalent_td equivalent = Database.instance.equivalent_td.Where(x => x.id_type_cours == typC.id && x.id_categ == cat.id).FirstOrDefault<equivalent_td>();
                    
                    row.Cells[i].Value = equivalent.ratio;
                }
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
            //Enregistrer dans les tables les modifications et / ou ajouts

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                for (int i = 1; i < dataGridView1.Columns.Count; i++)
                {
                    String nomColonne = dataGridView1.Columns[i].HeaderText;
                    String nomLigne = row.Cells[0].Value.ToString();

                    type_cours typC = Database.instance.type_cours.Where(s => s.nom == nomColonne).FirstOrDefault<type_cours>();
                    categorie cat = Database.instance.categorie.Where(s => s.nom == nomLigne).FirstOrDefault<categorie>();

                    equivalent_td equivalent = new equivalent_td();
                                        
                    equivalent.ratio = Convert.ToDouble(row.Cells[i].Value);
                    equivalent.id_categ = cat.id;
                    equivalent.id_type_cours = typC.id;

                    equivalent.categorie = cat;
                    equivalent.type_cours = typC;

                    Database.instance.equivalent_td.AddOrUpdate(equivalent); //requiert : using System.Data.Entity.Migrations;
                }
            }

            // Sauvegarde les modifications
            Database.instance.SaveChanges();

            MessageBox.Show("Les informations ont bien été mises à jour.");
            pBEnregistrer.Visible = false;
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            pBEnregistrer.Visible = true;
        }
    }
}
