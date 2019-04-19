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
using dotnet.Fenetres.Suppression;

namespace dotnet.UserControler.Affichage.Accueil
{
    public partial class UC_ElementCoursAccueil : UC_ElementA
    {
        private cours _cours;

        public UC_ElementCoursAccueil()
        {
            InitializeComponent();
        }

        public UC_ElementCoursAccueil(UC_OngletAccueil cadre, cours c) : base(cadre)
        {
            InitializeComponent();
            _cours = c;
            gBAffElement.Text = _cours.nom;
            tBCours.Text = Requetes.obtientTypeduCours(_cours).nom;
            tBHoraires.Text = _cours.volume_horraire.ToString();
            tBEC.Text = Requetes.obtientECduCours(_cours).nom;

        }

        private void panel_DoubleClick(object sender, EventArgs e)
        {
            _cadre.afficheOngletCours(_cours);
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
