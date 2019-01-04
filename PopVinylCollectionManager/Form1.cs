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
    public partial class Form1 : Form {
        public User Usr = new User("Jesse", 1);
        public Form1() {
            InitializeComponent();
        }


        private void CreateCollButton_Click(object sender, EventArgs e) {
            OpenCreateCollForm();
        }

        private void OpenCreateCollForm() {
            Form2 f = new Form2(Usr, this);
            f.Show();
        }

        public void UpdateCollectionListBox() {
            CollectionListBox.Items.Clear();
            foreach(Collection c in Usr.GetAllUserCollections) {
                CollectionListBox.Items.Add(c);
            }
        }

    }
}
