using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            tBCours.Text = _cours.id_type.ToString();
            tBHoraires.Text = _cours.volume_horraire.ToString();
            tBPersonnel.Text = _cours.personnel.ToString();

            if (_cours.personnel.ToString() == "")
            {
                tBPersonnel.Text = "Aucun";
                try
                {
                    pBAjouterRetirer.Image = Image.FromFile(@"..\..\Images\Icones\ajouter_personnel.png");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            else
            {
                tBPersonnel.Text = _cours.personnel.ToString();
                try
                {
                    pBAjouterRetirer.Image = Image.FromFile(@"..\..\Images\Icones\retirer_personnel.png");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }

        private void pBAjouterRetirer_Click(object sender, EventArgs e)
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

        private void pBSupprimer_Click(object sender, EventArgs e)
        {

        }

        private void pBModifier_Click(object sender, EventArgs e)
        {

        }
    }
}
