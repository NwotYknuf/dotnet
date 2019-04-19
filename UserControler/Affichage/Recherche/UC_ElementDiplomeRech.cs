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
    public partial class UC_ElementDiplomeRech : UC_ElementR
    {
        private diplome _diplome;

        public UC_ElementDiplomeRech()
        {
            InitializeComponent();
        }

        public UC_ElementDiplomeRech(UC_OngletRecherche cadre, diplome d) : base(cadre)
        {
            InitializeComponent();
            _diplome = d;

            gBAffElement.Text = _diplome.nom;
            tBDesc.Text = _diplome.description;
        }

        private void panel_DoubleClick(object sender, EventArgs e)
        {
            _cadre.afficheOngletDiplome(_diplome);
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
