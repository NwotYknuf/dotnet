using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dotnet.UserControler.testUC;

namespace dotnet
{
    public partial class UC_OngletDiplomes : UserControl
    {
    
        public UC_OngletDiplomes()
        {
            InitializeComponent();

            using (sysEntities db = new sysEntities())
            {
                var diplomes = db.diplome;
                
                foreach(diplome d in diplomes){
                    uC_Affichage1.addElement(new UC_ElementDiplome(this, d));
                }

                uC_Affichage1.updateAffichage();


            }
            
        }



        public void afficheRacine()
        {
            //Afficher les diplomes
        }

        public void afficheDiplome(diplome d)
        {
            lTitre.Text = "Annees";

            using (sysEntities db = new sysEntities())
            {

                var annees = db.annee.Where<annee>(a => a.diplome == d);
                foreach (annee a in annees)
                {
                    // uC_Affichage1.addElement(new UC_ElementAnnee(this, a));
                }
            }
            // changer l'UC ajout
        }

        public void afficheAnnee(annee a)
        {

        }
    }
}
