using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotnet {
    public static class Requetes {
        
        public static List<cours> coursAttribues(personnel personnel) {
            var coursAttribues = Database.instance.cours.Where(x => x.personnel.id == personnel.id).ToList();
            List<cours> liste = new List<cours>();
            foreach(cours c in coursAttribues) {
                liste.Add(c);
            }

            return liste;
        }

        public static int nbrHeureAttribuees(personnel personnel) {
            int res = 0;
            foreach(cours c in coursAttribues(personnel)) {
                res += (int)c.volume_horraire;
            }
            return res;
        }


    }
}
