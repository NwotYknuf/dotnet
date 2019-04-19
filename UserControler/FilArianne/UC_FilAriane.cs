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

        protected bool imgLabelRacineEst(Label l, Image img)
        {
            /*if (l.Image.Equals(img))
                return true;
            else
                return false;*/

            bool flag = true;
            string img1_ref, img2_ref;
            Bitmap img1 = new Bitmap(l.Image);
            Bitmap img2 = new Bitmap(img);
            if (img1.Width == img2.Width && img1.Height == img2.Height)
            {
                for (int i = 0; i < img1.Width; i++)
                {
                    for (int j = 0; j < img1.Height; j++)
                    {
                        img1_ref = img1.GetPixel(i, j).ToString();
                        img2_ref = img2.GetPixel(i, j).ToString();
                        if (img1_ref != img2_ref)
                        {
                            flag = false;
                            break;
                        }
                    }
                }
            }
            if (flag == false)
                return false;
            else
                return true;
        }

        protected void labelRacineSurvolDebute(Label l)
        {
            if (imgLabelRacineEst(l, Resources.fA_racine_blanc_113x36))

                changerImageDansLabel(l, Resources.fA_racine_blanc_fonce_113x36);

            else if (imgLabelRacineEst(l, Resources.fA_racine_bleu_113x36))

                changerImageDansLabel(l, Resources.fA_racine_bleu_fonce_113x36);
        }

        protected void labelRacineSurvolTermine(Label l)
        {
            if (imgLabelRacineEst(l, Resources.fA_racine_blanc_fonce_113x36))

                changerImageDansLabel(l, Resources.fA_racine_blanc_113x36);

            else if (imgLabelRacineEst(l, Resources.fA_racine_bleu_fonce_113x36))

                changerImageDansLabel(l, Resources.fA_racine_bleu_113x36);
        }

        protected void labelSurvolDebute(Label l)
        {
            if (imgLabelRacineEst(l, Resources.fA_blanc_113x36))

                changerImageDansLabel(l, Resources.fA_blanc_fonce_113x36);

            else if (imgLabelRacineEst(l, Resources.fA_bleu_113x36))

                changerImageDansLabel(l, Resources.fA_bleu_fonce_113x36);
        }

        protected void labelSurvolTermine(Label l)
        {
            if (imgLabelRacineEst(l, Resources.fA_blanc_fonce_113x36))

                changerImageDansLabel(l, Resources.fA_blanc_113x36);

            else if (imgLabelRacineEst(l, Resources.fA_bleu_fonce_113x36))

                changerImageDansLabel(l, Resources.fA_bleu_113x36);
        }
    }
}
