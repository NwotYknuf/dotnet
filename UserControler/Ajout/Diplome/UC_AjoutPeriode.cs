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
    public partial class UC_AjoutPeriode : UC_AjoutD
    {
        private annee _a;

        public UC_AjoutPeriode()
        {
            InitializeComponent();
        }

        public UC_AjoutPeriode(UC_OngletDiplomes cadre, annee a) : base(cadre)
        {
            InitializeComponent();
            _a = a;
        }

        private void bCreer_Click(object sender, EventArgs e)
        {
            if ((Utilitaires.conditionsRespectees(tBNom.Text, true, true, true, true, 2, 100)) &&
                (Utilitaires.conditionsRespectees(rtBDesc.Text, true, true, true, true, 2, 100)))
            {
                lErreur.Visible = false;

                // Ajouter une période
                periode periode = new periode();
                periode.nom = this.tBNom.Text;
                periode.description = this.rtBDesc.Text;
                periode.annee = _a;

                _a.periode.Add(periode);

                // Ajouter à la BDD
                Requetes.ajouterPeriode(periode);

                Requetes.enregistreLaBDD();

                MessageBox.Show("La période " + periode.nom + " a été ajoutée avec succès.");

                _cadre.Actualiser();
            }
            else
            {
                lErreur.Visible = true;
            }
        }
    }
}
