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
    public partial class UC_ElementPeriodeRech : UC_ElementR
    {
        private periode _periode;

        public UC_ElementPeriodeRech()
        {
            InitializeComponent();
        }

        public UC_ElementPeriodeRech(UC_OngletRecherche cadre, periode p) : base(cadre)
        {
            InitializeComponent();
            _periode = p;
        }

        private void panel_DoubleClick(object sender, EventArgs e)
        {

        }
    }
}
