using dotnet.UserControler;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dotnet
{
    public partial class FenetrePrincipale : Form
    {
        public FenetrePrincipale()
        {
            InitializeComponent();
            initialisation();
        }

        private void initialisation()
        {
            ucAccueil1.BringToFront();
            changerCouleurDeFond(miAcceuil);

            ucAccueil1.attribuerFenetrePrincipale(this);
            ucListeDiplome1.attribuerFenetrePrincipale(this);
            ucListePersonnel1.attribuerFenetrePrincipale(this);
            ucGestion1.attribuerFenetrePrincipale(this);
            ucRecherche1.attribuerFenetrePrincipale(this);
        }

        private void ongletChange(ToolStripMenuItem menu, UC_Onglet uc)
        {
            uc.BringToFront();
            uc.Actualiser();
            changerCouleurDeFond(menu);
        }

        public void afficherDiplomeSelectionne(diplome d)
        {
            ongletChange(miDiplome, ucListeDiplome1);
            ucListeDiplome1.afficheDiplomeSelectionneDansAutreOnglet(d);
        }

        public void afficherAnneeSelectionnee(annee a)
        {
            ongletChange(miDiplome, ucListeDiplome1);
            ucListeDiplome1.afficheAnneeSelectionneeDansAutreOnglet(a);
        }

        public void afficherPeriodeSelectionnee(periode p)
        {
            ongletChange(miDiplome, ucListeDiplome1);
            ucListeDiplome1.affichePeriodeSelectionneeDansAutreOnglet(p);
        }

        public void afficherUESelectionnee(ue u)
        {
            ongletChange(miDiplome, ucListeDiplome1);
            ucListeDiplome1.afficheUESelectionneeDansAutreOnglet(u);
        }

        public void afficherECSelectionnee(ec e)
        {
            ongletChange(miDiplome, ucListeDiplome1);
            ucListeDiplome1.afficheECSelectionneeDansAutreOnglet(e);
        }

        public void afficherCoursSelectionne(cours c)
        {
            ongletChange(miDiplome, ucListeDiplome1);
            ucListeDiplome1.afficheCoursSelectionneDansAutreOnglet(c);
        }

        public void afficherPersonnelSelectionne(personnel p)
        {
            ongletChange(miPersonnel, ucListePersonnel1);
            ucListePersonnel1.affichePersonnelSelectionneDansAutreOnglet(p);
        }

        private void miAcceuil_Click(object sender, EventArgs e)
        {
            ongletChange(miAcceuil, ucAccueil1);
        }

        private void miDiplome_Click(object sender, EventArgs e)
        {
            ongletChange(miDiplome, ucListeDiplome1);
        }

        private void miPersonnel_Click(object sender, EventArgs e)
        {
            ongletChange(miPersonnel, ucListePersonnel1);
        }

        private void miGestion_Click(object sender, EventArgs e)
        {
            ongletChange(miGestion, ucGestion1);
        }

        private void miRecherche_Click(object sender, EventArgs e)
        {
            ongletChange(miRecherche, ucRecherche1);
        }

        private void changerCouleurDeFond(ToolStripMenuItem ms)
        {
            foreach(ToolStripMenuItem mItem in msMenu.Items)
            {
                mItem.BackColor = Color.FromArgb(60,185,213);
            }
            ms.BackColor = Color.FromArgb(20, 79, 93);
        }
    }
}
