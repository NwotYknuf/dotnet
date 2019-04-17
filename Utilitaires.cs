﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dotnet
{
    class Utilitaires
    {

        public static bool conditionsRespectees(String champsAControler, bool accepteLesLettres, bool accepteLesChiffres, bool accepteLesEspaces, bool accepteLesCaracteresSpeciaux, int nbCaracteresMin, int nbCaracteresMax)
        {
            // Renvoie vrai si le champsAControler respecte une taille comprise entre nbCaractereMin et nbCaractereMax et les caractères souhaitées en entrés

            String reg = "^["; // ^ : Début de ligne, [ : début du conténaire
            if (accepteLesLettres) reg += "a-zA-Z"; // a - z : Tous les caractères minuscules, A-Z : Tous les caractères majuscules
            if (accepteLesChiffres) reg += "0-9"; // 0-9 : Tous les chiffres
            if (accepteLesEspaces) reg += "\\s"; // \s : Tous les caractères espaces
            if (accepteLesCaracteresSpeciaux) reg += "\\W"; // Tous les carcatères spéciaux
            reg += "]+$"; // + : Un à plusieurs caractères, $ : Fin de ligne

            Regex monRegex = new Regex(reg);
                       
            if (nbCaracteresMin == 0) // si le champs peut être vide
                if (string.IsNullOrEmpty(champsAControler)) 
                    return true;

            if ((champsAControler.Length >= nbCaracteresMin) && (champsAControler.Length <= nbCaracteresMax) && (monRegex.IsMatch(champsAControler)))
                return true;
            else
                return false;

        }

        public static bool conditionsRespectees(String champsAControler, ComboBox cb)
        {
            // Renvoie vrai si le champsAControler fait parti des champs de la combobox, faux sinon

            if (cb.Items.IndexOf(champsAControler) != -1)
                return true;
            else
                return false;
        }

        public static bool conditionsRespecteesEmail(String champsAControler)
        {
            Regex monRegex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            if (monRegex.IsMatch(champsAControler))
                return true;
            else
                return false;
        }

        public static bool conditionsRespecteesTelephone(String champsAControler)
        {
            Regex monRegex = new Regex("^[0-9]+$");

            if (string.IsNullOrEmpty(champsAControler)) // le champs peut être vide
                return true;

            if ((champsAControler.Length == 10) && (monRegex.IsMatch(champsAControler))) // le champs non vide doit être égal à 10 chiffres
                return true;
            else
                return false;
        }
    }
}
