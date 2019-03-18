using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dotnet {
    public partial class UC_OngletDiplomes : UserControl {

        public UC_OngletDiplomes() {
            InitializeComponent();

            afficheRacine();
            
        }

        public void afficheRacine() {
            //TODO : Remplacer cette section par un truc plus propre
            lTitre.Text = "Diplômes : ";
            uC_Affichage1.setGroupBoxTiTre("Liste des diplômes : ");

            Point loc = uC_Ajout1.Location;
            uC_Ajout1.Dispose();
            uC_Ajout1 = new UC_AjoutDiplome(this);
            uC_Ajout1.Location = loc;
            Controls.Add(uC_Ajout1);

            uC_Affichage1.clearElements();

            var diplomes = Database.instance.diplome;
            foreach (diplome d in diplomes) {
                uC_Affichage1.addElement(new UC_ElementDiplome(this, d));
            }
            uC_Affichage1.updateAffichage();

        }

        public void afficheDiplomeSelectionne(diplome d) {

            // changer l'UC ajout

            lTitre.Text = "Années : ";
            uC_Affichage1.setGroupBoxTiTre("Liste des années : ");

            foreach (annee a in d.annee) {
                //uC_Affichage1.addElement(new UC_ElementAnnee(this, a));
            }
        }
        
        public void afficheAnneeSelectionnee(annee a) {
            lTitre.Text = "Période : ";
            uC_Affichage1.setGroupBoxTiTre("Liste des périodes : ");


        }

        public void affichePeriodeSelectionnee(periode p) {
            lTitre.Text = "UE : ";
            uC_Affichage1.setGroupBoxTiTre("Liste des UE : ");


        }

        public void afficheUESelectionnee(ue u) {
            lTitre.Text = "Cours : ";
            uC_Affichage1.setGroupBoxTiTre("Liste des cours : ");


        }

        private void bFilAriane2_Click(object sender, EventArgs e) {

        }
    }
}
