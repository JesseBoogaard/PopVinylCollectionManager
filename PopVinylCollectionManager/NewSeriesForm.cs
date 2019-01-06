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
    public partial class NewSeriesForm : Form {
        public NewSeriesForm() {
            InitializeComponent();
        }

        private void Submit_Click(object sender, EventArgs e) {
            AddNewSeries(SeriesNameInput.Text);
        }

        private void AddNewSeries(string SeriesName) {
            if (Database.Instance.AddNewSeriesToDB(SeriesName)) {
                this.Close();
            } else {
                MessageBox.Show("Something went wrong adding this series, does it exist already?");
            }
        }
    }
}
