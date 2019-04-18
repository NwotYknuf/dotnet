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
    public partial class FenetreModifAnnee : FenetreModif
    {
        private UC_ElementAnnee _cadre;
        private annee _annee;

        public FenetreModifAnnee()
        {
            InitializeComponent();
        }

        public FenetreModifAnnee(UC_ElementAnnee cadre, annee a)
        {
            InitializeComponent();
            _cadre = cadre;
            _annee = a;

            tBNom.Text = _annee.nom;
            rtBDesc.Text = _annee.description;
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

                //Modification de l' année
                _annee.nom = this.tBNom.Text;
                _annee.description = this.rtBDesc.Text;
                
                //Renvoie
                _cadre.modificationConfirmee();

                MessageBox.Show("L'année " + _annee.nom + " a été modifiée avec succès.");

                this.Dispose();
            }
            else
            {
                lErreur.Visible = true;
            }
        }
    }
}
