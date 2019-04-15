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
    public partial class UC_ElementEC : UC_ElementD
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
            tBDesc.Text = _ec.description;
            //
            if (_ec.actif == true) 
                cB_ECActive.Checked = true;
            else
                cB_ECActive.Checked = false;

        }

        private void panel_DoubleClick(object sender, EventArgs e)
        {
            // Affiche les cours de l'EC selectionnée
            _cadre.afficheECSelectionnee(_ec);
        }

        private void pBModifier_Click(object sender, EventArgs e)
        {

        }

        private void pBSupprimer_Click(object sender, EventArgs e)
        {
            new FenetreSupprimer("EC", _ec).Show(); ;
        }
    }
}
