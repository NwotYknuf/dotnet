using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dotnet.UserControler.Affichage.Recherche
{
    public partial class UC_ElementECRech : UC_ElementR
    {
        private ec _ec;

        public UC_ElementECRech()
        {
            InitializeComponent();
        }

        public UC_ElementECRech(UC_OngletRecherche cadre, ec e) : base(cadre)
        {
            InitializeComponent();
            _ec = e;
        }

        private void panel_DoubleClick(object sender, EventArgs e)
        {

        }
    }
}
