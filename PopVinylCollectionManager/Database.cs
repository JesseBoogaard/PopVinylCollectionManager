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

        // START Methods for user account

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

        // END Methods for user account
        // START Methods for collections

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

        // get all usercollections based on user ID
        public List<Collection> GetUserCollections(int UID) {
            string Query = $"SELECT CollectionName, CollectionInfo FROM UserCollection WHERE User_ID = {UID}";
            List<Collection> Result = new List<Collection>();
            Conn.Open();
            SqlCommand cmd = new SqlCommand(Query, Conn);

            using (SqlDataReader r = cmd.ExecuteReader()) {
                while (r.Read()) {
                    Result.Add(new Collection(r.GetString(0), r.GetString(1)));
                }
            }
            Conn.Close();
            return Result;
        }

        // Fill selected local collection object with associated products
        public List<Product> AddProductsToSelectedCollection(string CollectionName) {
            List<Product> Result = new List<Product>();
            string Query = $"SELECT Product.ProductName AS 'Product Name', Product.ProductNo AS 'Product Number', Series.SeriesName AS 'Series' FROM ((ProductCollection " +
                "INNER JOIN Product ON ProductCollection.Product_ID = Product.Id) " +
                "INNER JOIN Series ON Product.SeriesID = Series.Id) " +
                $"WHERE ProductCollection.Collection_ID = (SELECT Id FROM UserCollection WHERE CollectionName = '{CollectionName}') " +
                "GROUP BY Product.ProductName, Product.ProductNo, Series.SeriesName " +
                "ORDER BY Product.ProductName ASC";
            Conn.Open();
            SqlCommand cmd = new SqlCommand(Query, Conn);

            using (SqlDataReader r = cmd.ExecuteReader()) {
                while (r.Read()) {
                    Result.Add(new Product(r.GetString(0), r.GetInt32(1), r.GetString(2)));
                }
            }
            Conn.Close();
            return Result;
        }

        // Add new product to selected collection
        public bool AddProductToSelectedCollection(string ProductName, string CollectionName) {
            string Query = $"IF NOT EXISTS(SELECT * FROM ProductCollection " +
            $"WHERE Collection_ID = (SELECT Id FROM UserCollection WHERE CollectionName = '{CollectionName}') " +
            "AND Product_ID = (SELECT Id FROM Product WHERE ProductName = '{ProductName}')) " +
            $"INSERT INTO ProductCollection (Product_ID, Collection_ID) " +
            $"VALUES ((SELECT Id FROM Product WHERE ProductName = '{ProductName}'), (SELECT Id FROM UserCollection WHERE CollectionName = '{CollectionName}'))";
            try {
                Conn.Open();
                SqlCommand cmd = new SqlCommand(Query, Conn);
                cmd.ExecuteNonQuery();
                Conn.Close();
                return true;
            } catch (Exception e) {
                Conn.Close();
                MessageBox.Show(e.Message);
                return false;
            }
        }

        public int GetUserCollectionCount(int UID) {
            int result = 0;
            string Query = $"SELECT COUNT(UserCollection.Id) FROM UserCollection WHERE User_ID = '{UID}'";
            Conn.Open();
            SqlCommand cmd = new SqlCommand(Query, Conn);
            using(SqlDataReader r = cmd.ExecuteReader()) {
                while (r.Read()) {
                    result = r.GetInt32(0);
                }
                Conn.Close();
                return result;
            }
        }

        // END Methods for collections
        // START Methods for products

        public bool AddProductToDB(string Name, int ProdNo, int Series) {
            string Query = $"IF NOT EXISTS (SELECT * FROM Product WHERE ProductNo = {ProdNo})" +
                "INSERT INTO Product (ProductName, ProductNo, SeriesID)" +
                $"VALUES ('{Name}', {ProdNo}, {Series})";
            try {
                Conn.Open();
                SqlCommand cmd = new SqlCommand(Query, Conn);
                cmd.ExecuteNonQuery();
                Conn.Close();
                return true;
            } catch (Exception e) {
                Conn.Close();
                MessageBox.Show(e.Message);
                return false;
            }
        }

        // remove product from database based on name
        public bool RemoveProductFromDB(/*product name,*/) {
            return true;
        }

        // get all products registered in the database
        public List<Product> GetAllProductsFromDB() {
            string Query =
                "SELECT Product.ProductName AS 'Name', Product.ProductNo AS 'Number', Series.SeriesName AS 'Series' FROM (Product " +
                "INNER JOIN Series ON Product.SeriesID = Series.Id) " +
                "GROUP BY Product.ProductName, Product.ProductNo, Series.SeriesName " +
                "ORDER BY Series ASC";
            List<Product> Result = new List<Product>();
            Conn.Open();
            SqlCommand cmd = new SqlCommand(Query, Conn);

            using (SqlDataReader r = cmd.ExecuteReader()) {
                while (r.Read()) {
                    Result.Add(new Product(r.GetString(0), r.GetInt32(1), r.GetString(2)));
                }
            }
            Conn.Close();
            return Result;
        }

        // update product info
        public bool UpdateProductInDB(/*product name, changes*/) {
            return true;
        }

        public int GetTotalProductsFromUser(int UID) {
            int result = 0;
            string Query = $"SELECT COUNT(Product_ID) FROM UserCollection JOIN ProductCollection ON UserCollection.Id = ProductCollection.Collection_ID WHERE UserCollection.User_ID = {UID}";
            Conn.Open();
            SqlCommand cmd = new SqlCommand(Query, Conn);
            using (SqlDataReader r = cmd.ExecuteReader()) {
                while (r.Read()) {
                    result = r.GetInt32(0);
                }
                Conn.Close();
                return result;
            }

        }

        // END Methods for products
        // START Methods for series

        public bool AddNewSeriesToDB(string SeriesName) {
            string Query = $"IF NOT EXISTS(SELECT * FROM Series WHERE SeriesName = '{SeriesName}') " + 
                $"INSERT INTO Series (SeriesName) VALUES ('{SeriesName}')";
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
            };
        }

        public List<Series> GetAllSeries() {
            string Query = "SELECT SeriesName, Id FROM Series";
            List<Series> Result = new List<Series>();
            Conn.Open();
            SqlCommand cmd = new SqlCommand(Query, Conn);
            using (SqlDataReader r = cmd.ExecuteReader()) {
                while (r.Read()) {
                    Result.Add(new Series(r.GetString(0), r.GetInt32(1)));
                }
            }
            Conn.Close();
            return Result;
        }

        // END Methods for series
    }
}
