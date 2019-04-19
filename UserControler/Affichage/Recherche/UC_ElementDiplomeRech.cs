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
    public partial class UC_ElementDiplomeRech : UC_ElementR
    {
        private diplome _diplome;

        public UC_ElementDiplomeRech()
        {
            InitializeComponent();
        }

        public UC_ElementDiplomeRech(UC_OngletRecherche cadre, diplome d) : base(cadre)
        {
            InitializeComponent();
            _diplome = d;
        }

        private void panel_DoubleClick(object sender, EventArgs e)
        {

        }
    }
}
