using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotnet {
    public static class Requetes {
        
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
    }
}
