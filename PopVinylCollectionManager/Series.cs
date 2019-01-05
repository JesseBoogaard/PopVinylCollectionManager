using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PopVinylCollectionManager {
    class Series {

        private int _ID;
        private string _Name;

        public Series(string Name, int ID) {
            _ID = ID;
            _Name = Name;
        }

        public override string ToString() {
            return _Name;
        }

        public int Id {
            get {
                return _ID;
            }
        }
    }
}
