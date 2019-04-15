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
    public partial class UC_ElementAnnee : UC_ElementD
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
            tBDesc.Text = _annee.description;
        }

        private void panel_DoubleClick(object sender, EventArgs e)
        {
            // Afficher les périodes de l'année séléctionnée
            _cadre.afficheAnneeSelectionnee(_annee);
        }

        private void pBModifier_Click(object sender, EventArgs e)
        {

        }

        private void pBSupprimer_Click(object sender, EventArgs e)
        {
            new FenetreSupprimer("Annee", _annee).Show(); ;
        }
    }
}
