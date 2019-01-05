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
        private string _ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + Application.StartupPath + @"\Database.mdf;Integrated Security=True";
        private SqlConnection Conn;

        private Database() {
           Conn = new SqlConnection(_ConnectionString);
        }

        public static Database Instance {
            get {
                return _instance;
            }
        }
        // register new user in database
        public int AddUserToDB(string Name, string Password) {
            string Query = $"INSERT INTO Usr (Name, Password) VALUES ('{Name}', '{Password}') SELECT Id FROM Usr WHERE Name = '{Name}'";
            Conn.Open();
            SqlCommand cmd = new SqlCommand(Query, Conn);
            int res = 0;
            using (SqlDataReader r = cmd.ExecuteReader()) {
                while (r.Read()) {
                    res = r.GetInt32(0);
                }
            }
            Conn.Close();
            return res;
        }
        // get userdata where UID is a match
        public User GetCurrentUser(int UID) {
            string Query = $"SELECT Name, Id FROM Usr WHERE Id = '{UID}'";
            Conn.Open();
            SqlCommand cmd = new SqlCommand(Query, Conn);
            User res = User.Instance;
            using (SqlDataReader r = cmd.ExecuteReader()) {
                while (r.Read()) {
                    res.Name = r.GetString(0);
                    res.Id = r.GetInt32(1);
                }
                Conn.Close();
                return res;
            }
        }
        // get userdata where name and password are a match
        public int CheckUserInfo(string Name, string Password) {
            string Query = $"SELECT Name, Id FROM Usr WHERE Name = '{Name}' AND Password = '{Password}'";
            Conn.Open();
            SqlCommand cmd = new SqlCommand(Query, Conn);
            User res = User.Instance;
            using (SqlDataReader r = cmd.ExecuteReader()) {
                while (r.Read()) {
                    res.Name = r.GetString(0);
                    res.Id = r.GetInt32(1);
                }
                Conn.Close();
                return res.Id;
            }
        }
        // register usercollection to database
        public bool AddCollectionToDB(string Name, string Info) {
            int UID = User.Instance.Id;
            string Query = $"INSERT INTO UserCollection (CollectionName, CollectionInfo, User_ID) VALUES ('{Name}', '{Info}', {UID})";
            try {
                Conn.Open();
                SqlCommand cmd = new SqlCommand(Query, Conn);
                cmd.ExecuteNonQuery();
                Conn.Close();
                return true;
            } catch(Exception e) {
                Conn.Close();
                MessageBox.Show(e.Message);
                return false;
            }
        }

        public List<Product> GetAllProductsFromDB() {
            string Query = "SELECT * FROM Products";
            List<Product> Result = new List<Product>();

            Conn.Open();
            SqlCommand cmd = new SqlCommand(Query, Conn);

            using(SqlDataReader r = cmd.ExecuteReader()) {
                while (r.Read()) {
                    Result.Add(new Product(r.GetString(0), r.GetInt32(1), r.GetInt32(2)));
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
