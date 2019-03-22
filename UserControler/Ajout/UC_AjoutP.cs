using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dotnet.UserControler.Ajout
{
    public partial class UC_AjoutP : UC_Ajout
    {
        protected UC_OngletPersonnels _cadre;

        public UC_AjoutP()
        {
            InitializeComponent();
        }

        public UC_AjoutP(UC_OngletPersonnels cadre) : this()
        {
            this._cadre = cadre;
        }
    }
}
