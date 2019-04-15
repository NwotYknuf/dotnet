using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace dotnet {
    public partial class UC_Ajout : UserControl
    {
       
        public UC_Ajout() {
            InitializeComponent();
        }
        
        public UC_Ajout(string titre) {
            gBTitreAjout.Text = titre;
        }
    }
}
