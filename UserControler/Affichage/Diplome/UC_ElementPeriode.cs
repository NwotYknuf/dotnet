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
    public partial class UC_ElementPeriode : UC_ElementD
    {
        private periode _periode;

        public UC_ElementPeriode()
        {
            InitializeComponent();
        }

        public UC_ElementPeriode(UC_OngletDiplomes cadre, periode p) : base(cadre)
        {
            _periode = p;
            InitializeComponent();
            gBAffElement.Text = _periode.nom;
            tBDesc.Text = _periode.description;
        }

        private void panel_DoubleClick(object sender, EventArgs e)
        {
            // Afficher les UE de la période séléctionnée
            _cadre.affichePeriodeSelectionnee(_periode);

        }

        private void pBModifier_Click(object sender, EventArgs e)
        {
            new FenetreModifPeriode(this, _periode).Show();
        }

        private void pBSupprimer_Click(object sender, EventArgs e)
        {
            new FenetreSupprimerPeriode(this, _periode).Show();
        }

        public void suppressionConfirmee(periode p)
        {
            Requetes.retirerPeriode(p);
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
