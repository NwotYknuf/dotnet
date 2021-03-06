﻿using System;
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
    public partial class UC_ElementDiplome : UC_ElementD
    {
        private diplome _diplome;

        public UC_ElementDiplome() {
            InitializeComponent();
        }

        public UC_ElementDiplome(UC_OngletDiplomes cadre, diplome d) : base(cadre) {
            _diplome = d;
            InitializeComponent();
            gBAffElement.Text = _diplome.nom;
            tBDesc.Text = _diplome.description;
        }

        private void panel_DoubleClick(object sender, EventArgs e)
        {
            // Afficher les années du diplôme séléctionné 
            _cadre.afficheDiplomeSelectionne(_diplome);
        }

        private void pBModifier_Click(object sender, EventArgs e)
        {
            new FenetreModifDiplome(this, _diplome).Show();
        }

        private void pBSupprimer_Click(object sender, EventArgs e)
        {
            new FenetreSupprimerDiplome(this, _diplome).Show();
        }

        public void suppressionConfirmee(diplome d)
        {
            Requetes.retirerDiplome(d);
            Requetes.enregistreLaBDD();
            _cadre.Actualiser();
        }

        public void modificationConfirmee()
        {
            Requetes.enregistreLaBDD();
            _cadre.Actualiser();
        }

        private void panel_MouseEnter(object sender, EventArgs e)
        {
            panel.BackColor = Utilitaires.couleurBleuTurquoiseFonce();
        }

        private void panel_MouseLeave(object sender, EventArgs e)
        {
            panel.BackColor = Utilitaires.couleurBleuTurquoise();
        }

        private void panel_MouseHover(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.Hand;
        }
    }
}
