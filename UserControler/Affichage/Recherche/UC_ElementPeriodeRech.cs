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
    public partial class UC_ElementPeriodeRech : UC_ElementR
    {
        private periode _periode;

        public UC_ElementPeriodeRech()
        {
            InitializeComponent();
        }

        public UC_ElementPeriodeRech(UC_OngletRecherche cadre, periode p) : base(cadre)
        {
            InitializeComponent();
            _periode = p;

            gBAffElement.Text = _periode.nom;
            tBDesc.Text = _periode.description;
        }

        private void panel_DoubleClick(object sender, EventArgs e)
        {
            _cadre.afficheOngletPeriode(_periode);
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
