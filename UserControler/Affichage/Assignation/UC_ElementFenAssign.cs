using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dotnet.Fenetres;

namespace dotnet.UserControler.Affichage.Assignation
{
    public partial class UC_ElementFenAssign : UC_Element
    {
        protected FenetreAssignationCours _cadre;

        public UC_ElementFenAssign()
        {
            InitializeComponent();
        }

        public UC_ElementFenAssign(FenetreAssignationCours cadre)
        {
            InitializeComponent();
            this._cadre = cadre;
        }
    }
}
