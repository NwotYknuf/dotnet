using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dotnet.Fenetres;

namespace dotnet.UserControler.Affichage
{
    public partial class UC_ElementUE : UC_ElementD
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
            tBDesc.Text = _ue.description;
        }

        private void panel_DoubleClick(object sender, EventArgs e)
        {
            // Afficher les EC de l'UE selectionnée
            _cadre.afficheUESelectionnee(_ue);
        }

        private void pBModifier_Click(object sender, EventArgs e)
        {

        }

        private void pBSupprimer_Click(object sender, EventArgs e)
        {
            new FenetreSupprimer("UE", _ue).Show(); ;
        }
    }
}
