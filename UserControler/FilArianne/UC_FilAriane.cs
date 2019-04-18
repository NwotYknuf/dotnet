using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dotnet.Properties;

namespace dotnet.UserControler.FilArianne
{
    public partial class UC_FilAriane : UserControl
    {
        public UC_FilAriane()
        {
            InitializeComponent();
        }

        private void changerImageDansLabel(Label l, Image im)
        {
            try
            {
                l.Image = im;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private void changerCouleurLabel(Label l, Color c)
        {
            l.ForeColor = c;
        }

        protected void couleurdeFondRacineBleue(Label l)
        {
            changerImageDansLabel(l, Resources.fA_racine_bleu_113x36); // Image.FromFile(@"..\..\Images\FilAriane\fA_racine_bleu_113x36.png");
            //changerCouleurLabel(l, System.Drawing.Color.White);           
        }

        protected void couleurdeFondRacineBlanche(Label l)
        {
            changerImageDansLabel(l, Resources.fA_racine_blanc_113x36); // Image.FromFile(@"..\..\Images\FilAriane\fA_racine_blanc_113x36.png");
            //changerCouleurLabel(l, System.Drawing.Color.FromArgb(60, 185, 213));                 
        }

        protected void couleurdeFondBleue(Label l)
        {
            changerImageDansLabel(l, Resources.fA_bleu_113x36); // Image.FromFile(@"..\..\Images\FilAriane\fA_bleu_113x36.png");
            changerCouleurLabel(l, System.Drawing.Color.White);    
        }

        protected void couleurdeFondBlanche(Label l)
        {
            changerImageDansLabel(l, Resources.fA_blanc_113x36); // Image.FromFile(@"..\..\Images\FilAriane\fA_blanc_113x36.png");
            changerCouleurLabel(l, System.Drawing.Color.FromArgb(60, 185, 213));  
        }
    }
}
