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
    public partial class UC_AjoutD : UC_Ajout
    {
        protected UC_OngletDiplomes _cadre;

        public UC_AjoutD()
        {
            InitializeComponent();
        }
        
        public UC_AjoutD(UC_OngletDiplomes cadre) : this()
        {
            this._cadre = cadre;
        }
    }
}
