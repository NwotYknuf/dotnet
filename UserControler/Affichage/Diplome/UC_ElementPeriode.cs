using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dotnet.UserControler.Affichage
{
    public partial class UC_ElementPeriode : UC_ElementD
    {
        private periode _periode;

        public UC_ElementPeriode()
        {
            InitializeComponent();
        }

        public UC_ElementPeriode(UC_OngletDiplomes cadre, periode p) : base(cadre)
        {
            _periode = p;
            InitializeComponent();
            gBAffElement.Text = _periode.nom;
            tBDesc.Text = _periode.description;
        }

        private void panel_DoubleClick(object sender, EventArgs e)
        {
            // Afficher les UE de la période séléctionnée
            _cadre.affichePeriodeSelectionnee(_periode);

        }
    }
}
