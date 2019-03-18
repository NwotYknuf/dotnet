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
    public partial class UC_Affichage : UserControl {
        private List<UC_Element> elements;

        public UC_Affichage() {
            InitializeComponent();
            elements = new List<UC_Element>();
        }

        public void addElement(UC_Element element) {
            elements.Add(element);
        }

        public void clearElements() {
            elements.Clear();
        }

        public void updateAffichage() {
            flowLPanel.Controls.Clear();

            foreach (UC_Element e in elements) {
                flowLPanel.Controls.Add(e);
            }

        }

        public void setGroupBoxTiTre(String titre)
        {
            gBTitreAffichage.Text = titre;
        }

    }
}
