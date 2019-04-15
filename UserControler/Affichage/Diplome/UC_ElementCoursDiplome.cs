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

            if (_cours.personnel == null)
            {
                tBPersonnel.Text = "Aucun";
                initialiseImageAjout(pBAjouterRetirer);
            }
            else
            {
                tBPersonnel.Text = _cours.personnel.ToString();
                initialiseImageRetrait(pBAjouterRetirer);
            }
        }

        private void initialiseImageAjout(PictureBox pB)
        {
            try
            {
                pBAjouterRetirer.Image = Image.FromFile(@"..\..\Images\Icones\ajouter_personnel.png");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private void initialiseImageRetrait(PictureBox pB)
        {
            try
            {
                pBAjouterRetirer.Image = Image.FromFile(@"..\..\Images\Icones\retirer_personnel.png");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private void pBAjouterRetirer_Click(object sender, EventArgs e)
        {
            if (_cours.personnel == null)
            {
                // Ajouter un personnel

                _cours.personnel = new personnel(); // A continuer

                initialiseImageRetrait(pBAjouterRetirer);

                this.Update();
            }
            else
            {
                // Retirer un personnel

                _cours.personnel = null;
                initialiseImageAjout(pBAjouterRetirer);

                this.Update();
            }
        }

        private void pBModifier_Click(object sender, EventArgs e)
        {

        }

        private void pBSupprimer_Click(object sender, EventArgs e)
        {
            new FenetreSupprimer("Cours", _cours);
        }
    }
}
