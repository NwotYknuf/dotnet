using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dotnet.UserControler.Affichage.Recherche
{
    public partial class UC_ElementAnneeRech : UC_ElementR
    {
        private annee _annee;

        public UC_ElementAnneeRech()
        {
            InitializeComponent();
        }

        public UC_ElementAnneeRech(UC_OngletRecherche cadre, annee annee) : base(cadre)
        {
            InitializeComponent();
            _annee = annee;

            gBAffElement.Text = _annee.nom;
            tBDesc.Text = _annee.description;
        }

        private void panel_DoubleClick(object sender, EventArgs e)
        {
            _cadre.afficheOngletAnnee(_annee);
        }

        private void panel_MouseEnter(object sender, EventArgs e)
        {
            panel.BackColor = Utilitaires.couleurBleuTurquoiseFonce();            
        }

        private void panel_MouseLeave(object sender, EventArgs e)
        {
            panel.BackColor = Utilitaires.couleurBleuTurquoise();
        }

        private void panel_MouseHover(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.Hand;
        }
    }
}
