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

namespace dotnet.UserControler.Affichage.Personnel
{
    public partial class UC_ElementCoursPersonnel : UC_ElementP
    {
        private cours _cours;

        public UC_ElementCoursPersonnel()
        {
            InitializeComponent();
        }

        public UC_ElementCoursPersonnel(UC_OngletPersonnels cadre, cours c) : base(cadre)
        {
            _cours = c;
            InitializeComponent();
            gBAffElement.Text = _cours.nom;
            tBCours.Text = _cours.type_cours.ToString();
            tBHoraires.Text = _cours.volume_horraire.ToString();
            tBEC.Text = _cours.id_ec.ToString();

        }

        private void pBModifier_Click(object sender, EventArgs e)
        {

        }

        private void pBSupprimer_Click(object sender, EventArgs e)
        {
            new FenetreSupprimer("Cours", _cours).Show(); ;
        }

        private void pBRetirer_Click(object sender, EventArgs e)
        {
            // Retirer ce cours à ce personnel

            //_cadre.retirerCours(  );
        }

        private void UC_ElementCoursPersonnel_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(this.pBRetirer, "Retirer ce cours du personnel");
        }
    }
}
