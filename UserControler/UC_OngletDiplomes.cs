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
            afficheRacine();
        }
        
        public void afficheRacine() {
            //TODO : Remplacer cette section par un truc plus propre
            lTitre.Text = "Diplômes proposés à l'Université UFR MIM de Metz : ";
            lTitre1.Text = "Diplômes"; lTitre2.Text = "proposés à l'"; lTitre3.Text = "Université UFR MIM de Metz : ";

            uC_Affichage1.setGroupBoxTiTre("Liste des diplômes : ");

            cB_ECActive.Visible = false;

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

            lTitre.Text = "Années proposées en " + d.nom + " : ";
            lTitre1.Text = "Années"; lTitre2.Text = "proposées en"; lTitre3.Text = d.nom + " : ";

            uC_Affichage1.setGroupBoxTiTre("Liste des années : ");

            cB_ECActive.Visible = false;

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
            lTitre.Text = "Période proposées en " + a.nom + " : ";
            lTitre1.Text = "Périodes"; lTitre2.Text = "proposées en"; lTitre3.Text = a.nom + " : ";

            uC_Affichage1.setGroupBoxTiTre("Liste des périodes : ");

            cB_ECActive.Visible = false;

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
            lTitre.Text = "UE proposées au " + p.nom + " : ";
            lTitre1.Text = "UE"; lTitre2.Text = "proposées au"; lTitre3.Text = p.nom + " : ";

            uC_Affichage1.setGroupBoxTiTre("Liste des UE : ");

            cB_ECActive.Visible = false;

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
            lTitre.Text = "EC contenues dans l'UE " + u.nom + " : ";
            lTitre1.Text = "EC"; lTitre2.Text = "contenues dans l'UE"; lTitre3.Text = u.nom + " : ";

            uC_Affichage1.setGroupBoxTiTre("Liste des EC : ");

            cB_ECActive.Visible = false;

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
            lTitre.Text = "Cours proposés dans l'EC " + e.nom + " : ";
            lTitre1.Text = "Cours"; lTitre2.Text = "proposés dans l'EC"; lTitre3.Text = e.nom + " : ";

            uC_Affichage1.setGroupBoxTiTre("Liste des cours : ");

            cB_ECActive.Visible = true;

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

        private void cB_ECActive_CheckedChanged(object sender, EventArgs e)
        {
            // Change l'état de l'EC dans la bdd si elle est active ou non

            if(cB_ECActive.Checked)
            {
                // L'UE est active
            }
            else
            {
                // l'EC n'est plus active
            }
        }
    }
}
