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
    public partial class FenetreModifUE : FenetreModif
    {
        private UC_ElementUE _cadre;
        private ue _ue;

        public FenetreModifUE()
        {
            InitializeComponent();
        }

        public FenetreModifUE(UC_ElementUE cadre, ue u)
        {
            InitializeComponent();
            _cadre = cadre;
            _ue = u;

            tBNom.Text = _ue.nom;
            rtBDesc.Text = _ue.description;
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
                _ue.nom = this.tBNom.Text;
                _ue.description = this.rtBDesc.Text;

                // Renvoie
                _cadre.modificationConfirmee();

                MessageBox.Show("L'UE " + _ue.nom + " a été modifiée avec succès.");

                this.Dispose();
            }
            else
            {
                lErreur.Visible = true;
            }
        }
    }
}
