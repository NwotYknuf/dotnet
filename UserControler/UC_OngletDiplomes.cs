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
    public partial class UC_OngletDiplomes : UserControl
    {
    
        public UC_OngletDiplomes()
        {
            InitializeComponent();

            afficheRacine();
            
            
        }



        public void afficheRacine()
        {
            //TODO : Remplacer cette section par un truc plus propre
            Point loc  = uC_Ajout1.Location;
            uC_Ajout1.Dispose();
            uC_Ajout1 = new UC_AjoutDiplome();
            uC_Ajout1.Location = loc;
            Controls.Add(uC_Ajout1);

            uC_Affichage1.clearElements();
            
            var diplomes = Database.instance.diplome;
            foreach (diplome d in diplomes)
            {
                uC_Affichage1.addElement(new UC_ElementDiplome(this, d));
            }
            uC_Affichage1.updateAffichage();
                
        }

        public void afficheDiplome(diplome d)
        {
            lTitre.Text = "Annees";
            
            foreach (annee a in d.annee)
            {
                //uC_Affichage1.addElement(new UC_ElementAnnee(this, a));
            }
            }
            // changer l'UC ajout
        

        public void afficheAnnee(annee a)
        {

        }
    }
}
