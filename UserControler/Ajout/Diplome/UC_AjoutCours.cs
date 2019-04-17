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
        private ec _e;

        public UC_AjoutCours()
        {
            InitializeComponent();
        }

        public UC_AjoutCours(UC_OngletDiplomes cadre, ec e) : base(cadre)
        {
            InitializeComponent();
            _e = e;
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

            cBType.SelectedIndex = 0;
        }

        private void bCreer_Click(object sender, EventArgs e)
        {
            if ((Utilitaires.conditionsRespectees(tBNom.Text,true, true, true, false, 2, 100)) &&
                (Utilitaires.conditionsRespectees(tBHoraires.Text, false, true, true, true, 1, 3)) && 
                (Utilitaires.conditionsRespectees(cBType.Text, cBType)) )
            {
                lErreur.Visible = false;

                // Ajouter un cours
                cours cours = new cours();
                cours.nom = this.tBNom.Text;
                cours.volume_horraire = Convert.ToInt32(this.tBHoraires.Text);

                type_cours tc = Database.instance.type_cours.Where(s => s.nom == (String)this.cBType.SelectedValue).FirstOrDefault<type_cours>();
                cours.type_cours = tc;
                tc.cours.Add(cours);

                cours.ec = _e;
                _e.cours.Add(cours);

                // Ajouter l'enregistrement à la BDD
                Requetes.ajouterCours(cours);

                Requetes.enregistreLaBDD();

                MessageBox.Show("Le cours " + cours.nom + " a été ajouté avec succès.");
            }
            else
            {
                lErreur.Visible = true;
            }
        }
    }
}
