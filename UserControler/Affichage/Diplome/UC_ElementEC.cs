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
using dotnet.Fenetres.Modification;

namespace dotnet.UserControler.Affichage
{
    public partial class UC_ElementEC : UC_ElementD
    {
        private ec _ec;

        public UC_ElementEC()
        {
            InitializeComponent();
        }

        public UC_ElementEC(UC_OngletDiplomes cadre, ec e) : base(cadre)
        {
            _ec = e;
            InitializeComponent();
            gBAffElement.Text = _ec.nom;
            tBDesc.Text = _ec.description;

            if (_ec.actif == true)
            {
                cB_ECActive.Checked = true;
                cB_ECActive.Text = "Activée";
            }
            else
            {
                cB_ECActive.Checked = false;
                cB_ECActive.Text = "Désactivée";
            }

        }

        private void panel_DoubleClick(object sender, EventArgs e)
        {
            // Affiche les cours de l'EC selectionnée
            _cadre.afficheECSelectionnee(_ec);
        }

        private void pBModifier_Click(object sender, EventArgs e)
        {
            new FenetreModifEC(this, _ec).Show();
        }

        private void pBSupprimer_Click(object sender, EventArgs e)
        {
            new FenetreSupprimerEC(this, _ec).Show();
        }

        public void suppressionConfirmee(ec e)
        {
            Requetes.retirerEC(e);
            Requetes.enregistreLaBDD();
            _cadre.Actualiser();
        }

        public void modificationConfirmee()
        {
            Requetes.enregistreLaBDD();
            _cadre.Actualiser();
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
