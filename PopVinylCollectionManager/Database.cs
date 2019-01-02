using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PopVinylCollectionManager {
    class Database {
        private Database _Instance;
        private SqlConnection Conn;
        private static readonly string _ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + Application.StartupPath + @"\Database.mdf;Integrated Security=True";;

        private Database() {
            _Instance = new Database();
            Conn = new SqlConnection(_ConnectionString);
        }

        public Database Instance {
            get {
                return _Instance;
            }
        }

        public List<Product> GetAllProductsFromDB() {
            string Query = "SELECT * FROM Products";
            List<Product> Result = new List<Product>();

            Conn.Open();
            SqlCommand cmd = new SqlCommand(Query, Conn);

            using(SqlDataReader r = cmd.ExecuteReader()) {
                while (r.Read()) {
                    Result.Add(new Product(r.GetString(0), r.GetInt32(1), r.GetInt32(2), r.GetString(3)));
                }
            }
            Conn.Close();
            return Result;

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
