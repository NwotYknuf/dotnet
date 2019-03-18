using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dotnet.UserControler.Affichage
{
    public partial class UC_ElementAnnee : UC_Element
    {
        private annee _annee;

        public UC_ElementAnnee()
        {
            InitializeComponent();
        }

        public UC_ElementAnnee(UC_OngletDiplomes cadre, annee a) : base(cadre) {
            _annee = a;
            InitializeComponent();
            gBAffElement.Text = _annee.nom;
            //tBDesc.Text = _annee.description;
        }

        private void panel_DoubleClick(object sender, EventArgs e)
        {
            _cadre.afficheAnneeSelectionnee(_annee);
        }
    }
}
