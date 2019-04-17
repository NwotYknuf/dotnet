using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dotnet.Fenetres.Assignation;

namespace dotnet.UserControler.Affichage.Assignation
{
    public partial class UC_ElementFenPersonnel : UC_ElementFenAssign
    {
        private personnel _personnel;
        protected FenetreAssignationPersonnel _cadre;

        public UC_ElementFenPersonnel()
        {
            InitializeComponent();
        }

        public UC_ElementFenPersonnel(FenetreAssignationPersonnel cadre, personnel p)
        {
            InitializeComponent();
            _personnel = p;
            _cadre = cadre;

            gBAffElement.Text = "";
            tBNom.Text = _personnel.nom;
            tBPrenom.Text = _personnel.prenom;
            tBTelephone.Text = _personnel.telephone;
            tBAdresseEmail.Text = _personnel.email;
            tBAdressePost.Text = _personnel.adresse;
            //tBNbHeuresAttrib.Text = Requetes.nbrHeureAttribuees(_personnel).ToString();
            //tBNbHeuresNonAttrib.Text = Requetes.nbrHeureManquantes(_personnel).ToString();

            toolTip1.SetToolTip(this.pBAjouterPersonnel, "Ajouter un cours au personnel");
        }

        private void pBAjouterPersonnel_Click(object sender, EventArgs e)
        {
            _cadre.AssignePersonnel(_personnel);
            _cadre.Dispose();
        }
    }
}
