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
    public partial class UC_ElementModifiable : UC_Element
    {
        public UC_ElementModifiable()
        {
            InitializeComponent();
        }

        private void UC_Element_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(this.pBModifier, "Modifier ce cours");
            toolTip1.SetToolTip(this.pBSupprimer, "Supprimer ce cours");
        }

        private void pBModifier_MouseEnter(object sender, EventArgs e)
        {
            changeCouleurDeFondFoncee(pBModifier);
        }

        private void pBModifier_MouseLeave(object sender, EventArgs e)
        {
            changeCouleurDeFondClaire(pBModifier);
        }

        private void pBSupprimer_MouseEnter(object sender, EventArgs e)
        {
            changeCouleurDeFondFoncee(pBSupprimer);
        }

        private void pBSupprimer_MouseLeave(object sender, EventArgs e)
        {
            changeCouleurDeFondClaire(pBSupprimer);
        }

        private void changeCouleurDeFondFoncee(PictureBox pb)
        {
            pb.BackColor = Utilitaires.couleurBleuFonce();
        }

        private void changeCouleurDeFondClaire(PictureBox pb)
        {
            pb.BackColor = Utilitaires.couleurBleuTurquoise();
        }
    }
}
