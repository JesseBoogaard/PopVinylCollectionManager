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
    public partial class RegisterCollectionForm : Form {
        Database _DB = Database.Instance;
        MainForm _a;
        public RegisterCollectionForm(MainForm a) {
            _a = a;
            InitializeComponent();
        }

        private void NewCollSubmit_Click(object sender, EventArgs e) {
            CreateNewCollection(NewCollNameInput.Text, NewCollInfoInput.Text);
        }

        private void CreateNewCollection(string Name, string Info) {
            if (_DB.AddCollectionToDB(Name, Info)) {
                User.Instance.AddCollectionToUser(new Collection(Name, Info));
                _a.UpdateCollectionListBox();
                _a.UpdateCollectionCount();
                this.Close();
            } else {
                MessageBox.Show("Something went wrong adding your collection, please try again later.");
            }
        }
    }
}
