using System;
using System.Collections.Generic;
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

        public static void enregistreLaBDD()
        {
            Database.instance.SaveChanges();
        }


    }
}
