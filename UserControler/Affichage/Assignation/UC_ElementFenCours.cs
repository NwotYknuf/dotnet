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

namespace dotnet.UserControler.Affichage.Assignation
{
    public partial class UC_ElementFenCours : UC_ElementFenAssign
    {
        private cours _cours;

        public UC_ElementFenCours()
        {
            InitializeComponent();
        }

        public UC_ElementFenCours(FenetreAssignationCours cadre, cours c) : base(cadre)
        {
            InitializeComponent();
            _cours = c;
            gBAffElement.Text = _cours.nom;
            tBCours.Text = _cours.id_type.ToString();
            tBHoraires.Text = _cours.volume_horraire.ToString();
            tBEC.Text = _cours.id_ec.ToString(); // Database.instance.ec.Where(x => x.id == _cours.id_ec).FirstOrDefault<ec>().nom;

            toolTip1.SetToolTip(this.pBAjouterCours, "Ajouter un cours au personnel");
        }

        private void pBAjouterCours_Click(object sender, EventArgs e)
        {
            _cadre.AssigneCours(_cours);
            _cadre.Dispose();
        }
    }
}
