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
    public partial class FenetreModifPeriode : FenetreModif
    {
        private UC_ElementPeriode _cadre;
        private periode _periode;

        public FenetreModifPeriode()
        {
            InitializeComponent();
        }

        public FenetreModifPeriode(UC_ElementPeriode cadre, periode p)
        {
            InitializeComponent();
            _cadre = cadre;
            _periode = p;

            tBNom.Text = _periode.nom;
            rtBDesc.Text = _periode.description;
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
                _periode.nom = this.tBNom.Text;
                _periode.description = this.rtBDesc.Text;

                // Renvoie
                _cadre.modificationConfirmee();

                MessageBox.Show("La période " + _periode.nom + " a été modifiée avec succès.");

                this.Dispose();
            }
            else
            {
                lErreur.Visible = true;
            }
        }
    }
}
