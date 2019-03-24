using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace dotnet {
    public partial class UC_Ajout : UserControl
    {
       
        public UC_Ajout() {
            InitializeComponent();
        }
        
        public UC_Ajout(string titre) {
            gBTitreAjout.Text = titre;
        }
        
        protected bool conditionsRespectees(String champsAControler, bool accepteLesLettres, bool accepteLesChiffres, bool accepteLesEspaces, bool accepteLesCaracteresSpeciaux, int nbCaracteresMin, int nbCaracteresMax)
        {
            // Renvoie vrai si le champsAControler respecte une taille comprise entre nbCaractereMin et nbCaractereMax et les caractères souhaitées en entrés

            String reg = "^["; // ^ : Début de ligne, [ : début du conténaire
            if (accepteLesLettres) reg += "a-zA-Z"; // a - z : Tous les caractères minuscules, A-Z : Tous les caractères majuscules
            if (accepteLesChiffres) reg += "0-9"; // 0-9 : Tous les chiffres
            if (accepteLesEspaces) reg += "\\s"; // \s : Tous les caractères espaces
            if (accepteLesCaracteresSpeciaux) reg += "\\W"; // Tous les carcatères spéciaux
            reg += "]+$"; // + : Un à plusieurs caractères, $ : Fin de ligne

            Regex monRegex = new Regex(reg);

            if ((champsAControler.Length >= nbCaracteresMin) && (champsAControler.Length <= nbCaracteresMax) && (monRegex.IsMatch(champsAControler)))
                return true;
            else
                return false;

        }
                
        protected bool conditionsRespectees(String champAControler, ComboBox cb)
        {
            // Renvoie vrai si le champsAControler fait parti des champs de la combobox, faux sinon

            if (cb.Items.IndexOf(champAControler) != -1)
                return true;
            return false;
        }
    }
}
