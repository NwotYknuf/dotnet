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
    public partial class UC_ElementDiplome : UC_Element {
        private diplome _diplome;

        public UC_ElementDiplome() {
            InitializeComponent();
        }

        public UC_ElementDiplome(UC_OngletDiplomes cadre, diplome d) : base(cadre) {
            _diplome = d;
            InitializeComponent();
            gBAffElement.Text = _diplome.nom;
            tBDesc.Text = _diplome.description;
        }

        private void panel1_Click(object sender, EventArgs e) {
            
        }

        private void lDescDiplome_DoubleClick(object sender, EventArgs e)
        {
            _cadre.afficheDiplomeSelectionne(_diplome);

            //Changer l'UC ajout en accord

            //update le fils d'Arianne
        }
    }
}
