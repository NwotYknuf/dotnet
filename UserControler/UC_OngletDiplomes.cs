using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dotnet.UserControler.testUC;

namespace dotnet
{
    public partial class UC_OngletDiplomes : UserControl
    {

        public UC_OngletDiplomes()
        {
            InitializeComponent();

            using (sysEntities db = new sysEntities())
            {
                var diplomes = db.diplome;
                
                foreach(diplome d in diplomes){
                    uC_Affichage1.addElement(new UC_ElementDiplome(this, d));
                }

                uC_Affichage1.updateAffichage();


            }
            
        }
    }
}
