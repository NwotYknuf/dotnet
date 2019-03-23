using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dotnet.UserControler.Affichage
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

        }

        private void pBAjouterRetirer_Click(object sender, EventArgs e)
        {
            // Retirer ce cours à ce personnel
        }
    }
}
