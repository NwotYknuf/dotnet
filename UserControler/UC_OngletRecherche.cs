using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using dotnet.UserControler.Affichage.Recherche;

namespace dotnet.UserControler
{
    public partial class UC_OngletRecherche : UC_Onglet
    {
        public UC_OngletRecherche()
        {
            InitializeComponent();
        }

        private void UC_OngletRecherche_Load(object sender, EventArgs e)
        {
            uC_Affichage1.setGroupBoxTiTre("Résultats de la recherche : ");
            cBCritere.SelectedIndex = 0;
        }

        private void bLancerRech_Click(object sender, EventArgs e)
        {
            if((Utilitaires.conditionsRespectees(tbRecherche.Text.Trim(), true, true, true, true, 2, 100)) && 
               (Utilitaires.conditionsRespectees(cBCritere.Text, cBCritere)) )
            {
                lErreur.Visible = false;

                // Rechercher

                switch(cBCritere.Text)
                {
                    case "Diplôme":
                        {
                            uC_Affichage1.clearElements();

                            var resultats = Database.instance.diplome;
                            foreach (diplome d in resultats.ToList())
                            {
                                uC_Affichage1.addElement(new UC_ElementDiplomeRech(this, d));
                            }
                            uC_Affichage1.updateAffichage();
                            break;
                        }
                    case "Année":
                        {
                            uC_Affichage1.clearElements();

                            var resultats = Database.instance.annee;
                            foreach (annee a in resultats.ToList())
                            {
                                uC_Affichage1.addElement(new UC_ElementAnneeRech(this, a));
                            }
                            uC_Affichage1.updateAffichage();
                            break;
                        }
                    case "Période":
                        {
                            uC_Affichage1.clearElements();

                            var resultats = Database.instance.periode;
                            foreach (periode p in resultats.ToList())
                            {
                                uC_Affichage1.addElement(new UC_ElementPeriodeRech(this, p));
                            }
                            uC_Affichage1.updateAffichage();
                            break;
                        }
                    case "UE":
                        {
                            uC_Affichage1.clearElements();

                            var resultats = Database.instance.ue;
                            foreach (ue u in resultats.ToList())
                            {
                                uC_Affichage1.addElement(new UC_ElementUERech(this, u));
                            }
                            uC_Affichage1.updateAffichage();
                            break;
                        }
                    case "EC":
                        {
                            uC_Affichage1.clearElements();

                            var resultats = Database.instance.ec;
                            foreach (ec ec in resultats.ToList())
                            {
                                uC_Affichage1.addElement(new UC_ElementECRech(this, ec));
                            }
                            uC_Affichage1.updateAffichage();
                            break;
                        }
                    case "Cours":
                        {
                            uC_Affichage1.clearElements();

                            var resultats = Database.instance.cours;
                            foreach (cours c in resultats.ToList())
                            {
                                uC_Affichage1.addElement(new UC_ElementCoursRech(this, c));
                            }
                            uC_Affichage1.updateAffichage();
                            break;
                        }
                    case "Personnel":
                        {
                            uC_Affichage1.clearElements();

                            var resultats = Database.instance.personnel;
                            foreach (personnel p in resultats.ToList())
                            {
                                uC_Affichage1.addElement(new UC_ElementPersonnelRech(this, p));
                            }
                            uC_Affichage1.updateAffichage();
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

        public override void Actualiser()
        {
            this.Update();
        }
    }
}
