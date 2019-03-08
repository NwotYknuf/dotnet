using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dotnet {
    public partial class UC_Ajout : UserControl {
        protected UC_OngletDiplomes _cadre;

        public UC_Ajout() {
            InitializeComponent();
        }

        public UC_Ajout(UC_OngletDiplomes cadre) : this() {
            this._cadre = cadre;
        }

        public UC_Ajout(string titre) {
            groupBox.Text = titre;
        }
    }
}
