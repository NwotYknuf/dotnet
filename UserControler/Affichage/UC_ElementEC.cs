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
    public partial class UC_ElementEC : UC_Element
    {
        private ec _ec;

        public UC_ElementEC()
        {
            InitializeComponent();
        }

        public UC_ElementEC(UC_OngletDiplomes cadre, ec e) : base(cadre)
        {
            _ec = e;
            InitializeComponent();
            gBAffElement.Text = _ec.nom;
            //tBDesc.Text = _ec.description;
        }

        private void panel_DoubleClick(object sender, EventArgs e)
        {
            // Affiche les cours de l'EC selectionnée
            _cadre.afficheECSelectionnee(_ec);
        }
    }
}
