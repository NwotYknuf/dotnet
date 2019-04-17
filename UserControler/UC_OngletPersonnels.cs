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
using dotnet.Fenetres;
using dotnet.Fenetres.Assignation;

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
            gBPersonnel.Visible = false;
            afficheRacine();
        }

        public void afficheRacine()
        {
            gBPersonnel.Visible = false;

            lTitre1.Text = "Personnels"; lTitre2.Text = "enseignants à l'"; lTitre3.Text = "Université UFR MIM de Metz : ";

            uC_Affichage1.setGroupBoxTiTre("Liste des personnels : ");

            Point loc = uC_Ajout1.Location;
            uC_Ajout1.Dispose();
            uC_Ajout1 = new UC_AjoutPersonnel(this);
            uC_Ajout1.Location = loc;
            Controls.Add(uC_Ajout1);

            uC_Affichage1.clearElements();

            var personnels = Database.instance.personnel;
            foreach (personnel p in personnels.ToList())
            {
                uC_Affichage1.addElement(new UC_ElementPersonnel(this, p));
            }
            uC_Affichage1.updateAffichage();
        }

        public void affichePersonnelSelectionne(personnel p)
        {
            lTitre1.Text = "Personnel"; lTitre2.Text = p.nom + " " + p.prenom + " : "; lTitre3.Text = "";

            uC_Affichage1.setGroupBoxTiTre("Liste des cours de " + p.nom + " " + p.prenom + " : ");

            uC_FilArianePersonnel1.filArianePersonnelApparait(p);
            
            uC_Ajout1.Visible = false;
            gBPersonnel.Visible = true;
            
            UC_ElementPersonnel uc = new UC_ElementPersonnel(this, p);
            uc.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            uc.Location = new System.Drawing.Point(6, 22);
            gBPersonnel.Controls.Add(uc);
            
            uC_Affichage1.clearElements();
            
            uC_Affichage1.addElement(new UC_ElementAjoutCours(this, p));

            foreach (cours c in p.cours.ToList())
            {
                uC_Affichage1.addElement(new UC_ElementCoursPersonnel(this, c));
            }
            uC_Affichage1.updateAffichage();
        }

        public void ajouterCours(personnel p)
        {
            new FenetreAssignationCours(this, p).Show();
        }

        public void retirerCours(personnel p, cours c)
        {
            new FenetreRetraitCours(this, p, c).Show();
        }

        public void Actualiser()
        {
            uC_FilArianePersonnel1.Actualiser();
        }
    }
}
