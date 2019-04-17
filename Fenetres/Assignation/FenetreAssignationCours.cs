using dotnet.UserControler.Affichage.Assignation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dotnet.Fenetres.Assignation
{
    public partial class FenetreAssignationCours : FenetreAssignation
    {
        private UC_OngletPersonnels _cadre;
        private personnel _personnel;

        public FenetreAssignationCours()
        {
            InitializeComponent();
        }

        public FenetreAssignationCours(UC_OngletPersonnels cadre, personnel personnel)
        {
            InitializeComponent();
            _cadre = cadre;
            _personnel = personnel;

            initialisation();
        }

        private void initialisation()
        {
            lTitre.Text = "Sélectionnez le cours que vous souhaitez assigner en appuyant sur le bouton correspondant : ";

            uC_AffichageFenAssign1.setGroupBoxTiTre("Liste des cours non assignés à un personnel : ");

            var cours = Database.instance.cours;
            foreach (cours c in cours)
            {
                if (c.id_personnel == null)
                    uC_AffichageFenAssign1.addElement(new UC_ElementFenCours(this, c));
            }
            uC_AffichageFenAssign1.updateAffichage();
        }

        private void FenetreAssignationCours_Load(object sender, EventArgs e)
        {
            
        }

        public void AssigneCours(cours c)
        {
            _personnel.cours.Add(c);

            Requetes.enregistreLaBDD();

            _cadre.affichePersonnelSelectionne(_personnel);
        }
    }
}
