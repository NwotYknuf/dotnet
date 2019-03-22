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
    public partial class UC_FilArianePersonnel : UserControl
    {
        protected UC_OngletPersonnels _cadre;

        private Image imgDebBlanche = Image.FromFile(@"..\..\Images\FilAriane\FilDebutBlanc.png");
        private Image imgDebBleue = Image.FromFile(@"..\..\Images\FilAriane\FilDebutBleu.png");
        private Image imgBlanche = Image.FromFile(@"..\..\Images\FilAriane\FilBlanc.png");
        private Image imgBleue = Image.FromFile(@"..\..\Images\FilAriane\FilBleu.png");

        private personnel _p;

        public UC_FilArianePersonnel()
        {
            InitializeComponent();
        }

        private void UC_FilArianePersonnel_Load(object sender, EventArgs e)
        {

        }

        public void setOngletPersonnel(UC_OngletPersonnels cadre)
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
            l.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(185)))), ((int)(((byte)(213)))));
        }

        private void lRacine_Click(object sender, EventArgs e)
        {
            //lRacine.Image = imgDebBleue;
            //lRacine.ForeColor = System.Drawing.Color.White;
            lPersonnel.Visible = false;

            _cadre.afficheRacine();
        }

        private void lPersonnel_Click(object sender, EventArgs e)
        {

        }

        public void filArianePersonnelApparait(personnel p)
        {
            _p = p;
            couleurdeFondBleue(lPersonnel);

            lPersonnel.Visible = true;
            lPersonnel.Text = _p.nom.ToString();
        }
    }
}
