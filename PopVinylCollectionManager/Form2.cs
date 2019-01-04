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
    public partial class Form2 : Form {
        private User _Usr;
        private Form1 f;
        public Form2(User Usr, Form1 F) {
            _Usr = Usr;
            f = F;
            InitializeComponent();
        }

        private void NewCollSubmit_Click(object sender, EventArgs e) {
            NewCollectionRegistered(CreateNewCollection(NewCollNameInput.Text, NewCollInfoInput.Text));
        }

        private bool CreateNewCollection(string Name, string Info) {
            _Usr.AddCollectionToUser(new Collection(Name, Info));
            return true;
        }

        private bool NewCollectionRegistered(bool a) {
            if (a) {
                f.UpdateCollectionListBox();
                this.Close();
                return true;
            } else {
                return false;
            }
        }
    }
}
