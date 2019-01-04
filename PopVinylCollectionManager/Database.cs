using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PopVinylCollectionManager {
    class Database {
        private static Database _instance = new Database();
        private static readonly string _ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + Application.StartupPath + @"\Database.mdf;Integrated Security=True";
        private SqlConnection Conn = new SqlConnection(_ConnectionString);

        private Database() {
        }

        public static Database Instance {
            get {
                return _instance;
            }
        }

        public bool AddUserToDB(string Name, string Password) {
            try {
                string Query = $"INSERT INTO Usr (Name, Password) VALUES {Name}, {Password}";
                Conn.Open();
                SqlCommand cmd = new SqlCommand(Query, Conn);
                using(SqlDataReader r = cmd.ExecuteReader()) {
                    while (r.Read()) {

                    }
                    Conn.Close();
                }
            } catch(Exception e){
                MessageBox.Show(e.Message);
                return false;
            }
            return true;
        }

        public bool AddCollectionToDB(string Name, string Info) {
            string Query = $"INSERT INTO UserCollection (CollectionName, CollectionInfo) VALUES ({Name}, {Info})";
            return true;
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
