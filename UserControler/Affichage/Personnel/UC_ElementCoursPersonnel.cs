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
using dotnet.Fenetres.Modification;

namespace dotnet.UserControler.Affichage.Personnel
{
    public partial class UC_ElementCoursPersonnel : UC_ElementP
    {
        private cours _cours;
        private personnel _personnel;

        public UC_ElementCoursPersonnel()
        {
            InitializeComponent();
        }

        public UC_ElementCoursPersonnel(UC_OngletPersonnels cadre, cours c) : base(cadre)
        {
            _cours = c;
            InitializeComponent();
            gBAffElement.Text = _cours.nom;
            tBCours.Text = Requetes.obtientTypeduCours(_cours).nom;
            tBHoraires.Text = _cours.volume_horraire.ToString();
            tBEC.Text = Requetes.obtientECduCours(_cours).nom;

            // Nous sommes sûr d'avoir un personnel assigné ici
            _personnel = Requetes.obtientPersonnelduCours(c);
        }

        private void pBModifier_Click(object sender, EventArgs e)
        {
            new FenetreModifCoursP(this, _cours).Show();
        }

        private void pBSupprimer_Click(object sender, EventArgs e)
        {
            new FenetreSupprimerCoursP(this, _cours).Show();
        }

        private void pBRetirer_Click(object sender, EventArgs e)
        {
            // Retirer ce cours à ce personnel
            _cadre.retirerCours(_personnel, _cours);
        }

        private void UC_ElementCoursPersonnel_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(this.pBRetirer, "Retirer ce cours du personnel " + _personnel.nom + " " + _personnel.prenom);
        }

        private void pBRetirer_MouseEnter(object sender, EventArgs e)
        {
            pBRetirer.BackColor = Color.FromArgb(20, 79, 93);
        }

        private void pBRetirer_MouseLeave(object sender, EventArgs e)
        {
            pBRetirer.BackColor = Color.FromArgb(60, 185, 213);
        }

        public void suppressionConfirmee(cours c)
        {
            Requetes.retirerCours(c);
            Requetes.enregistreLaBDD();
            _cadre.Actualiser();
        }

        public void modificationConfirmee()
        {
            Requetes.enregistreLaBDD();
            _cadre.Actualiser();
        }
    }
}
