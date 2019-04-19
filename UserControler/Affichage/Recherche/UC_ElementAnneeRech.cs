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
    public partial class UC_ElementAnneeRech : UC_ElementR
    {
        private annee _annee;

        public UC_ElementAnneeRech()
        {
            InitializeComponent();
        }

        public UC_ElementAnneeRech(UC_OngletRecherche cadre, annee annee) : base(cadre)
        {
            InitializeComponent();
            _annee = annee;
        }

        private void panel_DoubleClick(object sender, EventArgs e)
        {

        }
    }
}
