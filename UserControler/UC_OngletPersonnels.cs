using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dotnet.UserControler.Ajout;
using dotnet.UserControler.Affichage.Personnel;

namespace dotnet
{
    public partial class UC_OngletPersonnels : UserControl
    {
        public UC_OngletPersonnels()
        {
            InitializeComponent();
        }
        
        private void UC_OngletPersonnels_Load(object sender, EventArgs e)
        {
            uC_FilArianePersonnel1.setOngletPersonnel(this);
            uC_Information1.Visible = false;
            afficheRacine();
        }

        public void afficheRacine()
        {
            //TODO : Remplacer cette section par un truc plus propre
            uC_Information1.Visible = false;
            
            lTitre1.Text = "Personnels"; lTitre2.Text = "enseignants à l'"; lTitre3.Text = "Université UFR MIM de Metz : ";

            uC_Affichage1.setGroupBoxTiTre("Liste des personnels : ");

            Point loc = uC_Ajout1.Location;
            uC_Ajout1.Dispose();
            uC_Ajout1 = new UC_AjoutPersonnel(this);
            uC_Ajout1.Location = loc;
            Controls.Add(uC_Ajout1);

            uC_Affichage1.clearElements();

            var personnels = Database.instance.personnel;
            foreach (personnel p in personnels)
            {
                uC_Affichage1.addElement(new UC_ElementPersonnel(this, p));
            }
            uC_Affichage1.updateAffichage();
        }

        public void affichePersonnelSelectionne(personnel p)
        {
            lTitre1.Text = "Personnel"; lTitre2.Text = p.nom + " " + p.prenom + " : "; lTitre3.Text = "";

            uC_Affichage1.setGroupBoxTiTre("Liste des cours : ");

            uC_FilArianePersonnel1.filArianePersonnelApparait(p);
            
            uC_Ajout1.Visible = false;
            uC_Information1.Visible = true;
            uC_Information1.remplie(p);

            uC_Affichage1.clearElements();

            PictureBox pBAjouterCours = new PictureBox();
            pBAjouterCours.Image = Image.FromFile(@"..\..\Images\Icones\ajouter_cours.png");
            pBAjouterCours.Name = "pBAjouterCours";
            pBAjouterCours.Size = new System.Drawing.Size(37, 34);
            pBAjouterCours.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;

            uC_Affichage1.addElement(new UC_ElementAjoutCours(this, p));

            foreach (cours c in p.cours)
            {
                uC_Affichage1.addElement(new UC_ElementCoursPersonnel(this, c));
            }
            uC_Affichage1.updateAffichage();
        }

        public void ajouterCours(personnel p)
        {
            // Ajouter un cours au personnel p
        }

        public void retirerCours(personnel p)
        {
            // Retirer un cours au personnel p
        }
    }
}
