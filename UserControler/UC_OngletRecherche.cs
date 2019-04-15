﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace dotnet
{
    public partial class UC_OngletRecherche : UserControl
    {
        public UC_OngletRecherche()
        {
            InitializeComponent();
        }

        private void UC_OngletRecherche_Load(object sender, EventArgs e)
        {
            uC_Affichage1.setGroupBoxTiTre("Résultats de la recherche : ");
        }

        private void bLancerRech_Click(object sender, EventArgs e)
        {
            if((Utilitaires.conditionsRespectees(tbRecherche.Text.Trim(), true, true, true, false, 2, 100)) && 
               (Utilitaires.conditionsRespectees(cBCritere.Text, cBCritere)) )
            {
                lErreur.Visible = false;

                // Rechercher

                /*var resultats = Database.instance;
                foreach (resultats)
                {
                    uC_Affichage1.addElement(new UC_Element(this, d));
                }
                uC_Affichage1.updateAffichage();*/
            }
            else
            {
                lErreur.Visible = true;
            }
        }
    }
}
