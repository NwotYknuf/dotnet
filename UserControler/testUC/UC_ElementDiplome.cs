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
    public partial class UC_ElementDiplome : UC_Element
    {
        public UC_ElementDiplome()
        {
            InitializeComponent();
        }

        public UC_ElementDiplome(UC_OngletDiplomes cadre, diplome d) : base(cadre)
        {
            InitializeComponent();
            groupBox1.Text = d.nom;
            label1.Text = d.description;
        }
    }
}
