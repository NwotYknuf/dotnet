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
    public partial class UC_ElementCoursRech : UC_ElementR
    {
        private cours _cours;

        public UC_ElementCoursRech()
        {
            InitializeComponent();
        }
        
        public UC_ElementCoursRech(UC_OngletRecherche cadre, cours c) : base(cadre)
        {
            InitializeComponent();
            _cours = c;
        }

        private void panel_DoubleClick(object sender, EventArgs e)
        {

        }
    }
}
