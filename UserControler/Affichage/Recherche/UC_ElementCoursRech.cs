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
    public partial class UC_ElementCoursRech : UC_ElementR
    {
        private cours _cours;

        public UC_ElementCoursRech()
        {
            InitializeComponent();
        }
        
        public UC_ElementCoursRech(UC_OngletRecherche cadre, cours c) : base(cadre)
        {
            InitializeComponent();
            _cours = c;

            gBAffElement.Text = _cours.nom;
            tBHoraires.Text = _cours.volume_horraire.ToString();
            tBCours.Text = Requetes.obtientTypeduCours(_cours).nom;            
            tBEC.Text = Requetes.obtientECduCours(_cours).nom;
            if (_cours.personnel != null)
                tBPersonnel.Text = _cours.personnel.nom;
            else
                tBPersonnel.Text = "Aucun";
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
