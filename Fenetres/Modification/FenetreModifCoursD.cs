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
    public partial class FenetreModifCoursD : FenetreModif
    {
        private UC_ElementCoursDiplome _cadre;
        private cours _cours;

        public FenetreModifCoursD()
        {
            InitializeComponent();
        }

        public FenetreModifCoursD(UC_ElementCoursDiplome cadre, cours c)
        {
            InitializeComponent();
            _cadre = cadre;
            _cours = c;

            tBNom.Text = _cours.nom;
            tBHoraires.Text = _cours.volume_horraire.ToString();

            initialiseCBType();
        }

        private void initialiseCBType()
        {
            var types = Database.instance.type_cours;
            foreach (type_cours t in types)
                cBType.Items.Add(t.nom);

            cBType.SelectedIndex = cBType.Items.IndexOf(_cours.type_cours.nom);
        }

        private void bAnnuler_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void bValider_Click(object sender, EventArgs e)
        {
            if ((Utilitaires.conditionsRespectees(tBNom.Text, true, true, true, true, 2, 100)) &&
                (Utilitaires.conditionsRespectees(tBHoraires.Text, false, true, false, false, 1, 3)) &&
                (Utilitaires.conditionsRespectees(cBType.Text, cBType)) )
            {
                lErreur.Visible = false;

                //Modification du cours
                _cours.nom = tBNom.Text;
                _cours.volume_horraire = Convert.ToInt32(tBHoraires.Text);

                type_cours tcActuel = Database.instance.type_cours.Where(s => s.nom == _cours.type_cours.nom).FirstOrDefault<type_cours>();
                tcActuel.cours.Remove(_cours);

                type_cours tcNouveau = Database.instance.type_cours.Where(s => s.nom == cBType.Text).FirstOrDefault<type_cours>();
                _cours.type_cours = tcNouveau;
                tcNouveau.cours.Add(_cours);

                //Renvoie
                _cadre.modificationConfirmee();

                MessageBox.Show("Le cours " + _cours.nom + " a été modifié avec succès.");

                this.Dispose();
            }
            else
            {
                lErreur.Visible = true;
            }
        }
    }
}
