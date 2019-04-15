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
    public partial class FenetreAjout : Form
    {
        private UC_OngletGestion _uC;
        private String _element;

        public FenetreAjout()
        {
            InitializeComponent();
        }

        public FenetreAjout(String titre, UC_OngletGestion u, String el)
        {
            InitializeComponent();
            this._uC = u;
            this.lTitre.Text = titre;
            this._element = el;
        }

        private void FenetreAjout_Load(object sender, EventArgs e)
        {

        }
        
        private void bValider_Click(object sender, EventArgs e)
        {
            if (Utilitaires.conditionsRespectees(tB.Text.Trim(), true, true, false, false, 2, 30))
            {
                lErreur.Visible = false;
                _uC.ajout(_element, tB.Text.Trim());
                this.Dispose();
            }
            else
            {
                lErreur.Visible = true;
            }
        }
    }
}
