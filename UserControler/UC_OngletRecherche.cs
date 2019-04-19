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
using dotnet.UserControler.Affichage.Recherche;

namespace dotnet.UserControler
{
    public partial class UC_OngletRecherche : UC_Onglet
    {
        public UC_OngletRecherche()
        {
            InitializeComponent();
        }

        private void UC_OngletRecherche_Load(object sender, EventArgs e)
        {
            uC_Affichage1.setGroupBoxTiTre("Résultats de la recherche : ");
            cBCritere.SelectedIndex = 0;
        }

        private void bLancerRech_Click(object sender, EventArgs e)
        {
            if((Utilitaires.conditionsRespectees(tbRecherche.Text.Trim(), true, true, true, true, 2, 100)) && 
               (Utilitaires.conditionsRespectees(cBCritere.Text, cBCritere)) )
            {
                uC_Affichage1.Visible = true;
                lErreur.Visible = false;

                // Rechercher

                switch(cBCritere.Text)
                {
                    case "Diplôme":
                        {
                            uC_Affichage1.clearElements();

                            var resultats = Database.instance.diplome;
                            List<diplome> liste = new List<diplome>();

                            foreach (diplome d in resultats.ToList())
                            {
                                if (txtTrouveDans(d))
                                    liste.Add(d);
                            }
                            foreach (diplome d in liste)
                            {
                                uC_Affichage1.addElement(new UC_ElementDiplomeRech(this, d));
                            }
                            if (uC_Affichage1.getNombreElement() == 0)
                            {
                                uC_Affichage1.addElement(new UC_ElementLabelRech());
                            }
                            uC_Affichage1.updateAffichage();
                            break;
                        }
                    case "Année":
                        {
                            uC_Affichage1.clearElements();

                            var resultats = Database.instance.annee;
                            List<annee> liste = new List<annee>();

                            foreach (annee a in resultats.ToList())
                            {
                                if (txtTrouveDans(a))
                                    liste.Add(a);
                            }
                            foreach (annee a in liste)
                            {
                                uC_Affichage1.addElement(new UC_ElementAnneeRech(this, a));
                            }
                            if (uC_Affichage1.getNombreElement() == 0)
                            {
                                uC_Affichage1.addElement(new UC_ElementLabelRech());
                            }
                            uC_Affichage1.updateAffichage();
                            break;
                        }
                    case "Période":
                        {
                            uC_Affichage1.clearElements();

                            var resultats = Database.instance.periode;
                            List<periode> liste = new List<periode>();

                            foreach (periode p in resultats.ToList())
                            {
                                if (txtTrouveDans(p))
                                    liste.Add(p);
                            }
                            foreach (periode p in liste)
                            {
                                uC_Affichage1.addElement(new UC_ElementPeriodeRech(this, p));
                            }
                            if (uC_Affichage1.getNombreElement() == 0)
                            {
                                uC_Affichage1.addElement(new UC_ElementLabelRech());
                            }
                            uC_Affichage1.updateAffichage();
                            break;
                        }
                    case "UE":
                        {
                            uC_Affichage1.clearElements();

                            var resultats = Database.instance.ue;
                            List<ue> liste = new List<ue>();

                            foreach (ue u in resultats.ToList())
                            {
                                if (txtTrouveDans(u))
                                    liste.Add(u);
                            }
                            foreach (ue u in liste)
                            {
                                uC_Affichage1.addElement(new UC_ElementUERech(this, u));
                            }
                            if (uC_Affichage1.getNombreElement() == 0)
                            {
                                uC_Affichage1.addElement(new UC_ElementLabelRech());
                            }
                            uC_Affichage1.updateAffichage();
                            break;
                        }
                    case "EC":
                        {
                            uC_Affichage1.clearElements();

                            var resultats = Database.instance.ec;
                            List<ec> liste = new List<ec>();

                            foreach (ec ec in resultats.ToList())
                            {
                                if (txtTrouveDans(ec))
                                    liste.Add(ec);
                            }
                            foreach (ec ec in liste)
                            {
                                uC_Affichage1.addElement(new UC_ElementECRech(this, ec));
                            }
                            if (uC_Affichage1.getNombreElement() == 0)
                            {
                                uC_Affichage1.addElement(new UC_ElementLabelRech());
                            }
                            uC_Affichage1.updateAffichage();
                            break;
                        }
                    case "Cours":
                        {
                            uC_Affichage1.clearElements();

                            var resultats = Database.instance.cours;
                            List<cours> liste = new List<cours>();

                            foreach (cours c in resultats.ToList())
                            {
                                if (txtTrouveDans(c))
                                    liste.Add(c);
                            }
                            foreach (cours c in liste)
                            {
                                uC_Affichage1.addElement(new UC_ElementCoursRech(this, c));
                            }
                            if (uC_Affichage1.getNombreElement() == 0)
                            {
                                uC_Affichage1.addElement(new UC_ElementLabelRech());
                            }
                            uC_Affichage1.updateAffichage();
                            break;
                        }
                    case "Personnel":
                        {
                            uC_Affichage1.clearElements();

                            var resultats = Database.instance.personnel;
                            List<personnel> liste = new List<personnel>();

                            foreach (personnel p in resultats.ToList())
                            {
                                if (txtTrouveDans(p))
                                    liste.Add(p);
                            }
                            foreach (personnel p in liste)
                            {
                                uC_Affichage1.addElement(new UC_ElementPersonnelRech(this, p));
                            }
                            if (uC_Affichage1.getNombreElement() == 0)
                            {
                                uC_Affichage1.addElement(new UC_ElementLabelRech());
                            }
                            uC_Affichage1.updateAffichage();
                            break;
                        }
                    default: break;
                }
               
            }
            else
            {
                uC_Affichage1.Visible = false;
                lErreur.Visible = true;
            }
        }

        private bool txtTrouveDans(diplome d)
        {
            if ((d.nom.ToLower().Contains(tbRecherche.Text.ToLower())) || 
                (d.description.ToLower().Contains(tbRecherche.Text.ToLower())) ) 
            {
                return true;
            }
            return false;
        }

        private bool txtTrouveDans(annee a) 
        {
            if ((a.nom.ToLower().Contains(tbRecherche.Text.ToLower())) ||
                (a.description.ToLower().Contains(tbRecherche.Text.ToLower())) ||
                (a.diplome.nom.ToLower().Contains(tbRecherche.Text.ToLower())) )
            {
                return true;
            }
            return false;
        }

        private bool txtTrouveDans(periode p)
        {
            if ((p.nom.ToLower().Contains(tbRecherche.Text.ToLower())) ||
                (p.description.ToLower().Contains(tbRecherche.Text.ToLower())) ||
                (p.annee.nom.ToLower().Contains(tbRecherche.Text.ToLower())) )
            {
                return true;
            }
            return false;
        }

        private bool txtTrouveDans(ue u)
        {
            if ((u.nom.ToLower().Contains(tbRecherche.Text.ToLower())) ||
                (u.description.ToLower().Contains(tbRecherche.Text.ToLower())) ||
                (u.periode.nom.ToLower().Contains(tbRecherche.Text.ToLower())) )
            {
                return true;
            }
            return false;
        }

        private bool txtTrouveDans(ec e)
        {
            if ((e.nom.ToLower().Contains(tbRecherche.Text.ToLower())) ||
                (e.description.ToLower().Contains(tbRecherche.Text.ToLower())) ||
                (e.ue.nom.ToLower().Contains(tbRecherche.Text.ToLower())) ||
                ( (tbRecherche.Text == "activée") && (e.actif == true) ) ||
                ( (tbRecherche.Text == "désactivée") && (e.actif == false) ) )
            {
                return true;
            }
            return false;
        }

        private bool txtTrouveDans(cours c)
        {
            if ((c.nom.ToLower().Contains(tbRecherche.Text.ToLower())) ||
                (c.type_cours.nom.ToLower().Contains(tbRecherche.Text.ToLower())) ||
                (c.volume_horraire.ToString().Contains(tbRecherche.Text)) ||
                ( (c.personnel != null) && (c.personnel.nom.ToLower().Contains(tbRecherche.Text.ToLower()))) ||
                (c.ec.nom.ToLower().Contains(tbRecherche.Text.ToLower())) )
            {
                return true;
            }
            return false;
        }

        private bool txtTrouveDans(personnel p)
        {
            if ((p.nom.ToLower().Contains(tbRecherche.Text.ToLower())) ||
                (p.prenom.ToLower().Contains(tbRecherche.Text.ToLower())) || 
                (p.telephone.ToLower().Contains(tbRecherche.Text.ToLower())) ||
                (p.email.ToLower().Contains(tbRecherche.Text.ToLower())) ||
                (p.adresse.ToLower().Contains(tbRecherche.Text.ToLower())) ||
                (p.categorie.nom.ToLower().Contains(tbRecherche.Text.ToLower())) )
            {
                return true;
            }
            return false;
        }

        public override void Actualiser()
        {
            this.Update();
        }
    }
}
