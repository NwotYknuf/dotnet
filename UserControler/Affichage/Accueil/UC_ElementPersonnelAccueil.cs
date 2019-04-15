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

namespace dotnet.UserControler.Affichage.Accueil
{
    public partial class UC_ElementPersonnelAccueil : UC_ElementA
    {
        private personnel _personnel;

        public UC_ElementPersonnelAccueil()
        {
            InitializeComponent();
        }

        public UC_ElementPersonnelAccueil(UC_OngletAccueil cadre, personnel p) : base(cadre)
        {
            _personnel = p;
            InitializeComponent();
            gBAffElement.Text = "";
            tBNom.Text = _personnel.nom;
            tBPrenom.Text = _personnel.prenom;
            tBNbHeuresAttrib.Text = "";
            tBNbHeuresNonAttrib.Text = "";
            
        }

        private void pBModifier_Click(object sender, EventArgs e)
        {

        }

        private void pBSupprimer_Click(object sender, EventArgs e)
        {
            new FenetreSupprimer("Personnel", _personnel).Show(); ;
        }

        private void panel_DoubleClick(object sender, EventArgs e)
        {
            
        }
    }
}
