﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dotnet.UserControler.Affichage.Recherche
{
    public partial class UC_ElementR : UC_Element
    {
        protected UC_OngletRecherche _cadre;

        public UC_ElementR()
        {
            InitializeComponent();
        }

        public UC_ElementR(UC_OngletRecherche cadre)
        {
            InitializeComponent();
            this._cadre = cadre;
        }        
    }
}
