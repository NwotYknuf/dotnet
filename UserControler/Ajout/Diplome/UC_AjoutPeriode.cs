﻿using System;
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
    public partial class UC_AjoutPeriode : UC_AjoutD
    {
        public UC_AjoutPeriode()
        {
            InitializeComponent();
        }

        public UC_AjoutPeriode(UC_OngletDiplomes cadre) : base(cadre)
        {
            InitializeComponent();
            //this.gBTitre.Text = "Ajouter une période : ";
        }

        private void bCreer_Click(object sender, EventArgs e)
        {
            if ((conditionsRespectees(tBNom.Text, true, true, true, false, 2, 100)) &&
                (conditionsRespectees(rtBDesc.Text, true, true, true, true, 2, 100)))
            {
                lErreur.Visible = false;
                // Ajouter une période

            }
            else
            {
                lErreur.Visible = true;
            }
        }
    }
}