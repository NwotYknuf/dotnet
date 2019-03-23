using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dotnet.UserControler.FilArianne;
using dotnet.UserControler.Ajout;
using dotnet.UserControler.Affichage;

namespace dotnet {
    public partial class UC_OngletDiplomes : UserControl {

        public UC_OngletDiplomes() {
            InitializeComponent();
        }

        private void UC_OngletDiplomes_Load(object sender, EventArgs e)
        {
            uC_FilArianeDiplome1.setOngletDiplome(this);
            //afficheRacine();
        }
        
        public void afficheRacine() {
            //TODO : Remplacer cette section par un truc plus propre
            lTitre.Text = "Diplômes : ";
            uC_Affichage1.setGroupBoxTiTre("Liste des diplômes : ");

            cBActif.Visible = false;

            Point loc = uC_Ajout1.Location;
            uC_Ajout1.Dispose();
            uC_Ajout1 = new UC_AjoutDiplome(this);
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

        public void afficheDiplomeSelectionne(diplome d) {

            // changer l'UC ajout

            lTitre.Text = "Années : ";
            uC_Affichage1.setGroupBoxTiTre("Liste des années : ");

            cBActif.Visible = false;

            uC_FilArianeDiplome1.filArianeDiplomeApparait(d);

            Point loc = uC_Ajout1.Location;
            uC_Ajout1.Dispose();
            uC_Ajout1 = new UC_AjoutAnnee(this);
            uC_Ajout1.Location = loc;
            Controls.Add(uC_Ajout1);

            uC_Affichage1.clearElements();

            foreach (annee a in d.annee) {
                uC_Affichage1.addElement(new UC_ElementAnnee(this, a));
            }
            uC_Affichage1.updateAffichage();

        }
        
        public void afficheAnneeSelectionnee(annee a) {
            lTitre.Text = "Période : ";
            uC_Affichage1.setGroupBoxTiTre("Liste des périodes : ");

            cBActif.Visible = false;

            uC_FilArianeDiplome1.filArianeAnneeApparait(a);

            Point loc = uC_Ajout1.Location;
            uC_Ajout1.Dispose();
            uC_Ajout1 = new UC_AjoutPeriode(this);
            uC_Ajout1.Location = loc;
            Controls.Add(uC_Ajout1);

            uC_Affichage1.clearElements();
            foreach (periode p in a.periode)
            {
                uC_Affichage1.addElement(new UC_ElementPeriode(this, p));
            }
            uC_Affichage1.updateAffichage();
        }

        public void affichePeriodeSelectionnee(periode p) {
            lTitre.Text = "UE : ";
            uC_Affichage1.setGroupBoxTiTre("Liste des UE : ");

            cBActif.Visible = false;

            uC_FilArianeDiplome1.filArianePeriodeApparait(p);

            Point loc = uC_Ajout1.Location;
            uC_Ajout1.Dispose();
            uC_Ajout1 = new UC_AjoutUE(this);
            uC_Ajout1.Location = loc;
            Controls.Add(uC_Ajout1);

            uC_Affichage1.clearElements();
            foreach (ue u in p.ue)
            {
                uC_Affichage1.addElement(new UC_ElementUE(this, u));
            }
            uC_Affichage1.updateAffichage();
        }

        public void afficheUESelectionnee(ue u) {
            lTitre.Text = "EC : ";
            uC_Affichage1.setGroupBoxTiTre("Liste des EC : ");

            cBActif.Visible = true;

            // Ajouter la compossante actif dans la table UE
            /*if (u.actif == "oui")
                cBActif.Checked = true;
            else
                cBActif.Checked = false;*/
            
            

            uC_FilArianeDiplome1.filArianeUEApparait(u);

            Point loc = uC_Ajout1.Location;
            uC_Ajout1.Dispose();
            uC_Ajout1 = new UC_AjoutEC(this);
            uC_Ajout1.Location = loc;
            Controls.Add(uC_Ajout1);

            uC_Affichage1.clearElements();
            foreach (ec e in u.ec)
            {
                uC_Affichage1.addElement(new UC_ElementEC(this, e));
            }
            uC_Affichage1.updateAffichage();
        }

        public void afficheECSelectionnee(ec e)
        {
            lTitre.Text = "Cours : ";
            uC_Affichage1.setGroupBoxTiTre("Liste des cours : ");

            cBActif.Visible = false;

            uC_FilArianeDiplome1.filArianeECApparait(e);

            Point loc = uC_Ajout1.Location;
            uC_Ajout1.Dispose();
            uC_Ajout1 = new UC_AjoutCours(this);
            uC_Ajout1.Location = loc;
            Controls.Add(uC_Ajout1);

            uC_Affichage1.clearElements();
            foreach (cours c in e.cours)
            {
                uC_Affichage1.addElement(new UC_ElementCoursDiplome(this, c));
            }
            uC_Affichage1.updateAffichage();
        }
    }
}
