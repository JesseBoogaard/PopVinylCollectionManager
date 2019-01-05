using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PopVinylCollectionManager {
    public class User {
        private static User _instance = new User();
        private string _Name;
        private int _Id;
        private List<Collection> _UserCollections = new List<Collection>();

        private User() {
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

        public static User Instance {
            get {
                return _instance;
            }
        }

        public string Name {
            get {
                return _Name;
            }
            set {
                _Name = value;
            }
        }

        public int CollCount {
            get {
                return _UserCollections.Count;
            }
        }

        public int Id {
            get {
                return _Id;
            }
            set {
                _Id = value;
            }
        }

    }
}
