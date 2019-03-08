using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dotnet{
    public partial class FilArianne : UserControl {
        public FilArianne() {

            InitializeComponent();

            for(int i = 0; i < 5; i++) {
                LinkLabel l = new LinkLabel();
                l.Text = "toast";
                flowLayoutPanel.Controls.Add(l);
            }
        }
    }
}
