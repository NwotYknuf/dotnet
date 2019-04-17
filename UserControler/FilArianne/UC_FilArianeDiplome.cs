using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dotnet.UserControler.FilArianne
{
    public partial class UC_FilArianeDiplome : UserControl
    {
        protected UC_OngletDiplomes _cadre;

        private int nbOngletsOuverts = 1;
        private diplome _d;
        private annee _a;
        private periode _p;
        private ue _u;
        private ec _e;
        
        public UC_FilArianeDiplome()
        {
            InitializeComponent();
        }
        
        private void UC_FilArianeDiplome_Load(object sender, EventArgs e)
        {

        }

        public void setOngletDiplome(UC_OngletDiplomes cadre)
        {
            this._cadre = cadre;
        }

        private void couleurdeFondBleue(Label l)
        {
            try
            {
                l.Image = Image.FromFile(@"..\..\Images\FilAriane\FilBleu.png");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            l.ForeColor = System.Drawing.Color.White;
        }

        private void couleurdeFondBlanche(Label l)
        {
            try
            {
                l.Image = Image.FromFile(@"..\..\Images\FilAriane\FilBlanc.png"); ;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            l.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(185)))), ((int)(((byte)(213)))));
        }

        private void lRacine_Click(object sender, EventArgs e)
        {
            nbOngletsOuverts = 1;
            //lRacine.Image = Image.FromFile(@"..\..\Images\FilAriane\FilDebutBleu.png");;
            //lRacine.ForeColor = System.Drawing.Color.White;
            lDiplome.Visible = false;
            lAnnee.Visible = false;
            lPeriode.Visible = false;
            lUE.Visible = false;
            lEC.Visible = false;

            _cadre.afficheRacine();
        }
        
        private void lDiplome_Click(object sender, EventArgs e)
        {
            nbOngletsOuverts = 2;
            //lRacine.Image = Image.FromFile(@"..\..\Images\FilAriane\FilDebutBlanc.png");
            //lRacine.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(185)))), ((int)(((byte)(213)))));
            couleurdeFondBleue(lDiplome);

            lAnnee.Visible = false;
            lPeriode.Visible = false;
            lUE.Visible = false;
            lEC.Visible = false;

            _cadre.afficheDiplomeSelectionne(_d);
        }

        private void lAnnee_Click(object sender, EventArgs e)
        {
            nbOngletsOuverts = 3;
            couleurdeFondBleue(lAnnee);

            lPeriode.Visible = false;
            lUE.Visible = false;
            lEC.Visible = false;

            _cadre.afficheAnneeSelectionnee(_a);
        }

        private void lPeriode_Click(object sender, EventArgs e)
        {
            nbOngletsOuverts = 4;
            couleurdeFondBleue(lPeriode);
            
            lUE.Visible = false;
            lEC.Visible = false;

            _cadre.affichePeriodeSelectionnee(_p);
        }

        private void lUE_Click(object sender, EventArgs e)
        {
            nbOngletsOuverts = 5;
            couleurdeFondBleue(lUE);
            
            lEC.Visible = false;

            _cadre.afficheUESelectionnee(_u);
        }

        private void lEC_Click(object sender, EventArgs e)
        {
            nbOngletsOuverts = 6;
            couleurdeFondBleue(lEC);

            _cadre.afficheECSelectionnee(_e);
        }

        public void filArianeDiplomeApparait(diplome d)
        {
            nbOngletsOuverts = 2;
            _d = d;
            couleurdeFondBleue(lDiplome);

            lDiplome.Visible = true;
            lDiplome.Text = _d.nom.ToString();
        }

        public void filArianeAnneeApparait(annee a)
        {
            nbOngletsOuverts = 3;
            _a = a;
            couleurdeFondBlanche(lDiplome);
            couleurdeFondBleue(lAnnee);

            lAnnee.Visible = true;
            lAnnee.Text = _a.nom.ToString();
        }

        public void filArianePeriodeApparait(periode p)
        {
            nbOngletsOuverts = 4;
            _p = p;
            couleurdeFondBlanche(lAnnee);
            couleurdeFondBleue(lPeriode);

            lPeriode.Visible = true;
            lPeriode.Text = _p.nom.ToString();
        }

        public void filArianeUEApparait(ue u)
        {
            nbOngletsOuverts = 5;
            _u = u;
            couleurdeFondBlanche(lPeriode);
            couleurdeFondBleue(lUE);

            lUE.Visible = true;
            lUE.Text = _u.nom.ToString();
        }

        public void filArianeECApparait(ec c)
        {
            nbOngletsOuverts = 6;
            _e = c;
            couleurdeFondBlanche(lUE);
            couleurdeFondBleue(lEC);

            lEC.Visible = true;
            lEC.Text = _e.nom.ToString();
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
                default:  { break; }
            }
        }

    }
}
