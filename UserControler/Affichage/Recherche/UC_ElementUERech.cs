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
    public partial class UC_ElementUERech : UC_ElementR
    {
        private ue _ue;

        public UC_ElementUERech()
        {
            InitializeComponent();
        }

        public UC_ElementUERech(UC_OngletRecherche cadre, ue u) : base(cadre)
        {
            InitializeComponent();
            _ue = u;

            gBAffElement.Text = _ue.nom;
            tBDesc.Text = _ue.description;
        }

        private void panel_DoubleClick(object sender, EventArgs e)
        {
            _cadre.afficheOngletUE(_ue);
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
