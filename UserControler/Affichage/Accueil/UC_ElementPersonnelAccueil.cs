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

namespace dotnet.UserControler.Affichage.Accueil
{
    public partial class UC_ElementPersonnelAccueil : UC_ElementA
    {
        private personnel _personnel;

        public UC_ElementPersonnelAccueil()
        {
            InitializeComponent();
        }

        public UC_ElementPersonnelAccueil(UC_OngletAccueil cadre, personnel p) : base(cadre)
        {
            _personnel = p;
            InitializeComponent();
            gBAffElement.Text = "";
            tBNom.Text = _personnel.nom;
            tBPrenom.Text = _personnel.prenom;
            tBNbHeuresAttrib.Text = Requetes.nbrHeureAttribuees(_personnel).ToString();
            tBNbHeuresNonAttrib.Text = Requetes.nbrHeureManquantes(_personnel).ToString();
            
        }

        private void panel_DoubleClick(object sender, EventArgs e)
        {
            _cadre.afficheOngletPersonnel(_personnel);
        }
    }
}
