using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dotnet.UserControler
{
    public partial class UC_Onglet : UserControl
    {
        protected FenetrePrincipale _fenetrePrincipale;

        public UC_Onglet()
        {
            InitializeComponent();
        }

        public void attribuerFenetrePrincipale(FenetrePrincipale f)
        {
            _fenetrePrincipale = f;
        }

        public void afficheOngletDiplome(diplome d)
        {
            _fenetrePrincipale.afficherDiplomeSelectionne(d);
        }

        public void afficheOngletAnnee(annee a)
        {
            _fenetrePrincipale.afficherAnneeSelectionnee(a);
        }

        public void afficheOngletPeriode(periode p)
        {
            _fenetrePrincipale.afficherPeriodeSelectionnee(p);
        }

        public void afficheOngletUE(ue u)
        {
            _fenetrePrincipale.afficherUESelectionnee(u);
        }

        public void afficheOngletEC(ec e)
        {
            _fenetrePrincipale.afficherECSelectionnee(e);
        }

        public void afficheOngletCours(cours c)
        {
            _fenetrePrincipale.afficherCoursSelectionne(c);
        }

        public void afficheOngletPersonnel(personnel p)
        {
            _fenetrePrincipale.afficherPersonnelSelectionne(p);
        }


        public virtual void Actualiser()
        {

        }
    }
}
