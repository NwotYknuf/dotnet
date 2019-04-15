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
            toolTip1.SetToolTip(this.pBAjoutLigne, "Ajouter une catégorie (ligne)");
            toolTip1.SetToolTip(this.pBAjoutColonne, "Ajouter un type de cours (colonne)");
            toolTip1.SetToolTip(this.pBRetraitLigne, "Retirer une catégorie (ligne)");
            toolTip1.SetToolTip(this.pBRetraitColonne, "Retirer un type de cours (colonne)");
            toolTip1.SetToolTip(this.pBEnregistrer, "Enregistrer les modifications");
            
            var categories = Database.instance.categorie;
            var typesCours = Database.instance.type_cours;
            var ratios = Database.instance.equivalent_td;
            

            foreach (type_cours tC in typesCours)
            {
                dataGridView1.Columns.Add("Column", tC.nom);
            }

            foreach (categorie c in categories)
            {
                dataGridView1.Rows.Add(c.nom);
            }
            
        }

        public DataGridView getDataGridView1()
        {
            return dataGridView1;
        }

        public void ajout(String element, String nom)
        {
            if ( element == "colonne" )
                dataGridView1.Columns.Add("Column" + dataGridView1.Columns.Count + 1, nom);
            else
                dataGridView1.Rows.Add(nom);
        }

        public void retrait(String element, String nom, int index)
        {
            if (element == "colonne")
                dataGridView1.Columns.RemoveAt(index + 1);
            else
                dataGridView1.Rows.RemoveAt(index);
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


        }
    }
}
