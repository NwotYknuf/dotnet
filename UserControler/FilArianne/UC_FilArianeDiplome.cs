using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dotnet.Properties;

namespace dotnet.UserControler.FilArianne
{
    public partial class UC_FilArianeDiplome : UC_FilAriane
    {
        private UC_OngletDiplomes _cadre;

        private int nbOngletsOuverts = 1;
        private diplome _d;
        private annee _a;
        private periode _p;
        private ue _u;
        private ec _e;
        private cours _c;
        
        public UC_FilArianeDiplome()
        {
            InitializeComponent();
        }
        
        private void UC_FilArianeDiplome_Load(object sender, EventArgs e)
        {
            couleurdeFondRacineBleue(lRacine);
        }

        public void setOngletDiplome(UC_OngletDiplomes cadre)
        {
            this._cadre = cadre;
        }

        private void lRacine_Click(object sender, EventArgs e)
        {
            nbOngletsOuverts = 1;
            couleurdeFondRacineBleue(lRacine);

            lDiplome.Visible = false;
            lAnnee.Visible = false;
            lPeriode.Visible = false;
            lUE.Visible = false;
            lEC.Visible = false;
            lCours.Visible = false;

            _cadre.afficheRacine();
        }
        
        private void lDiplome_Click(object sender, EventArgs e)
        {
            nbOngletsOuverts = 2;
            couleurdeFondBleue(lDiplome);

            lAnnee.Visible = false;
            lPeriode.Visible = false;
            lUE.Visible = false;
            lEC.Visible = false;
            lCours.Visible = false;

            _cadre.afficheDiplomeSelectionne(_d);
        }

        private void lAnnee_Click(object sender, EventArgs e)
        {
            nbOngletsOuverts = 3;
            couleurdeFondBleue(lAnnee);

            lPeriode.Visible = false;
            lUE.Visible = false;
            lEC.Visible = false;
            lCours.Visible = false;

            _cadre.afficheAnneeSelectionnee(_a);
        }

        private void lPeriode_Click(object sender, EventArgs e)
        {
            nbOngletsOuverts = 4;
            couleurdeFondBleue(lPeriode);
            
            lUE.Visible = false;
            lEC.Visible = false;
            lCours.Visible = false;

            _cadre.affichePeriodeSelectionnee(_p);
        }

        private void lUE_Click(object sender, EventArgs e)
        {
            nbOngletsOuverts = 5;
            couleurdeFondBleue(lUE);
            
            lEC.Visible = false;
            lCours.Visible = false;

            _cadre.afficheUESelectionnee(_u);
        }

        private void lEC_Click(object sender, EventArgs e)
        {
            nbOngletsOuverts = 6;
            couleurdeFondBleue(lEC);
            
            lCours.Visible = false;

            _cadre.afficheECSelectionnee(_e);
        }

        private void lCours_Click(object sender, EventArgs e)
        {
            nbOngletsOuverts = 7;
            couleurdeFondBleue(lCours);

            _cadre.afficheCoursSelectionne(_c);
        }

        public void filArianeDiplomeApparait(diplome d)
        {
            nbOngletsOuverts = 2;
            _d = d;
            

            couleurdeFondRacineBlanche(lRacine);
            couleurdeFondBleue(lDiplome);

            lDiplome.Visible = true;
            lDiplome.Text = "Diplôme :" + Environment.NewLine + _d.nom;
        }

        public void filArianeAnneeApparait(annee a)
        {
            nbOngletsOuverts = 3;
            _a = a;
            couleurdeFondBlanche(lDiplome);
            couleurdeFondBleue(lAnnee);

            lAnnee.Visible = true;
            lAnnee.Text = "Année :" + Environment.NewLine + _a.nom;
        }

        public void filArianePeriodeApparait(periode p)
        {
            nbOngletsOuverts = 4;
            _p = p;
            couleurdeFondBlanche(lAnnee);
            couleurdeFondBleue(lPeriode);

            lPeriode.Visible = true;
            lPeriode.Text = "Période :" + Environment.NewLine + _p.nom;
        }

        public void filArianeUEApparait(ue u)
        {
            nbOngletsOuverts = 5;
            _u = u;
            couleurdeFondBlanche(lPeriode);
            couleurdeFondBleue(lUE);

            lUE.Visible = true;
            lUE.Text = "UE :" + Environment.NewLine + _u.nom;
        }

        public void filArianeECApparait(ec e)
        {
            nbOngletsOuverts = 6;
            _e = e;
            couleurdeFondBlanche(lUE);
            couleurdeFondBleue(lEC);

            lEC.Visible = true;
            lEC.Text = "EC :" + Environment.NewLine + _e.nom;
        }

        public void filArianeCoursApparait(cours c)
        {
            nbOngletsOuverts = 7;
            _c = c;
            couleurdeFondBlanche(lEC);
            couleurdeFondBleue(lCours);

            lCours.Visible = true;
            lCours.Text = "Cours :" + Environment.NewLine + _c.nom;
        }

        private String retournerALaLigne(String txt)
        {
            if (txt.Contains(" "))
            {
                String[] data = txt.Split(' ');
                txt = data[0] + Environment.NewLine + data[1];

                return txt;
            }
            return txt;
        }

        public void Actualiser()
        {
            switch (nbOngletsOuverts)
            {
                case 1: { _cadre.afficheRacine(); break; }
                case 2: { _cadre.afficheDiplomeSelectionne(_d); break; }
                case 3: { _cadre.afficheAnneeSelectionnee(_a);  break; }
                case 4: { _cadre.affichePeriodeSelectionnee(_p);  break; }
                case 5: { _cadre.afficheUESelectionnee(_u); break; }
                case 6: { _cadre.afficheECSelectionnee(_e); break; }
                case 7: { _cadre.afficheCoursSelectionne(_c); break; }
                default:  { break; }
            }
        }

        private void lRacine_MouseEnter(object sender, EventArgs e)
        {
            labelRacineSurvolDebute(lRacine);
        }

        private void lRacine_MouseLeave(object sender, EventArgs e)
        {
            labelRacineSurvolTermine(lRacine);
        }

        private void lDiplome_MouseEnter(object sender, EventArgs e)
        {
            labelSurvolDebute(lDiplome);
        }

        private void lDiplome_MouseLeave(object sender, EventArgs e)
        {
            labelSurvolTermine(lDiplome);
        }

        private void lAnnee_MouseEnter(object sender, EventArgs e)
        {
            labelSurvolDebute(lAnnee);
        }

        private void lAnnee_MouseLeave(object sender, EventArgs e)
        {
            labelSurvolTermine(lAnnee);
        }

        private void lPeriode_MouseEnter(object sender, EventArgs e)
        {
            labelSurvolDebute(lPeriode);
        }

        private void lPeriode_MouseLeave(object sender, EventArgs e)
        {
            labelSurvolTermine(lPeriode);
        }

        private void lUE_MouseEnter(object sender, EventArgs e)
        {
            labelSurvolDebute(lUE);
        }

        private void lUE_MouseLeave(object sender, EventArgs e)
        {
            labelSurvolTermine(lUE);
        }

        private void lEC_MouseEnter(object sender, EventArgs e)
        {
            labelSurvolDebute(lEC);
        }

        private void lEC_MouseLeave(object sender, EventArgs e)
        {
            labelSurvolTermine(lEC);
        }

        private void lCours_MouseEnter(object sender, EventArgs e)
        {
            labelSurvolDebute(lCours);
        }

        private void lCours_MouseLeave(object sender, EventArgs e)
        {
            labelSurvolTermine(lCours);
        }
    }
}
