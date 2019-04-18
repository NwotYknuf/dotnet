using dotnet.UserControler.Affichage;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dotnet.Fenetres.Modification
{
    public partial class FenetreModifEC : FenetreModif
    {
        private UC_ElementEC _cadre;
        private ec _ec;

        public FenetreModifEC()
        {
            InitializeComponent();
        }

        public FenetreModifEC(UC_ElementEC cadre, ec e)
        {
            InitializeComponent();
            _cadre = cadre;
            _ec = e;

            tBNom.Text = _ec.nom;
            rtBDesc.Text = _ec.description;
        }

        private void bAnnuler_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void bValider_Click(object sender, EventArgs e)
        {
            if ((Utilitaires.conditionsRespectees(tBNom.Text, true, true, true, true, 2, 100)) &&
                (Utilitaires.conditionsRespectees(rtBDesc.Text, true, true, true, true, 2, 100)))
            {
                lErreur.Visible = false;

                //Modification d'un diplome
                _ec.nom = this.tBNom.Text;
                _ec.description = this.rtBDesc.Text;

                if (this.cB_ECActive.Checked)
                    _ec.actif = true;
                else
                    _ec.actif = false;

                // Renvoie
                _cadre.modificationConfirmee();

                MessageBox.Show("L'EC " + _ec.nom + " a été modifiée avec succès.");

                this.Dispose();
            }
            else
            {
                lErreur.Visible = true;
            }
        }
    }
}
