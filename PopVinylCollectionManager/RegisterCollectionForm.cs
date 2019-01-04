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
        public RegisterCollectionForm() {
            InitializeComponent();
        }

        private void NewCollSubmit_Click(object sender, EventArgs e) {
            NewCollectionRegistered(CreateNewCollection(NewCollNameInput.Text, NewCollInfoInput.Text));
        }

        private bool CreateNewCollection(string Name, string Info) {
            _DB.AddCollectionToDB(Name, Info);
            return true;
        }

        private bool NewCollectionRegistered(bool a) {
            return true;
        }
    }
}
