﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dotnet.UserControler.Ajout {
    public partial class UC_AjoutDiplome : UC_AjoutD
    {
        
        public UC_AjoutDiplome() {
            InitializeComponent();
        }

        public UC_AjoutDiplome(UC_OngletDiplomes cadre) : base(cadre) {
            InitializeComponent();
            //this.gBTitre.Text = "Ajouter un Diplome : ";
        }

        private void bCreer_Click(object sender, EventArgs e) {
            //ajouter un diplome
        }
    }
}
