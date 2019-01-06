namespace PopVinylCollectionManager {
    partial class MainForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.GroupBoxMain = new System.Windows.Forms.GroupBox();
            this.SelectedCollectionInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.ProductCollectionList = new System.Windows.Forms.ListBox();
            this.AddProductToCollectionSubmit = new System.Windows.Forms.Button();
            this.EditCollButton = new System.Windows.Forms.Button();
            this.CollectionListBox = new System.Windows.Forms.ListBox();
            this.GroupBoxProfile = new System.Windows.Forms.GroupBox();
            this.AddSeriesSubmit = new System.Windows.Forms.Button();
            this.BrowseFiguresSubmit = new System.Windows.Forms.Button();
            this.NewProductButton = new System.Windows.Forms.Button();
            this.CreateCollButton = new System.Windows.Forms.Button();
            this.TotalCollectionCount = new System.Windows.Forms.Label();
            this.UserNameLabel = new System.Windows.Forms.Label();
            this.GroupBoxMain.SuspendLayout();
            this.SelectedCollectionInfoGroupBox.SuspendLayout();
            this.GroupBoxProfile.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBoxMain
            // 
            this.GroupBoxMain.Controls.Add(this.SelectedCollectionInfoGroupBox);
            this.GroupBoxMain.Controls.Add(this.CollectionListBox);
            this.GroupBoxMain.Controls.Add(this.GroupBoxProfile);
            this.GroupBoxMain.Location = new System.Drawing.Point(13, 13);
            this.GroupBoxMain.Name = "GroupBoxMain";
            this.GroupBoxMain.Size = new System.Drawing.Size(1559, 836);
            this.GroupBoxMain.TabIndex = 0;
            this.GroupBoxMain.TabStop = false;
            this.GroupBoxMain.Text = "Pop! Vinyl Collection-manager";
            // 
            // SelectedCollectionInfoGroupBox
            // 
            this.SelectedCollectionInfoGroupBox.Controls.Add(this.ProductCollectionList);
            this.SelectedCollectionInfoGroupBox.Controls.Add(this.AddProductToCollectionSubmit);
            this.SelectedCollectionInfoGroupBox.Controls.Add(this.EditCollButton);
            this.SelectedCollectionInfoGroupBox.Location = new System.Drawing.Point(7, 19);
            this.SelectedCollectionInfoGroupBox.Name = "SelectedCollectionInfoGroupBox";
            this.SelectedCollectionInfoGroupBox.Size = new System.Drawing.Size(1127, 811);
            this.SelectedCollectionInfoGroupBox.TabIndex = 2;
            this.SelectedCollectionInfoGroupBox.TabStop = false;
            this.SelectedCollectionInfoGroupBox.Text = "Selected Collection";
            // 
            // ProductCollectionList
            // 
            this.ProductCollectionList.FormattingEnabled = true;
            this.ProductCollectionList.Location = new System.Drawing.Point(6, 19);
            this.ProductCollectionList.Name = "ProductCollectionList";
            this.ProductCollectionList.Size = new System.Drawing.Size(425, 745);
            this.ProductCollectionList.TabIndex = 2;
            // 
            // AddProductToCollectionSubmit
            // 
            this.AddProductToCollectionSubmit.Location = new System.Drawing.Point(6, 782);
            this.AddProductToCollectionSubmit.Name = "AddProductToCollectionSubmit";
            this.AddProductToCollectionSubmit.Size = new System.Drawing.Size(146, 23);
            this.AddProductToCollectionSubmit.TabIndex = 1;
            this.AddProductToCollectionSubmit.Text = "Add figure to collection";
            this.AddProductToCollectionSubmit.UseVisualStyleBackColor = true;
            this.AddProductToCollectionSubmit.Click += new System.EventHandler(this.AddProductToCollectionSubmit_Click);
            // 
            // EditCollButton
            // 
            this.EditCollButton.Location = new System.Drawing.Point(158, 782);
            this.EditCollButton.Name = "EditCollButton";
            this.EditCollButton.Size = new System.Drawing.Size(92, 23);
            this.EditCollButton.TabIndex = 0;
            this.EditCollButton.Text = "Edit collection";
            this.EditCollButton.UseVisualStyleBackColor = true;
            // 
            // CollectionListBox
            // 
            this.CollectionListBox.FormattingEnabled = true;
            this.CollectionListBox.Location = new System.Drawing.Point(1140, 345);
            this.CollectionListBox.Name = "CollectionListBox";
            this.CollectionListBox.Size = new System.Drawing.Size(413, 485);
            this.CollectionListBox.TabIndex = 1;
            this.CollectionListBox.SelectedIndexChanged += new System.EventHandler(this.CollectionListBox_SelectedIndexChanged);
            // 
            // GroupBoxProfile
            // 
            this.GroupBoxProfile.Controls.Add(this.AddSeriesSubmit);
            this.GroupBoxProfile.Controls.Add(this.BrowseFiguresSubmit);
            this.GroupBoxProfile.Controls.Add(this.NewProductButton);
            this.GroupBoxProfile.Controls.Add(this.CreateCollButton);
            this.GroupBoxProfile.Controls.Add(this.TotalCollectionCount);
            this.GroupBoxProfile.Controls.Add(this.UserNameLabel);
            this.GroupBoxProfile.Location = new System.Drawing.Point(1140, 19);
            this.GroupBoxProfile.Name = "GroupBoxProfile";
            this.GroupBoxProfile.Size = new System.Drawing.Size(413, 319);
            this.GroupBoxProfile.TabIndex = 0;
            this.GroupBoxProfile.TabStop = false;
            this.GroupBoxProfile.Text = "Profile";
            // 
            // AddSeriesSubmit
            // 
            this.AddSeriesSubmit.Location = new System.Drawing.Point(123, 290);
            this.AddSeriesSubmit.Name = "AddSeriesSubmit";
            this.AddSeriesSubmit.Size = new System.Drawing.Size(75, 23);
            this.AddSeriesSubmit.TabIndex = 6;
            this.AddSeriesSubmit.Text = "Add series";
            this.AddSeriesSubmit.UseVisualStyleBackColor = true;
            this.AddSeriesSubmit.Click += new System.EventHandler(this.AddSeriesSubmit_Click);
            // 
            // BrowseFiguresSubmit
            // 
            this.BrowseFiguresSubmit.Location = new System.Drawing.Point(204, 290);
            this.BrowseFiguresSubmit.Name = "BrowseFiguresSubmit";
            this.BrowseFiguresSubmit.Size = new System.Drawing.Size(88, 23);
            this.BrowseFiguresSubmit.TabIndex = 5;
            this.BrowseFiguresSubmit.Text = "Browse figures";
            this.BrowseFiguresSubmit.UseVisualStyleBackColor = true;
            this.BrowseFiguresSubmit.Click += new System.EventHandler(this.BrowseFiguresSubmit_Click);
            // 
            // NewProductButton
            // 
            this.NewProductButton.Location = new System.Drawing.Point(54, 290);
            this.NewProductButton.Name = "NewProductButton";
            this.NewProductButton.Size = new System.Drawing.Size(63, 23);
            this.NewProductButton.TabIndex = 4;
            this.NewProductButton.Text = "Add figure";
            this.NewProductButton.UseVisualStyleBackColor = true;
            this.NewProductButton.Click += new System.EventHandler(this.NewProductButton_Click);
            // 
            // CreateCollButton
            // 
            this.CreateCollButton.Location = new System.Drawing.Point(298, 290);
            this.CreateCollButton.Name = "CreateCollButton";
            this.CreateCollButton.Size = new System.Drawing.Size(109, 23);
            this.CreateCollButton.TabIndex = 3;
            this.CreateCollButton.Text = "Create collection";
            this.CreateCollButton.UseVisualStyleBackColor = true;
            this.CreateCollButton.Click += new System.EventHandler(this.CreateCollButton_Click);
            // 
            // TotalCollectionCount
            // 
            this.TotalCollectionCount.AutoSize = true;
            this.TotalCollectionCount.Location = new System.Drawing.Point(12, 56);
            this.TotalCollectionCount.Name = "TotalCollectionCount";
            this.TotalCollectionCount.Size = new System.Drawing.Size(66, 13);
            this.TotalCollectionCount.TabIndex = 1;
            this.TotalCollectionCount.Text = "7 collections";
            // 
            // UserNameLabel
            // 
            this.UserNameLabel.AutoSize = true;
            this.UserNameLabel.Location = new System.Drawing.Point(12, 31);
            this.UserNameLabel.Name = "UserNameLabel";
            this.UserNameLabel.Size = new System.Drawing.Size(29, 13);
            this.UserNameLabel.TabIndex = 0;
            this.UserNameLabel.Text = "User";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1584, 861);
            this.Controls.Add(this.GroupBoxMain);
            this.Name = "MainForm";
            this.Text = "Pop! Vinyl Collection-manager";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.GroupBoxMain.ResumeLayout(false);
            this.SelectedCollectionInfoGroupBox.ResumeLayout(false);
            this.GroupBoxProfile.ResumeLayout(false);
            this.GroupBoxProfile.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GroupBoxMain;
        private System.Windows.Forms.GroupBox SelectedCollectionInfoGroupBox;
        private System.Windows.Forms.ListBox CollectionListBox;
        private System.Windows.Forms.GroupBox GroupBoxProfile;
        private System.Windows.Forms.Label TotalCollectionCount;
        private System.Windows.Forms.Label UserNameLabel;
        private System.Windows.Forms.Button EditCollButton;
        private System.Windows.Forms.Button CreateCollButton;
        private System.Windows.Forms.Button AddProductToCollectionSubmit;
        private System.Windows.Forms.Button NewProductButton;
        private System.Windows.Forms.ListBox ProductCollectionList;
        private System.Windows.Forms.Button BrowseFiguresSubmit;
        private System.Windows.Forms.Button AddSeriesSubmit;
    }
}

