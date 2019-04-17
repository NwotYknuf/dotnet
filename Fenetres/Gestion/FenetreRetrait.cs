using dotnet.Fenetres.Suppression;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dotnet.Fenetres
{
    public partial class FenetreRetrait : Form
    {
        private UC_OngletGestion _uC;
        private String _element;

        public FenetreRetrait()
        {
            InitializeComponent();
        }

        public FenetreRetrait(String titre, UC_OngletGestion u, String el)
        {
            InitializeComponent();
            this._uC = u;
            this.lTitre.Text = titre;
            this._element = el;

            DataGridView dgv = _uC.getDataGridView1();

            switch(_element)
            {
                case "ligne":
                    {
                        //Récupérer les noms des lignes dans la comboBox
                        foreach(DataGridViewRow dgvr in dgv.Rows)
                        {                            
                             cBListe.Items.Add(dgvr.Cells[0].Value.ToString());
                        }
                        break;
                    }
                case "colonne":
                    {
                        //Récupérer les noms des colonnes dans la comboBox
                        foreach (DataGridViewColumn dgvc in dgv.Columns.Cast<DataGridViewColumn>().Skip(2)) // Excepté les 2 premiers éléments
                        {
                            cBListe.Items.Add(dgvc.HeaderText);
                        }
                        break;
                    }
                default: break;
            }
        }

        private void bAnnuler_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void bValider_Click(object sender, EventArgs e)
        {
            if (Utilitaires.conditionsRespectees(cBListe.Text, cBListe))
            {
                switch (_element)
                {
                    case "ligne":
                        {
                            categorie categorieChoisie = new categorie();
                            
                            //Requete pour retrouver la categorie possedant le nom choisi
                            categorieChoisie = Database.instance.categorie.Where(s => s.nom == cBListe.Text).FirstOrDefault<categorie>();

                            new FenetreSupprimerCategorie(this, categorieChoisie).Show();
                            break;
                        }
                    case "colonne":
                        {
                            type_cours typeDeCoursChoisie = new type_cours();

                            //Requete pour retrouver le type_cours possedant le nom choisi
                            typeDeCoursChoisie = Database.instance.type_cours.Where(s => s.nom == cBListe.Text).FirstOrDefault<type_cours>();

                            new FenetreSupprimerTypeDeCours(this, typeDeCoursChoisie).Show();
                            break;
                        }
                    default: break;
                }
            }
            else
            {
                lErreur.Visible = true;
            }
        }

    public void suppressionConfirmee()
        {
            lErreur.Visible = false;
            _uC.retrait(_element, cBListe.Text, cBListe.Items.IndexOf(cBListe.Text));
            this.Dispose();
        }
    }
}
