using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dotnet.UserControler.Affichage.Accueil
{
    public partial class UC_ElementA : UC_Element
    {
        protected UC_OngletAccueil _cadre;

        public UC_ElementA()
        {
            InitializeComponent();
        }

        public UC_ElementA(UC_OngletAccueil cadre)
        {
            InitializeComponent();
            this._cadre = cadre;
        }

        private void UC_ElementA_Load(object sender, EventArgs e)
        {

        }
    }
}
