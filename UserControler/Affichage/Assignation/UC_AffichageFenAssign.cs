﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dotnet.UserControler.Affichage.Assignation
{
    public partial class UC_AffichageFenAssign : UserControl
    {
        private List<UC_Element> elements;

        public UC_AffichageFenAssign()
        {
            InitializeComponent();
            elements = new List<UC_Element>();
        }

        public void addElement(UC_Element element)
        {
            elements.Add(element);
        }

        public void clearElements()
        {
            elements.Clear();
        }

        public void updateAffichage()
        {
            flowLPanel.Controls.Clear();

            foreach (UC_Element e in elements)
            {
                flowLPanel.Controls.Add(e);
            }
        }

        public int getNombreElement()
        {
            return elements.Count;
        }

        public void setGroupBoxTiTre(String titre)
        {
            gBTitreAffichage.Text = titre;
        }
    }
}
