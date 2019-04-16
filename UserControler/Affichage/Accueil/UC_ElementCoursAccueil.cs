using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dotnet.Fenetres;

namespace dotnet.UserControler.Affichage.Accueil
{
    public partial class UC_ElementCoursAccueil : UC_ElementA
    {
        private cours _cours;

        public UC_ElementCoursAccueil()
        {
            InitializeComponent();
        }

        public UC_ElementCoursAccueil(UC_OngletAccueil cadre, cours c) : base(cadre)
        {
            InitializeComponent();
            _cours = c;
            gBAffElement.Text = _cours.nom;
            tBCours.Text = _cours.id_type.ToString();
            tBHoraires.Text = _cours.volume_horraire.ToString();
            tBEC.Text = _cours.id_ec.ToString(); // Database.instance.ec.Where(x => x.id == _cours.id_ec).FirstOrDefault<ec>().nom;
            
        }

        private void pBSupprimer_Click(object sender, EventArgs e)
        {
            new FenetreSupprimer("Cours", _cours).Show();
        }

        private void pBModifier_Click(object sender, EventArgs e)
        {

        }

        private void panel_DoubleClick(object sender, EventArgs e)
        {

        }
    }
}
