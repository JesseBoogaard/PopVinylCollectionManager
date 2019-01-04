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
    public partial class MainForm : Form {
        public MainForm() {
            InitializeComponent();
        }


        private void CreateCollButton_Click(object sender, EventArgs e) {
            OpenCreateCollForm();
        }

        private void OpenCreateCollForm() {
            RegisterCollectionForm f = new RegisterCollectionForm();
            f.Show();
        }

        public void UpdateCollectionListBox() {
        }

        private void Form1_Load(object sender, EventArgs e) {
            UserNameLabel.Text = User.Instance.Name;
        }
    }
}
