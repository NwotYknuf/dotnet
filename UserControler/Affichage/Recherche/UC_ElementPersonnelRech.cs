using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dotnet.UserControler.Affichage.Recherche
{
    public partial class UC_ElementPersonnelRech : UC_ElementR
    {
        private personnel _personnel;

        public UC_ElementPersonnelRech()
        {
            InitializeComponent();
        }

        public UC_ElementPersonnelRech(UC_OngletRecherche cadre, personnel p) : base(cadre)
        {
            InitializeComponent();
            _personnel = p;

            gBAffElement.Text = _personnel.nom;
            tBNom.Text = _personnel.nom;
            tBPrenom.Text = _personnel.prenom;
            tBTelephone.Text = _personnel.telephone;
            tBAdresseEmail.Text = _personnel.email;
            tBAdressePost.Text = _personnel.adresse;
            tBCategorie.Text = Requetes.obtientCategorieduPersonnel(_personnel).nom;
            tBNbHeuresAttrib.Text = Requetes.nbrHeureAttribuees(_personnel).ToString();
            tBNbHeuresNonAttrib.Text = Requetes.nbrHeureManquantes(_personnel).ToString();
        }

        private void panel_DoubleClick(object sender, EventArgs e)
        {
            _cadre.afficheOngletPersonnel(_personnel);
        }

        private void panel_MouseEnter(object sender, EventArgs e)
        {
            panel.BackColor = Utilitaires.couleurBleuTurquoiseFonce();
        }

        private void panel_MouseLeave(object sender, EventArgs e)
        {
            panel.BackColor = Utilitaires.couleurBleuTurquoise();
        }

        private void panel_MouseHover(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.Hand;
        }
    }
}
