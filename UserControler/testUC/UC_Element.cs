using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dotnet.UserControler.testUC
{
    public partial class UC_Element : UserControl
    {

        private UC_OngletDiplomes _cadre;

        public UC_Element()
        {
            InitializeComponent();
        }

        public UC_Element(UC_OngletDiplomes cadre)
        {
            InitializeComponent();
            this._cadre = cadre;
        }
    }
}
