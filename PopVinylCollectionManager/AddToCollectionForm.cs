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
    public partial class AddToCollectionForm : Form {
        private string _CollectionName;
        private MainForm _MF;
        public AddToCollectionForm(string CollectionName, MainForm MF) {
            _MF = MF;
            _CollectionName = CollectionName;
            InitializeComponent();
        }

        private void AddToCollectionForm_Load(object sender, EventArgs e) {
            AddAllProducts();
        }

        private void AddAllProducts() {
            AllProductsList.Items.Clear();
            foreach(Product p in Database.Instance.GetAllProductsFromDB()) {
                AllProductsList.Items.Add(p);
            }
        }

        private void Submit_Click(object sender, EventArgs e) {
            object obj = AllProductsList.SelectedItem;
            Product p = (Product)obj;
            AddSelectedProductToCollection(p.GetName);
        }

        private void AddSelectedProductToCollection(string ProductName) {
            if (Database.Instance.AddProductToSelectedCollection(ProductName, _CollectionName)) {
                _MF.UpdateProductCollectionList(_CollectionName);
                _MF.UpdateTotalFigureCount();
                this.Close();
            } else {
                MessageBox.Show("Something went wrong adding this product to your collection. Please try again later.");
            };
        }
    }
}
