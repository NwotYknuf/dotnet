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
    public partial class UC_ElementECRech : UC_ElementR
    {
        private ec _ec;

        public UC_ElementECRech()
        {
            InitializeComponent();
        }

        public UC_ElementECRech(UC_OngletRecherche cadre, ec e) : base(cadre)
        {
            InitializeComponent();
            _ec = e;
            
            gBAffElement.Text = _ec.nom;
            tBDesc.Text = _ec.description;
            
            if (_ec.actif == true)
            {
                cB_ECActive.Checked = true;
                cB_ECActive.Text = "Activée";
            }
            else
            {
                cB_ECActive.Checked = false;
                cB_ECActive.Text = "Désactivée";
            }
        }

        private void panel_DoubleClick(object sender, EventArgs e)
        {
            _cadre.afficheOngletEC(_ec);
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
