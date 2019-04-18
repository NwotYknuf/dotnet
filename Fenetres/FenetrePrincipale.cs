﻿using dotnet.UserControler;
using System;
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
            changerCouleurDeFond(miAcceuil);

            ucAccueil1.attribuerFenetrePrincipale(this);
            ucListeDiplome1.attribuerFenetrePrincipale(this);
            ucListePersonnel1.attribuerFenetrePrincipale(this);
            ucGestion1.attribuerFenetrePrincipale(this);
            ucRecherche1.attribuerFenetrePrincipale(this);
        }

        private void OngletChange(ToolStripMenuItem menu, UC_Onglet uc)
        {
            uc.BringToFront();
            uc.Actualiser();
            changerCouleurDeFond(menu);
        }

        private void miAcceuil_Click(object sender, EventArgs e)
        {
            OngletChange(miAcceuil, ucAccueil1);
        }

        private void miDiplome_Click(object sender, EventArgs e)
        {
            OngletChange(miDiplome, ucListeDiplome1);
        }

        private void miPersonnel_Click(object sender, EventArgs e)
        {
            OngletChange(miPersonnel, ucListePersonnel1);
        }

        private void miGestion_Click(object sender, EventArgs e)
        {
            OngletChange(miGestion, ucGestion1);
        }

        private void miRecherche_Click(object sender, EventArgs e)
        {
            OngletChange(miRecherche, ucRecherche1);
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
