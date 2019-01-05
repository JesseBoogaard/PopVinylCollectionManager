using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PopVinylCollectionManager {
    public partial class NewProductForm : Form {
        private MainForm _a;
        Database _DB = Database.Instance;
        public NewProductForm(MainForm a) {
            _a = a;
            
            InitializeComponent();
        }

        private void NewProductForm_Load(object sender, EventArgs e) {
            GetAvailableSeries();
        }


        private void GetAvailableSeries() {
            foreach (Series s in _DB.GetAllSeries()) {
                AvailableSeriesSelect.Items.Add(s);  
            };
        }

        private void NewProductSubmit_Click(object sender, EventArgs e) {
            if (CheckString(ProductNameInput.Text) && CheckString(ProductNumberInput.Text)){
                CreateNewProduct(ProductNameInput.Text, Convert.ToInt32(ProductNumberInput.Text), AvailableSeriesSelect.SelectedItem);
            }
        }

        private bool CheckString(string s) {
            if (!s.Contains("'")) {
                return true;
            } else {
                MessageBox.Show("Your Product name contains an illegal character (')");
                return false;
            };
        }

        private bool CreateNewProduct(string Name, int ProdNo, object s) {
            object obj = s;
            Series Series = (Series)obj;
            if(_DB.AddProductToDB(Name, ProdNo, Series.Id)) {
                this.Close();
            }
            return true;
        }
    }
}
