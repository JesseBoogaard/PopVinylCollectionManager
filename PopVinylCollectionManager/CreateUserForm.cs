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
            if (CheckString(Name) && CheckString(Password) && SetCurrentUser(_DB.AddUserToDB(Name, Password))) {
                MainForm a = new MainForm();
                a.Show();
                this.Hide();
            }
        }
        private bool SetCurrentUser(int UID) {
            if(UID != 0) {
                _DB.GetCurrentUser(UID);
                return true;
            } else {
                MessageBox.Show("signin failed, try again.");
                return false;
            }
        }

        private void UserLoginSubmit_Click(object sender, EventArgs e) {
            LoginUser(UserNameInput.Text, UserPasswordInput.Text);
        }

        private void LoginUser(string Name, string Password) {
            if (SetCurrentUser(_DB.CheckUserInfo(Name, Password))) {
                MainForm a = new MainForm();
                a.Show();
                this.Hide();
            };
        }
        private bool CheckString(string s) {
            if (!s.Contains("'")) {
                return true;
            } else {
                MessageBox.Show("Your name contains an illegal character (')");
                return false;
            };
        }
    }
}
