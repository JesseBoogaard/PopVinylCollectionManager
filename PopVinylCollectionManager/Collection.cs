using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PopVinylCollectionManager {
    public class Collection {
        private string _Name { get; set; }
        private string _Info { get; set; }
        private int Id { get; }
        private List<Product> _Products { get; set; } = new List<Product>();

        public Collection(string Name, string Info) {
            _Name = Name;
            _Info = Info;
        }

        public string Name {
            get {
                return _Name;
            }
        }

        public override string ToString() {
            return $"Collection: {_Name} \t Info: {_Info}";
        }
    }
}
