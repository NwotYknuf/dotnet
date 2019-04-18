using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dotnet.UserControler;

namespace dotnet.Fenetres.Assignation
{
    public partial class FenetreRetraitPersonnel : Form
    {
        private UC_OngletDiplomes _cadre;
        private cours _cours;

        public FenetreRetraitPersonnel()
        {
            InitializeComponent();
        }

        public FenetreRetraitPersonnel(UC_OngletDiplomes cadre, cours c)
        {
            InitializeComponent();
            _cadre = cadre;
            _cours = c;

            personnel p = Database.instance.personnel.Where(x => x.id == _cours.personnel.id).FirstOrDefault<personnel>();

            lNomPersonnel.Text = p.nom + " " + p.prenom;
            lNomCours.Text = _cours.nom;

            lNomPersonnel.ForeColor = Color.FromArgb(83, 181, 0);
            lNomCours.ForeColor = Color.FromArgb(83, 181, 0);

        }

        private void bAnnuler_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void bValider_Click(object sender, EventArgs e)
        {
            RetirePersonnel();
            this.Dispose();
        }

        public void RetirePersonnel()
        {
            _cours.personnel = null;

            Requetes.enregistreLaBDD();

            _cadre.Actualiser();
        }
    }
}
