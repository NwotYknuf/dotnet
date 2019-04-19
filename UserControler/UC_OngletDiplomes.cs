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
using System.Data.Entity.Migrations;
using dotnet.Fenetres.Assignation;

namespace dotnet.UserControler
{
    public partial class UC_OngletDiplomes : UC_Onglet
    {
        
        private ec _ecCourant;

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
            foreach (diplome d in diplomes.ToList())
            {
                uC_Affichage1.addElement(new UC_ElementDiplome(this, d));
            }
            uC_Affichage1.updateAffichage();
        }

        public void afficheDiplomeSelectionne(diplome d)
        {
            gBCours.Visible = false;
            uC_Affichage1.Visible = true;
            cB_ECActive.Visible = false;

            lTitre1.Text = "Années"; lTitre2.Text = "proposées en"; lTitre3.Text = d.nom + " : ";
            
            uC_Affichage1.setGroupBoxTiTre("Liste des années : ");
            
            uC_FilArianeDiplome1.filArianeDiplomeApparait(d);

            // changer l'UC ajout
            Point loc = uC_Ajout1.Location;
            uC_Ajout1.Dispose();
            uC_Ajout1 = new UC_AjoutAnnee(this, d);
            uC_Ajout1.Location = loc;
            Controls.Add(uC_Ajout1);

            uC_Affichage1.clearElements();

            foreach (annee a in d.annee.ToList()) {
                uC_Affichage1.addElement(new UC_ElementAnnee(this, a));
            }
            uC_Affichage1.updateAffichage();

        }
        
        public void afficheAnneeSelectionnee(annee a)
        {
            gBCours.Visible = false;
            uC_Affichage1.Visible = true;
            cB_ECActive.Visible = false;

            lTitre1.Text = "Périodes"; lTitre2.Text = "proposées en"; lTitre3.Text = a.nom + " : ";

            uC_Affichage1.setGroupBoxTiTre("Liste des périodes : ");
            
            uC_FilArianeDiplome1.filArianeAnneeApparait(a);

            Point loc = uC_Ajout1.Location;
            uC_Ajout1.Dispose();
            uC_Ajout1 = new UC_AjoutPeriode(this, a);
            uC_Ajout1.Location = loc;
            Controls.Add(uC_Ajout1);

            uC_Affichage1.clearElements();
            foreach (periode p in a.periode.ToList())
            {
                uC_Affichage1.addElement(new UC_ElementPeriode(this, p));
            }
            uC_Affichage1.updateAffichage();
        }

        public void affichePeriodeSelectionnee(periode p)
        {
            gBCours.Visible = false;
            uC_Affichage1.Visible = true;
            cB_ECActive.Visible = false;

            lTitre1.Text = "Unités d'enseignement (UE)"; lTitre2.Text = "proposées au"; lTitre3.Text = p.nom + " : ";

            uC_Affichage1.setGroupBoxTiTre("Liste des UE : ");
            
            uC_FilArianeDiplome1.filArianePeriodeApparait(p);

            Point loc = uC_Ajout1.Location;
            uC_Ajout1.Dispose();
            uC_Ajout1 = new UC_AjoutUE(this, p);
            uC_Ajout1.Location = loc;
            Controls.Add(uC_Ajout1);

            uC_Affichage1.clearElements();
            foreach (ue u in p.ue.ToList())
            {
                uC_Affichage1.addElement(new UC_ElementUE(this, u));
            }
            uC_Affichage1.updateAffichage();
        }

        public void afficheUESelectionnee(ue u) {
            gBCours.Visible = false;
            uC_Affichage1.Visible = true;
            cB_ECActive.Visible = false;

            lTitre1.Text = "Éléments constitutifs (EC)"; lTitre2.Text = "contenues dans l'UE"; lTitre3.Text = u.nom + " : ";

            uC_Affichage1.setGroupBoxTiTre("Liste des EC : ");
            
            uC_FilArianeDiplome1.filArianeUEApparait(u);

            Point loc = uC_Ajout1.Location;
            uC_Ajout1.Dispose();
            uC_Ajout1 = new UC_AjoutEC(this, u);
            uC_Ajout1.Location = loc;
            Controls.Add(uC_Ajout1);

            uC_Affichage1.clearElements();
            foreach (ec e in u.ec.ToList())
            {
                uC_Affichage1.addElement(new UC_ElementEC(this, e));
            }
            uC_Affichage1.updateAffichage();
        }

        public void afficheECSelectionnee(ec e)
        {
            gBCours.Visible = false;
            uC_Affichage1.Visible = true;
            cB_ECActive.Visible = true;

            _ecCourant = e;

            lTitre1.Text = "Cours"; lTitre2.Text = "proposés dans l'EC"; lTitre3.Text = e.nom + " : ";

            uC_Affichage1.setGroupBoxTiTre("Liste des cours : ");
            
            if (_ecCourant.actif == true)
            {
                cB_ECActive.Checked = true;
                cB_ECActive.Text = "EC Activée";
                cB_ECActive.ForeColor = Color.FromArgb(83, 181, 0);
            }
            else
            {
                cB_ECActive.Checked = false;
                cB_ECActive.Text = "EC Désactivée";
                cB_ECActive.ForeColor = Color.FromArgb(230, 55, 0);
            }

            uC_FilArianeDiplome1.filArianeECApparait(e);

            Point loc = uC_Ajout1.Location;
            uC_Ajout1.Dispose();
            uC_Ajout1 = new UC_AjoutCours(this, e);
            uC_Ajout1.Location = loc;
            Controls.Add(uC_Ajout1);

            uC_Affichage1.clearElements();
            foreach (cours c in e.cours.ToList())
            {
                uC_Affichage1.addElement(new UC_ElementCoursDiplome(this, c));
            }
            uC_Affichage1.updateAffichage();
        }

        public void afficheCoursSelectionne(cours c)
        {
            cB_ECActive.Visible = false;
            uC_Affichage1.Visible = false;
            uC_Ajout1.Visible = false;
            gBCours.Visible = true;

            lTitre1.Text = "Cours "; lTitre2.Text = c.nom + " : "; lTitre3.Text = "";
            
            uC_FilArianeDiplome1.filArianeCoursApparait(c);
            
            UC_ElementCoursDiplome uc = new UC_ElementCoursDiplome(this, c);
            uc.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            uc.Location = new System.Drawing.Point(6, 22);
            gBCours.Controls.Add(uc);
        }

        private void cB_ECActive_CheckedChanged(object sender, EventArgs e)
        {
            if(cB_ECActive.Checked)
            {
                // L'UE est active
                _ecCourant.actif = true;
                cB_ECActive.Text = "EC Activée";
                cB_ECActive.ForeColor = Color.FromArgb(83, 181, 0);
            }
            else
            {
                // l'EC n'est plus active
                _ecCourant.actif = false;
                cB_ECActive.Text = "EC Désactivée";
                cB_ECActive.ForeColor = Color.FromArgb(230, 55, 0);
            }

            // Change l'état de l'EC dans la bdd si elle est active ou non
            Requetes.enregistreLaBDD();
        }

        public void ajouterPersonnel(cours c)
        {
            new FenetreAssignationPersonnel(this, c).Show();
        } 

        public void retirerPersonnel(cours c)
        {
            new FenetreRetraitPersonnel(this, c).Show();
        }

        public override void Actualiser()
        {
            uC_FilArianeDiplome1.Actualiser();
        }

        public void afficheDiplomeSelectionneDansAutreOnglet(diplome diplome)
        {
            uC_FilArianeDiplome1.filArianeDiplomeApparait(diplome);

            uC_FilArianeDiplome1.Actualiser();
        }

        public void afficheAnneeSelectionneeDansAutreOnglet(annee annee)
        {
            diplome diplome = Requetes.obtientDiplomedelAnnee(annee);

            uC_FilArianeDiplome1.filArianeDiplomeApparait(diplome);
            uC_FilArianeDiplome1.filArianeAnneeApparait(annee);

            uC_FilArianeDiplome1.Actualiser();
        }

        public void affichePeriodeSelectionneeDansAutreOnglet(periode periode)
        {
            annee annee = Requetes.obtientAnneedelaPeriode(periode);
            diplome diplome = Requetes.obtientDiplomedelAnnee(annee);

            uC_FilArianeDiplome1.filArianeDiplomeApparait(diplome);
            uC_FilArianeDiplome1.filArianeAnneeApparait(annee);
            uC_FilArianeDiplome1.filArianePeriodeApparait(periode);

            uC_FilArianeDiplome1.Actualiser();
        }

        public void afficheUESelectionneeDansAutreOnglet(ue ue)
        {
            periode periode = Requetes.obtientPeriodedelUE(ue);
            annee annee = Requetes.obtientAnneedelaPeriode(periode);
            diplome diplome = Requetes.obtientDiplomedelAnnee(annee);

            uC_FilArianeDiplome1.filArianeDiplomeApparait(diplome);
            uC_FilArianeDiplome1.filArianeAnneeApparait(annee);
            uC_FilArianeDiplome1.filArianePeriodeApparait(periode);
            uC_FilArianeDiplome1.filArianeUEApparait(ue);

            uC_FilArianeDiplome1.Actualiser();
        }

        public void afficheECSelectionneeDansAutreOnglet(ec ec)
        {
            ue ue = Requetes.obtientUEdelEC(ec);
            periode periode = Requetes.obtientPeriodedelUE(ue);
            annee annee = Requetes.obtientAnneedelaPeriode(periode);
            diplome diplome = Requetes.obtientDiplomedelAnnee(annee);

            uC_FilArianeDiplome1.filArianeDiplomeApparait(diplome);
            uC_FilArianeDiplome1.filArianeAnneeApparait(annee);
            uC_FilArianeDiplome1.filArianePeriodeApparait(periode);
            uC_FilArianeDiplome1.filArianeUEApparait(ue);
            uC_FilArianeDiplome1.filArianeECApparait(ec);

            uC_FilArianeDiplome1.Actualiser();
        }

        public void afficheCoursSelectionneDansAutreOnglet(cours cours)
        {
            ec ec = Requetes.obtientECduCours(cours);
            ue ue = Requetes.obtientUEdelEC(ec);
            periode periode = Requetes.obtientPeriodedelUE(ue);
            annee annee = Requetes.obtientAnneedelaPeriode(periode);
            diplome diplome = Requetes.obtientDiplomedelAnnee(annee);

            uC_FilArianeDiplome1.filArianeDiplomeApparait(diplome);
            uC_FilArianeDiplome1.filArianeAnneeApparait(annee);
            uC_FilArianeDiplome1.filArianePeriodeApparait(periode);
            uC_FilArianeDiplome1.filArianeUEApparait(ue);
            uC_FilArianeDiplome1.filArianeECApparait(ec);
            uC_FilArianeDiplome1.filArianeCoursApparait(cours);

            uC_FilArianeDiplome1.Actualiser();
        }
    }
}
