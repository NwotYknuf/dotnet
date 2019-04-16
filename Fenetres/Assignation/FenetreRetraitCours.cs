using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dotnet.Fenetres.Assignation
{
    public partial class FenetreRetraitCours : Form
    {
        private UC_OngletPersonnels _cadre;
        private personnel _personnel;
        private cours _cours;

        public FenetreRetraitCours()
        {
            InitializeComponent();
        }

        public FenetreRetraitCours(UC_OngletPersonnels cadre, personnel p, cours c)
        {
            InitializeComponent();
            _cadre = cadre;
            _personnel = p;
            _cours = c;

            lNomCours.Text = _cours.nom;
            lNomPersonnel.Text = _personnel.nom + " " + _personnel.prenom;
            
            lNomCours.ForeColor = Color.FromArgb(83, 181, 0);
            lNomPersonnel.ForeColor = Color.FromArgb(83, 181, 0);

        }

        private void bAnnuler_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void bValider_Click(object sender, EventArgs e)
        {
            RetireCours();
            this.Dispose();
        }

        public void RetireCours()
        {
            _personnel.cours.Remove(_cours);

            Database.instance.SaveChanges();

            _cadre.affichePersonnelSelectionne(_personnel);
        }
    }
}
