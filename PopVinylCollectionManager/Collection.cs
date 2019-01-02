using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PopVinylCollectionManager {
    class Collection {
        private string _Name { get; set; }
        private string _Info { get; set; }
        private int Id { get; }

        public Collection(string Name, string Info) {
            _Name = Name;
            _Info = Info;
        }
    }
}
