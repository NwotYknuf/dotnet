using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        public void ajout(String element, String nom)
        {
            if ( element == "colonne" )
                dataGridView1.Columns.Add("Column", nom);
            else
                dataGridView1.Rows.Add(nom);
        }

        private void bAjoutColonne_Click(object sender, EventArgs e)
        {
            new FenetreAjout("Entrez le nom de la colonne :", this, "colonne").Show();
        }

        private void bAjoutLigne_Click(object sender, EventArgs e)
        {
            new FenetreAjout("Entrez le nom de la ligne :", this, "ligne").Show();
        }

        private void bEnregistrer_Click(object sender, EventArgs e)
        {
            //Enregistrer dans les tables les modifications et / ou ajouts


        }
    }
}
