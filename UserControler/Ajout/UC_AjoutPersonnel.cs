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
    public partial class UC_AjoutPersonnel : UC_AjoutP
    {
        public UC_AjoutPersonnel()
        {
            InitializeComponent();
        }

        public UC_AjoutPersonnel(UC_OngletPersonnels cadre) : base(cadre)
        {
            InitializeComponent();
            //this.gBTitre.Text = "Ajouter un personnel : ";
        }

        private void bCreer_Click(object sender, EventArgs e)
        {
            // Ajouter un personnel
        }
    }
}