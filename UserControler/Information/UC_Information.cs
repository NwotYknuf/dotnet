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
    public partial class UC_Information : UserControl
    {
        public UC_Information()
        {
            InitializeComponent();
        }

        public void remplie(personnel p)
        {
            tBNom.Text = p.nom;
            tBPrenom.Text = p.prenom;
            tBTelephone.Text = p.telephone;
            tBAdresseEmail.Text = p.email;
            tBAdressePost.Text = p.adresse;
            tBNbHeuresAttrib.Text = "";
            tBNbHeuresNonAttrib.Text = "";

        }
    }
}
