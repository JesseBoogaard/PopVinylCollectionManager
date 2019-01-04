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

        private bool RegisterNewUser(string Name, string Password) {
            _DB.AddUserToDB(Name, Password);
            return true;
        }
    }
}
