using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dotnet.UserControler.Ajout
{
    public partial class UC_AjoutAnnee : UC_AjoutD
    {
        private diplome _d;

        public UC_AjoutAnnee()
        {
            InitializeComponent();
        }

        public UC_AjoutAnnee(UC_OngletDiplomes cadre, diplome d) : base(cadre)
        {
            InitializeComponent();
            _d = d;
        }

        private void bCreer_Click(object sender, EventArgs e)
        {
            if ((Utilitaires.conditionsRespectees(tBNom.Text, true, true, true, false, 2, 100)) &&
                (Utilitaires.conditionsRespectees(rtBDesc.Text, true, true, false, true, 2, 100)))
            {
                lErreur.Visible = false;

                // Créer une année
                annee annee = new annee();
                annee.nom = this.tBNom.Text;
                annee.description = this.rtBDesc.Text;
                annee.diplome = _d;

                _d.annee.Add(annee);

                // Ajouter à la BDD
                Requetes.ajouterAnnee(annee);

                Requetes.enregistreLaBDD();

                MessageBox.Show("L'année " + annee.nom + " a été ajoutée avec succès.");
            }
            else
            {
                lErreur.Visible = true;
            }
        }
    }
}
