using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace dotnet.UserControler.Ajout
{
    public partial class UC_AjoutUE : UC_AjoutD
    {
        private periode _p;

        public UC_AjoutUE()
        {
            InitializeComponent();
        }

        public UC_AjoutUE(UC_OngletDiplomes cadre, periode p) : base(cadre)
        {
            InitializeComponent();
            _p = p;
        }

        private void bCreer_Click(object sender, EventArgs e)
        {
            if ( (Utilitaires.conditionsRespectees(tBNom.Text, true, true, true, true, 2, 100)) && 
                (Utilitaires.conditionsRespectees(rtBDesc.Text, true, true, true, true, 2, 100)) )
            {
                lErreur.Visible = false;

                // Ajouter une UE
                ue ue = new ue();
                ue.nom = this.tBNom.Text;
                ue.description = this.rtBDesc.Text;
                ue.periode = _p;

                _p.ue.Add(ue);

                // Ajouter à la BDD
                Requetes.ajouterUE(ue);

                Requetes.enregistreLaBDD();

                MessageBox.Show("L'UE " + ue.nom + " a été ajoutée avec succès.");

                _cadre.Actualiser();
            }
            else
            {
                lErreur.Visible = true;
            }
        }
    }
}
