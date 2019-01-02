﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PopVinylCollectionManager {
    class Database {
        private Database _Instance;
        private SqlConnection conn;
        private static readonly string _ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + Application.StartupPath + @"\Database.mdf;Integrated Security=True";;

        private Database() {
            _Instance = new Database();
        }

        public Database Instance {
            get {
                return _Instance;
            }
        }

        public List<Product> GetAllProductsFromDB() {
            return new List<Product>();
        }

        public bool AddProductToDB(/*name, img, etc*/) {
            return true;
        }

        public bool RemoveProductFromDB(/*product name,*/) {
            return true;
        }

        public bool UpdateProductInDB(/*product name, changes*/) {
            return true;
        }
    }
}
