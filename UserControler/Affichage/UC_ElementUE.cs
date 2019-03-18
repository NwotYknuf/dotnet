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
    public partial class UC_ElementUE : UC_Element
    {
        private ue _ue;

        public UC_ElementUE()
        {
            InitializeComponent();
        }

        public UC_ElementUE(UC_OngletDiplomes cadre, ue u) : base(cadre)
        {
            _ue = u;
            InitializeComponent();
            gBAffElement.Text = _ue.nom;
            //tBDesc.Text = _ue.description;
        }

        private void panel_DoubleClick(object sender, EventArgs e)
        {
            // Afficher les EC de l'UE selectionnée
            _cadre.afficheUESelectionnee(_ue);
        }
    }
}
