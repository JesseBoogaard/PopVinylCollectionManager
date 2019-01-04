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
    public partial class CreateUserForm : Form {
        private Database _DB = Database.Instance;
        public CreateUserForm() {
            InitializeComponent();
        }

        private void NewUserSubmit_Click(object sender, EventArgs e) {
            RegisterNewUser(NewUserNameInput.Text, NewPasswordInput.Text);
        }

        private void RegisterNewUser(string Name, string Password) {
            int UID = _DB.AddUserToDB(Name, Password);
            SetCurrentUser(UID);
            MainForm a = new MainForm();
            a.Show();
            this.Hide();
        }
        private void SetCurrentUser(int UID) {
            _DB.GetCurrentUser(UID);

        }
    }
}
