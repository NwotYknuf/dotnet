using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dotnet.Fenetres.Assignation;

namespace dotnet.UserControler.Affichage.Assignation
{
    public partial class UC_ElementFenCours : UC_ElementFenAssign
    {
        private cours _cours;
        protected FenetreAssignationCours _cadre;

        public UC_ElementFenCours()
        {
            InitializeComponent();
        }

        public UC_ElementFenCours(FenetreAssignationCours cadre, cours c)
        {
            InitializeComponent();
            _cadre = cadre;
            _cours = c;

            gBAffElement.Text = _cours.nom;
            tBCours.Text = Requetes.obtientTypeduCours(_cours).nom;
            tBHoraires.Text = _cours.volume_horraire.ToString();
            tBEC.Text = Requetes.obtientECduCours(_cours).nom;

            toolTip1.SetToolTip(this.pBAjouterCours, "Ajouter un cours au personnel");
        }

        private void pBAjouterCours_Click(object sender, EventArgs e)
        {
            _cadre.AssigneCours(_cours);
            _cadre.Dispose();
        }

        private void pBAjouterCours_MouseEnter(object sender, EventArgs e)
        {
            pBAjouterCours.BackColor = Color.FromArgb(20, 79, 93);
        }

        private void pBAjouterCours_MouseLeave(object sender, EventArgs e)
        {
            pBAjouterCours.BackColor = Color.FromArgb(60, 185, 213);
        }
    }
}
