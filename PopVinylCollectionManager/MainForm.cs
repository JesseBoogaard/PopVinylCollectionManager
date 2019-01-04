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
        public User Usr = new User("Jesse", 1);
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
            CollectionListBox.Items.Clear();
            foreach(Collection c in Usr.GetAllUserCollections) {
                CollectionListBox.Items.Add(c);
            }
        }

        private void Form1_Load(object sender, EventArgs e) {
            CreateUserForm a = new CreateUserForm();
            a.Show();
        }
    }
}
