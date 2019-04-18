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
    public partial class UC_FilArianePersonnel : UC_FilAriane
    {
        protected UC_OngletPersonnels _cadre;
        private int nbOngletsOuverts = 1;
        private personnel _p;

        public UC_FilArianePersonnel()
        {
            InitializeComponent();
        }

        private void UC_FilArianePersonnel_Load(object sender, EventArgs e)
        {
            couleurdeFondRacineBleue(lRacine);
        }

        public void setOngletPersonnel(UC_OngletPersonnels cadre)
        {
            this._cadre = cadre;
        }
               

        private void lRacine_Click(object sender, EventArgs e)
        {
            nbOngletsOuverts = 1;
            couleurdeFondRacineBleue(lRacine);

            lPersonnel.Visible = false;

            _cadre.afficheRacine();
        }

        private void lPersonnel_Click(object sender, EventArgs e)
        {
            //Actualisation
            nbOngletsOuverts = 2;
            couleurdeFondBleue(lPersonnel);

            _cadre.affichePersonnelSelectionne(_p);
        }

        public void filArianePersonnelApparait(personnel p)
        {
            nbOngletsOuverts = 2;
            _p = p;

            couleurdeFondRacineBlanche(lRacine);
            couleurdeFondBleue(lPersonnel);

            lPersonnel.Visible = true;
            lPersonnel.Text = _p.nom.ToString();
        }

        public void Actualiser()
        {
            switch (nbOngletsOuverts)
            {
                case 1: { _cadre.afficheRacine(); break; }
                case 2: { _cadre.affichePersonnelSelectionne(_p); break; }
                default: { break; }
            }
        }
    }
}
