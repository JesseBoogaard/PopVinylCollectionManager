using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PopVinylCollectionManager {
    public class User {
        private string _Name { get; set; }
        private int _Id { get; set; }
        private List<Collection> _UserCollections = new List<Collection>();

        public User(string Name, int Id) {
            _Name = Name;
            _Id = Id;
        }

        public bool AddCollectionToUser(Collection c) {
            _UserCollections.Add(c);
            return true;
        }

        bool RemoveProductFromCollection(/*CollectionName, ProductName*/) {
            return true;
        }

        List<Product> GetUserCollection(string CollectionName) {
            return new List<Product>();
        }

        public List<Collection> GetAllUserCollections {
            get {
                return _UserCollections;
            }
        }
    }
}
