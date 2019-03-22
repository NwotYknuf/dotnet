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
    public partial class UC_ElementCoursDiplome : UC_ElementD
    {
        private cours _cours;

        public UC_ElementCoursDiplome()
        {
            InitializeComponent();
        }

        public UC_ElementCoursDiplome(UC_OngletDiplomes cadre, cours c) : base(cadre)
        {
            _cours = c;
            InitializeComponent();
            gBAffElement.Text = _cours.nom;
            tBCours.Text = _cours.type_cours.ToString();
            tBHoraires.Text = _cours.volume_horraire.ToString();

            if (_cours.personnel.ToString() == "")
            {
                tBPersonnel.Text = "Aucun";
                bAjouterRetirer.Text = "Ajouter un personnel";
            }
            else
            {
                tBPersonnel.Text = _cours.personnel.ToString();
                bAjouterRetirer.Text = "Retirer le personnel";
            }
        }

        private void bAjouterRetirer_Click(object sender, EventArgs e)
        {
            if (_cours.personnel.ToString() == "")
            {
                // Ajouter un personnel
            }
            else
            {
                // Retirer un personnel
            }
        }
    }
}
