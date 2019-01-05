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
        public NewProductForm(MainForm a) {
            _a = a;
            InitializeComponent();
        }

        private void NewProductForm_Load(object sender, EventArgs e) {
            GetAvailableSeries();
        }

        private void GetAvailableSeries() {
            foreach (string s in Database.Instance.GetAllSeries()) {
                AvailableSeriesSelect.Items.Add(s);  
            };
        }
    }
}
