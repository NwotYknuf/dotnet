using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dotnet.UserControler.Affichage;
using dotnet.UserControler.Affichage.Accueil;

namespace dotnet.UserControler
{
    public partial class UC_OngletAccueil : UC_Onglet
    {
        public UC_OngletAccueil()
        {
            InitializeComponent();
        }
        
        private void UC_OngletAccueil_Load(object sender, EventArgs e)
        {
            pBienvenu.BringToFront();

            lTitre.Text = "Accueil";
            
            initialisePersonnels(uC_AffPersonnel);
            initialiseCours(uC_AffCours);

            timerBienvenu.Interval = 3000; // 2 secondes
            timerBienvenu.Enabled = true;
            timerBienvenu.Start();

            timerHorloge.Interval = 1000; // 1 seconde
            timerHorloge.Enabled = true;
            timerHorloge.Start();

        }

        public void initialisePersonnels(UC_AffichageA uc)
        {
            uc.setGroupBoxTiTre("Les personnels qui n'ont pas toutes leurs heures affectées : ");

            uc.clearElements();

            var personnels = Database.instance.personnel;
            foreach (personnel p in personnels.ToList())
            {
                if(Requetes.nbrHeureManquantes(p) > 0)
                    uc.addElement(new UC_ElementPersonnelAccueil(this, p));
            }
            
            if (uc.getNombreElement() == 0)
            {
                uc.addElement(new UC_ElementLabel());
            }

            uc.updateAffichage();
        }

        public void initialiseCours(UC_AffichageA uc)
        {
            uc.setGroupBoxTiTre("Les cours actifs non affectés à un personnel : ");

            uc.clearElements();

            var cours = Database.instance.cours;
            foreach (cours c in cours.ToList())
            {
                if((c.id_personnel == null) && (Requetes.obtientECduCours(c).actif == true))
                    uc.addElement(new UC_ElementCoursAccueil(this, c));
            }

            if (uc.getNombreElement() == 0)
            {
                uc.addElement(new UC_ElementLabel());
            }
                
            uc.updateAffichage();
        }

        public override void Actualiser()
        {
            initialisePersonnels(uC_AffPersonnel);
            initialiseCours(uC_AffCours);
        }

        //Après 2 secondes, fais disparaitre le panel de Bienvenu
        private void timerBienvenu_Tick(object sender, EventArgs e)
        {
            /*for(int i = 100; i >= 0; i--)
            {
                pBienvenu.BackColor = Color.FromArgb(i, 255, 255, 255);
                lBienvenu.ForeColor = Color.FromArgb(i, 60, 185, 213);
                pBienvenu.Update();
                
            }*/
            pBienvenu.Visible = false;
            timerBienvenu.Stop();
        }

        //Affiche toutes les secondes l'heure à l'horloge
        private void timerHorloge_Tick(object sender, EventArgs e)
        {
            String jour = DateTime.Now.DayOfWeek.ToString();
            int numero = DateTime.Now.Day;
            int mois = DateTime.Now.Month;
            int annee = DateTime.Now.Year;

            int heure = DateTime.Now.Hour;
            int minute = DateTime.Now.Minute;
            int seconde = DateTime.Now.Second;

            lDate.Text = convertitJour(jour) + " " + numero.ToString() + " " + convertitMois(mois) + " " + annee.ToString();
            lHorloge.Text = heure.ToString() + ":" + minute.ToString() + ":" + seconde.ToString();
        }

        private String convertitJour(String jour)
        {
            switch(jour)
            {
                case "Monday": return "Lundi";
                case "Tuesday": return "Mardi";
                case "Wednesday": return "Mercredi";
                case "Thursday": return "Jeudi";
                case "Friday": return "Vendredi";
                case "Saturday": return "Samedi";
                case "Sunday": return "Dimanche";
                default: return "";
            }
        }

        private String convertitMois(int mois)
        {
            switch (mois)
            {
                case 1: return "Janvier";
                case 2: return "Février";
                case 3: return "Mars";
                case 4: return "Avril";
                case 5: return "Mai";
                case 6: return "Juin";
                case 7: return "Juillet";
                case 8: return "Août";
                case 9: return "Septembre";
                case 10: return "Octobre";
                case 11: return "Novembre";
                case 12: return "Décembre";
                default: return "";
            }
        }

        private void pBienvenu_Click(object sender, EventArgs e)
        {
            pBienvenu.Visible = false;
            timerBienvenu.Stop();
        }
    }
}
