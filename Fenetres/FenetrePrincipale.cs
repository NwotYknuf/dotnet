﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dotnet
{
    public partial class FenetrePrincipale : Form
    {
        public FenetrePrincipale()
        {
            InitializeComponent();

            initialisation();
        }

        private void initialisation()
        {
            ucAccueil1.BringToFront();
        }

        private void miAcceuil_Click(object sender, EventArgs e)
        {
            ucAccueil1.BringToFront();
            changerCouleurDeFond(miAcceuil);
        }

        private void miDiplome_Click(object sender, EventArgs e)
        {
            ucListeDiplome1.BringToFront();
            changerCouleurDeFond(miDiplome);
        }

        private void miPersonnel_Click(object sender, EventArgs e)
        {
            ucListePersonnel1.BringToFront();
            changerCouleurDeFond(miPersonnel);
        }

        private void miGestion_Click(object sender, EventArgs e)
        {
            ucGestion1.BringToFront();
            changerCouleurDeFond(miGestion);
        }

        private void miRecherche_Click(object sender, EventArgs e)
        {
            ucRecherche1.BringToFront();
            changerCouleurDeFond(miRecherche);
        }

        private void changerCouleurDeFond(ToolStripMenuItem ms)
        {
            foreach(ToolStripMenuItem mItem in msMenu.Items)
            {
                mItem.BackColor = Color.FromArgb(60,185,213);
            }
            ms.BackColor = Color.FromArgb(20, 79, 93);
        }
    }
}