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
using dotnet.Properties;
using dotnet.Fenetres.Modification;

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
            tBCours.Text = Requetes.obtientTypeduCours(_cours).nom;
            tBHoraires.Text = _cours.volume_horraire.ToString();

            if (_cours.personnel == null)
            {
                tBPersonnel.Text = "Aucun";
                initialiseImageAjout(pBAjouterRetirer);
            }
            else
            {
                personnel p = Requetes.obtientPersonnelduCours(_cours);
                tBPersonnel.Text = p.nom + " " + p.prenom;
                initialiseImageRetrait(pBAjouterRetirer);
            }
        }

        private void initialiseImageAjout(PictureBox pB)
        {
            try
            {
                pBAjouterRetirer.Image = Resources.ajouter_personnel;
                //pBAjouterRetirer.Image = Image.FromFile(@"..\..\Images\Icones\ajouter_personnel.png");
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
                pBAjouterRetirer.Image = Resources.retirer_personnel;
                //pBAjouterRetirer.Image = Image.FromFile(@"..\..\Images\Icones\retirer_personnel.png");
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
                _cadre.ajouterPersonnel(_cours);
            }
            else
            {               
                _cadre.retirerPersonnel(_cours);
            }
        }

        private void pBModifier_Click(object sender, EventArgs e)
        {
            new FenetreModifCoursD(this, _cours).Show();
        }

        private void pBSupprimer_Click(object sender, EventArgs e)
        {
            new FenetreSupprimerCoursD(this, _cours).Show();
        }

        private void pBAjouterRetirer_MouseEnter(object sender, EventArgs e)
        {
            pBAjouterRetirer.BackColor = Color.FromArgb(20, 79, 93);
        }

        private void pBAjouterRetirer_MouseLeave(object sender, EventArgs e)
        {
            pBAjouterRetirer.BackColor = Color.FromArgb(60, 185, 213);
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

        private void panel_DoubleClick(object sender, EventArgs e)
        {
            // Afficher les cours de l'EC séléctionné
            _cadre.afficheCoursSelectionne(_cours);
        }
    }
}
