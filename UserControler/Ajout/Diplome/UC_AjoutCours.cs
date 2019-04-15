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
    public partial class UC_AjoutCours : UC_AjoutD
    {
        public UC_AjoutCours()
        {
            InitializeComponent();
        }

        public UC_AjoutCours(UC_OngletDiplomes cadre) : base(cadre)
        {
            InitializeComponent();
            //this.gBTitre.Text = "Ajouter un cours : ";
        }

        private void UC_AjoutCours_Load(object sender, EventArgs e)
        {
            initialiseCBType();
        }

        private void initialiseCBType()
        {
            var types = Database.instance.type_cours;
            foreach(type_cours t in types)
                cBType.Items.Add(t.nom);
        }

        private void bCreer_Click(object sender, EventArgs e)
        {
            if ((conditionsRespectees(tBNom.Text,true, true, true, false, 2, 100)) &&
                (conditionsRespectees(tBHoraires.Text, false, true, true, true, 1, 3)) && 
                (conditionsRespectees(cBType.Text, cBType)) )
            {
                lErreur.Visible = false;
                // Ajouter un cours
                cours cours = new cours();
                cours.nom = this.tBNom.Text;
                type_cours tc = new type_cours();
                cours.type_cours = this.cBType.SelectedValue;
                // Ajouter l'enregistrement à la BDD
            }
            else
            {
                lErreur.Visible = true;
            }
        }
    }
}
