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
    public partial class FenetreModifDiplome : FenetreModif
    {
        private UC_ElementDiplome _cadre;
        private diplome _diplome;

        public FenetreModifDiplome()
        {
            InitializeComponent();
        }

        public FenetreModifDiplome(UC_ElementDiplome cadre, diplome d)
        {
            InitializeComponent();
            _cadre = cadre;
            _diplome = d;

            tBNom.Text = _diplome.nom;
            rtBDesc.Text = _diplome.description;
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
                _diplome.nom = this.tBNom.Text;
                _diplome.description = this.rtBDesc.Text;

                // Renvoie
                _cadre.modificationConfirmee();

                MessageBox.Show("Le diplôme " + _diplome.nom + " a été modifié avec succès.");

                this.Dispose();
            }
            else
            {
                lErreur.Visible = true;
            }
        }
    }
}
