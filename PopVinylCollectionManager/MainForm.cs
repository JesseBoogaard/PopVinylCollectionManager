﻿using System;
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
        private Database _DB = Database.Instance;
        public MainForm() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            UpdateCollectionListBox();
            UserNameLabel.Text = User.Instance.Name;
            TotalCollectionCount.Text = User.Instance.CollCount.ToString();
        }

        private void CreateCollButton_Click(object sender, EventArgs e) {
            OpenCreateCollForm();
        }

        private void OpenCreateCollForm() {
            RegisterCollectionForm f = new RegisterCollectionForm(this);
            f.Show();
        }

        private void OpenCreateProductForm() {
            NewProductForm f = new NewProductForm(this);
            f.Show();
        }

        public void UpdateCollectionListBox() {
            CollectionListBox.Items.Clear();
            foreach (Collection c in Database.Instance.GetUserCollections(User.Instance.Id)) {
                User.Instance.AddCollectionToUser(c);
                CollectionListBox.Items.Add(c);
            };
        }

        private void NewProductButton_Click(object sender, EventArgs e) {
            OpenCreateProductForm();
        }

        private void CollectionListBox_SelectedIndexChanged(object sender, EventArgs e) {
            object obj = CollectionListBox.SelectedItem;
            Collection Coll = (Collection)obj;
            UpdateProductCollectionList(Coll.Name);
        }

        private void UpdateProductCollectionList(string CollectionName) {
            ProductCollectionList.Items.Clear();
            foreach(Product p in _DB.AddProductsToSelectedCollection(CollectionName)) {
                ProductCollectionList.Items.Add(p);
            }
        }

        private void AddProductToCollectionSubmit_Click(object sender, EventArgs e) {
            AddToCollectionForm a = new AddToCollectionForm(this);
            a.Show();
        }
    }
}
