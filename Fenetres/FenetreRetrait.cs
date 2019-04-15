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
                        foreach(DataGridViewRow dgvr in dgv.Rows)
                        {
                            try
                            {
                                cBListe.Items.Add(dgvr.Cells["Column1"].Value.ToString());
                            }
                            catch { } // Le dernier élément est vide et génère une exception inutile
                        }
                        break;
                    }
                case "colonne":
                    {
                        foreach (DataGridViewColumn dgvc in dgv.Columns.Cast<DataGridViewColumn>().Skip(1)) // Excepté le 1er élément
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
                            var categories = Database.instance.categorie;
                            categorie categorieChoisie = new categorie();

                            foreach (categorie c in categories)
                            {
                                if (c.nom == cBListe.Text)
                                    categorieChoisie = c;
                            }
                            new FenetreSupprimer("Categorie", categorieChoisie, this).Show();
                            break;
                        }
                    case "colonne":
                        {
                            var type_cours = Database.instance.type_cours;
                            type_cours typeDeCoursChoisie = new type_cours();

                            foreach (type_cours tc in type_cours)
                            {
                                if (tc.nom == cBListe.Text)
                                    typeDeCoursChoisie = tc;
                            }
                            new FenetreSupprimer("Type_Cours", typeDeCoursChoisie, this).Show();
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

    public void suppressionValidee()
        {
            lErreur.Visible = false;
            // Retrait dans la BDD



            // Retrait dans le tableau
            _uC.retrait(_element, cBListe.Text, cBListe.Items.IndexOf(cBListe.Text));

            this.Dispose();
        }
    }
}
