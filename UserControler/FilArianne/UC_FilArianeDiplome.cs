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

        //private static string path = System.IO.Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.FullName + @"\Images\FilAriane\FilDebutBlanc.png";

         //Je sais c'est pas propre et ça marchera pas chez vous mais j'arrive pas le traduire en relatif..
        private Image imgDebBlanche = Image.FromFile(@"..\..\Images\FilAriane\FilDebutBlanc.png");
        private Image imgDebBleue = Image.FromFile(@"..\..\Images\FilAriane\FilDebutBleu.png");
        private Image imgBlanche = Image.FromFile(@"..\..\Images\FilAriane\FilBlanc.png");
        private Image imgBleue = Image.FromFile(@"..\..\Images\FilAriane\FilBleu.png");

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
            l.Image = imgBleue;
            l.ForeColor = System.Drawing.Color.White;
        }

        private void couleurdeFondBlanche(Label l)
        {
            l.Image = imgBlanche;
            l.ForeColor = System.Drawing.Color.DeepSkyBlue;
        }

        private void lRacine_Click(object sender, EventArgs e)
        {
            //lRacine.Image = imgDebBleue;
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
            couleurdeFondBleue(lDiplome);

            lAnnee.Visible = false;
            lPeriode.Visible = false;
            lUE.Visible = false;
            lEC.Visible = false;

            _cadre.afficheDiplomeSelectionne(_d);
        }

        private void lAnnee_Click(object sender, EventArgs e)
        {
            couleurdeFondBleue(lAnnee);

            lPeriode.Visible = false;
            lUE.Visible = false;
            lEC.Visible = false;

            _cadre.afficheAnneeSelectionnee(_a);
        }

        private void lPeriode_Click(object sender, EventArgs e)
        {
            couleurdeFondBleue(lPeriode);
            
            lUE.Visible = false;
            lEC.Visible = false;

            _cadre.affichePeriodeSelectionnee(_p);
        }

        private void lUE_Click(object sender, EventArgs e)
        {
            couleurdeFondBleue(lUE);
            
            lEC.Visible = false;

            _cadre.afficheUESelectionnee(_u);
        }

        private void lEC_Click(object sender, EventArgs e)
        {
            couleurdeFondBleue(lEC);

            _cadre.afficheECSelectionnee(_e);
        }

        public void filArianeDiplomeApparait(diplome d)
        {
            _d = d;
            couleurdeFondBleue(lDiplome);

            lDiplome.Visible = true;
            lDiplome.Text = _d.nom.ToString();
        }

        public void filArianeAnneeApparait(annee a)
        {
            _a = a;
            couleurdeFondBlanche(lDiplome);
            couleurdeFondBleue(lAnnee);

            lAnnee.Visible = true;
            lAnnee.Text = _a.nom.ToString();
        }

        public void filArianePeriodeApparait(periode p)
        {
            _p = p;
            couleurdeFondBlanche(lAnnee);
            couleurdeFondBleue(lPeriode);

            lPeriode.Visible = true;
            lPeriode.Text = _p.nom.ToString();
        }

        public void filArianeUEApparait(ue u)
        {
            _u = u;
            couleurdeFondBlanche(lPeriode);
            couleurdeFondBleue(lUE);

            lUE.Visible = true;
            lUE.Text = _u.nom.ToString();
        }

        public void filArianeECApparait(ec c)
        {
            _e = c;
            couleurdeFondBlanche(lUE);
            couleurdeFondBleue(lEC);

            lEC.Visible = true;
            lEC.Text = _e.nom.ToString();
        }

    }
}
