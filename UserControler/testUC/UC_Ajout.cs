﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dotnet.UserControler.testUC
{
    public partial class UC_Ajout : UserControl
    {
        UC_OngletDiplomes _cadre;

        public UC_Ajout()
        {
            InitializeComponent();
        }

        public UC_Ajout(UC_OngletDiplomes cadre)
        {
            this._cadre = cadre;
        }

        public UC_Ajout(string titre)
        {
            groupBox1.Text = titre;
        }
    }
}