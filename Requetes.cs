﻿using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotnet {
    public static class Requetes {
           
        // Requêtes spécifiques à un personnel

        public static List<cours> coursAttribues(personnel personnel) {
            return Database.instance.cours.Where(x => x.personnel.id == personnel.id).ToList<cours>();
        }

        public static int nbrHeureAttribuees(personnel personnel) {
            int res = 0;
            foreach(cours c in coursAttribues(personnel)) {
                res += (int)c.volume_horraire;
            }
            return res;
        }

        public static int nbrHeureDues(personnel personnel) {
            return (int)personnel.categorie.nbrHeureDues;
        }

        public static int nbrHeureManquantes(personnel personnel) {
            return nbrHeureDues(personnel) - nbrHeureAttribuees(personnel);
        }

        public static categorie obtientCategorieduPersonnel(personnel p)
        {
            return Database.instance.categorie.Where(x => x.id == p.id_categorie).FirstOrDefault<categorie>();
        }
        
        // Requêtes spécifiques à une année :

        public static diplome obtientDiplomedelAnnee(annee a)
        {
            return Database.instance.diplome.Where(x => x.id == a.id_diplome).FirstOrDefault<diplome>();
        }

        // Requêtes spécifiques à une période :

        public static annee obtientAnneedelaPeriode(periode p)
        {
            return Database.instance.annee.Where(x => x.id == p.id_annee).FirstOrDefault<annee>();
        }

        // Requêtes spécifiques à une UE :

        public static periode obtientPeriodedelUE(ue u)
        {
            return Database.instance.periode.Where(x => x.id == u.id_periode).FirstOrDefault<periode>();
        }

        // Requêtes spécifiques à une EC :

        public static ue obtientUEdelEC(ec e)
        {
            return Database.instance.ue.Where(x => x.id == e.id_ue).FirstOrDefault<ue>();
        }

        // Requêtes spécifiques à un cours :

        public static ec obtientECduCours(cours c)
        {
            return Database.instance.ec.Where(x => x.id == c.id_ec).FirstOrDefault<ec>();
        }

        public static type_cours obtientTypeduCours(cours c)
        {
            return Database.instance.type_cours.Where(x => x.id == c.id_type).FirstOrDefault<type_cours>();
        }

        public static personnel obtientPersonnelduCours(cours c)
        {
            return Database.instance.personnel.Where(x => x.id == c.personnel.id).FirstOrDefault<personnel>();
        }

        // Requête spécifiques pour récupérer un Equivalent_TD à partir du type_cours et de la categorie

        public static equivalent_td obtientEquivalentTD(type_cours typC, categorie cat)
        {
            return Database.instance.equivalent_td.Where(x => x.id_type_cours == typC.id && x.id_categ == cat.id).FirstOrDefault<equivalent_td>();
        }

        // Requêtes spécifiques à partir d'un champs texte

        public static type_cours retrouveTypeDeCoursViaTexte(String txt)
        {
            return Database.instance.type_cours.Where(s => s.nom == txt).FirstOrDefault<type_cours>();
        }

        public static categorie retrouveCategorieViaTexte(String txt)
        {
            return Database.instance.categorie.Where(s => s.nom == txt).FirstOrDefault<categorie>();
        }

        // Requête d'enregistrement

        public static void enregistreLaBDD()
        {
            Database.instance.SaveChanges();
        }

        // Requetes d'ajouts

        public static void ajouterDiplome(diplome d)
        {
            Database.instance.diplome.Add(d);
        }

        public static void ajouterAnnee(annee a)
        {
            Database.instance.annee.Add(a);
        }

        public static void ajouterPeriode(periode p)
        {
            Database.instance.periode.Add(p);
        }

        public static void ajouterUE(ue u)
        {
            Database.instance.ue.Add(u);
        }

        public static void ajouterEC(ec e)
        {
            Database.instance.ec.Add(e);
        }

        public static void ajouterCours(cours c)
        {
            Database.instance.cours.Add(c);
        }

        public static void ajouterPersonnel(personnel p)
        {
            Database.instance.personnel.Add(p);
        }

        public static void ajouterTypeDeCours(type_cours tc)
        {
            Database.instance.type_cours.Add(tc);
        }

        public static void ajouterCategorie(categorie c)
        {
            Database.instance.categorie.Add(c);
        }

        public static void ajouterEquivalentTD(equivalent_td e)
        {
            Database.instance.equivalent_td.AddOrUpdate(e);
        }

        // Requetes de retrait

        public static void retirerDiplome(diplome d)
        {
            Database.instance.diplome.Remove(d);
        }

        public static void retirerAnnee(annee a)
        {
            Database.instance.annee.Remove(a);
        }

        public static void retirerPeriode(periode p)
        {
            Database.instance.periode.Remove(p);
        }

        public static void retirerUE(ue u)
        {
            Database.instance.ue.Remove(u);
        }

        public static void retirerEC(ec e)
        {
            Database.instance.ec.Remove(e);
        }

        public static void retirerCours(cours c)
        {
            Database.instance.cours.Remove(c);
        }

        public static void retirerPersonnel(personnel p)
        {
            Database.instance.personnel.Remove(p);
        }

        public static void retirerTypeDeCours(type_cours tc)
        {
            Database.instance.type_cours.Remove(tc);
        }

        public static void retirerCategorie(categorie c)
        {
            Database.instance.categorie.Remove(c);
        }

        public static void retirerEquivalentTD(equivalent_td e)
        {
            Database.instance.equivalent_td.Remove(e);
        }
    }
}
