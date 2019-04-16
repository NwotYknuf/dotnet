using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dotnet.UserControler.Affichage
{
    public partial class UC_ElementModifiable : UC_Element
    {
        public UC_ElementModifiable()
        {
            InitializeComponent();
        }

        private void UC_Element_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(this.pBModifier, "Modifier ce cours");
            toolTip1.SetToolTip(this.pBSupprimer, "Supprimer ce cours");
        }
    }
}
