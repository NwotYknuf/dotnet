using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dotnet
{
    public partial class UC_OngletRecherche : UserControl
    {
        public UC_OngletRecherche()
        {
            InitializeComponent();
        }

        private void UC_OngletRecherche_Load(object sender, EventArgs e)
        {
            uC_Affichage1.setGroupBoxTiTre("Résultats de la recherche : ");
        }

        private void bLancerRech_Click(object sender, EventArgs e)
        {
            
        }
    }
}
