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
    public partial class UC_ElementPeriode : UC_Element {

        private periode _periode;

        public UC_ElementPeriode() {
            InitializeComponent();
        }

        public UC_ElementPeriode(UC_OngletDiplomes cadre, periode p) : base(cadre) {
            _periode = p;
            InitializeComponent();
        }

        private void UC_ElementPeriode_Click(object sender, EventArgs e) {
            _cadre.affichePeriodeSelectionnee(_periode);
        }
    }
}
