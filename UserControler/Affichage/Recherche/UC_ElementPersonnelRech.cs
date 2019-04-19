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
    public partial class UC_ElementPersonnelRech : UC_ElementR
    {
        private personnel _personnel;

        public UC_ElementPersonnelRech()
        {
            InitializeComponent();
        }

        public UC_ElementPersonnelRech(UC_OngletRecherche cadre, personnel p) : base(cadre)
        {
            InitializeComponent();
            _personnel = p;
        }

        private void panel_DoubleClick(object sender, EventArgs e)
        {

        }
    }
}
