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
    public partial class UC_AjoutEC : UC_AjoutD
    {
        private ue _u;

        public UC_AjoutEC()
        {
            InitializeComponent();
        }

        public UC_AjoutEC(UC_OngletDiplomes cadre, ue u) : base(cadre)
        {
            InitializeComponent();
            _u = u;
        }

        private void bCreer_Click(object sender, EventArgs e)
        {
            if ((Utilitaires.conditionsRespectees(tBNom.Text, true, true, true, true, 2, 100)) &&
                (Utilitaires.conditionsRespectees(rtBDesc.Text, true, true, true, true, 2, 100)))
            {
                lErreur.Visible = false;

                // Ajouter une EC
                ec ec = new ec();
                ec.nom = this.tBNom.Text;
                ec.description = this.rtBDesc.Text;

                if (this.cB_ECActive.Checked)
                    ec.actif = true;
                else
                    ec.actif = false;

                ec.ue = _u;

                _u.ec.Add(ec);

                // Ajouter à la BDD
                Requetes.ajouterEC(ec);

                Requetes.enregistreLaBDD();

                MessageBox.Show("L'EC " + ec.nom + " a été ajoutée avec succès.");

                _cadre.Actualiser();
            }
            else
            {
                lErreur.Visible = true;
            }
        }
    }
}
