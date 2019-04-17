using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dotnet.UserControler.Ajout {
    public partial class UC_AjoutDiplome : UC_AjoutD
    {
        
        public UC_AjoutDiplome() {
            InitializeComponent();
        }

        public UC_AjoutDiplome(UC_OngletDiplomes cadre) : base(cadre) {
            InitializeComponent();
        }

        private void bCreer_Click(object sender, EventArgs e)
        {
            if ((Utilitaires.conditionsRespectees(tBNom.Text, true, true, true, true, 2, 100)) &&
                (Utilitaires.conditionsRespectees(rtBDesc.Text, true, true, true, true, 2, 100)))
            {
                lErreur.Visible = false;

                // Ajouter un diplome
                diplome diplome = new diplome();
                diplome.nom = this.tBNom.Text;
                diplome.description = this.rtBDesc.Text;

                // Ajouter à la BDD
                Requetes.ajouterDiplome(diplome);

                Requetes.enregistreLaBDD();

                MessageBox.Show("Le diplôme " + diplome.nom + " a été ajoutée avec succès.");

                _cadre.Actualiser();
            }
            else
            {
                lErreur.Visible = true;
            }
        }
    }
}
