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
using dotnet.UserControler.Affichage;

namespace dotnet
{
    public partial class UC_OngletRecherche : UserControl
    {
        public UC_OngletRecherche()
        {
            InitializeComponent();
        }

        private void UC_OngletRecherche_Load(object sender, EventArgs e)
        {
            uC_Affichage1.setGroupBoxTiTre("Résultats de la recherche : ");
        }

        private void bLancerRech_Click(object sender, EventArgs e)
        {
            if((Utilitaires.conditionsRespectees(tbRecherche.Text.Trim(), true, true, true, false, 2, 100)) && 
               (Utilitaires.conditionsRespectees(cBCritere.Text, cBCritere)) )
            {
                lErreur.Visible = false;

                // Rechercher

                switch(cBCritere.Text)
                {
                    case "diplome":
                        {
                            /*var resultats = Database.instance.diplome;
                            foreach (diplome d in resultats.ToList())
                            {
                                uC_Affichage1.addElement(new UC_ElementDiplome(this, d));
                            }
                            uC_Affichage1.updateAffichage();*/
                            break;
                        }
                    case "annee":
                        {
                            break;
                        }
                    case "periode":
                        {
                            break;
                        }
                    case "ue":
                        {
                            break;
                        }
                    case "ec":
                        {
                            break;
                        }
                    case "cours":
                        {
                            break;
                        }
                    case "personnel":
                        {
                            break;
                        }
                    case "categorie":
                        {
                                                        
                            break;
                        }
                    case "Type_Cours":
                        {                            
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

        public void Actualiser()
        {
            this.Update();
        }
    }
}
