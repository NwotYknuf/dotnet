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
    public partial class UC_ElementUERech : UC_ElementR
    {
        private ue _ue;

        public UC_ElementUERech()
        {
            InitializeComponent();
        }

        public UC_ElementUERech(UC_OngletRecherche cadre, ue u) : base(cadre)
        {
            InitializeComponent();
            _ue = u;
        }

        private void panel_DoubleClick(object sender, EventArgs e)
        {

        }
    }
}
