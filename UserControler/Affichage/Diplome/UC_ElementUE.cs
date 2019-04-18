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
using dotnet.Fenetres.Suppression;
using dotnet.Fenetres.Modification;

namespace dotnet.UserControler.Affichage
{
    public partial class UC_ElementUE : UC_ElementD
    {
        private ue _ue;

        public UC_ElementUE()
        {
            InitializeComponent();
        }

        public UC_ElementUE(UC_OngletDiplomes cadre, ue u) : base(cadre)
        {
            _ue = u;
            InitializeComponent();
            gBAffElement.Text = _ue.nom;
            tBDesc.Text = _ue.description;
        }

        private void panel_DoubleClick(object sender, EventArgs e)
        {
            // Afficher les EC de l'UE selectionnée
            _cadre.afficheUESelectionnee(_ue);
        }

        private void pBModifier_Click(object sender, EventArgs e)
        {
            new FenetreModifUE(this, _ue).Show();
        }

        private void pBSupprimer_Click(object sender, EventArgs e)
        {
            new FenetreSupprimerUE(this, _ue).Show();
        }

        public void suppressionConfirmee(ue u)
        {
            Requetes.retirerUE(u);
            Requetes.enregistreLaBDD();
            _cadre.Actualiser();
        }

        public void modificationConfirmee()
        {
            Requetes.enregistreLaBDD();
            _cadre.Actualiser();
        }
    }
}
