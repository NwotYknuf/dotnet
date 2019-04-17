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
    public partial class UC_ElementD : UC_ElementModifiable
    {
        protected UC_OngletDiplomes _cadre;

        public UC_ElementD()
        {
            InitializeComponent();
        }

        public UC_ElementD(UC_OngletDiplomes cadre)
        {
            InitializeComponent();
            this._cadre = cadre;
        }

        private void panel_MouseHover(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.Hand;
        }
    }
}
