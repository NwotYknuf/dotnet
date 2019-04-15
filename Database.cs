using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotnet {
    public class Database : sysEntities {
        private static Database _instance = null;

        public static Database instance {
            get {
                if (_instance == null) {
                    _instance = new Database();

                    if ( ! _instance.Database.Exists()) {
                        throw new PasDeConnexion();
                    }

                }
                return _instance;
            }
        }

        private Database() : base() { }

    }
}
