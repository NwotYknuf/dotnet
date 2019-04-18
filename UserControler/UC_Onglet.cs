using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dotnet.UserControler
{
    public partial class UC_Onglet : UserControl
    {
        private FenetrePrincipale _fenetrePrincipale;

        public UC_Onglet()
        {
            InitializeComponent();
        }

        public void attribuerFenetrePrincipale(FenetrePrincipale f)
        {
            _fenetrePrincipale = f;
        }

        public virtual void Actualiser()
        {

        }
    }
}
