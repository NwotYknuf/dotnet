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
    public partial class UC_ElementP : UC_ElementModifiable
    {
        protected UC_OngletPersonnels _cadre;

        public UC_ElementP()
        {
            InitializeComponent();
        }

        public UC_ElementP(UC_OngletPersonnels cadre)
        {
            InitializeComponent();
            this._cadre = cadre;
        }
    }
}
