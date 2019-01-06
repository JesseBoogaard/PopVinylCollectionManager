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
    public partial class ProductCatalogForm : Form {
        public ProductCatalogForm() {
            InitializeComponent();
        }

        private void ProductCatalogForm_Load(object sender, EventArgs e) {
            UpdateAvailableProductsListBox();
        }

        private void UpdateAvailableProductsListBox() {
            AvailableProductsListBox.Items.Clear();
            foreach(Product p in Database.Instance.GetAllProductsFromDB()) {
                AvailableProductsListBox.Items.Add(p);
            }
        }

        private void AvailableProductsListBox_SelectedIndexChanged(object sender, EventArgs e) {
            object obj = AvailableProductsListBox.SelectedItem;
            Product p = (Product)obj;
            UpdateProductOverview(p);
        }

        private void UpdateProductOverview(Product p) {
            ProductNameLabel.Text = p.GetName;
            ProductNumberLabel.Text = Convert.ToString(p.GetProdNo);
            ProductSeriesLabel.Text = p.GetSeries;
        }
    }
}
