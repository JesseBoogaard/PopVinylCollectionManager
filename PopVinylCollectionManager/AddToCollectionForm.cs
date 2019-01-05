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
    public partial class AddToCollectionForm : Form {
        private MainForm _M;
        public AddToCollectionForm(MainForm m) {
            _M = m;
            InitializeComponent();
        }
    }
}
