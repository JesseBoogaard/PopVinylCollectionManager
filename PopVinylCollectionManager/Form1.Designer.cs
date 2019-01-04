namespace PopVinylCollectionManager {
    partial class Form1 {
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
            this.GroupBoxProfile = new System.Windows.Forms.GroupBox();
            this.UserNameLabel = new System.Windows.Forms.Label();
            this.TotalCollectionCount = new System.Windows.Forms.Label();
            this.TotalFigureCount = new System.Windows.Forms.Label();
            this.CollectionListBox = new System.Windows.Forms.ListBox();
            this.SelectedCollectionInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.GroupBoxMain.SuspendLayout();
            this.GroupBoxProfile.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBoxMain
            // 
            this.GroupBoxMain.Controls.Add(this.groupBox1);
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
            // GroupBoxProfile
            // 
            this.GroupBoxProfile.Controls.Add(this.TotalFigureCount);
            this.GroupBoxProfile.Controls.Add(this.TotalCollectionCount);
            this.GroupBoxProfile.Controls.Add(this.UserNameLabel);
            this.GroupBoxProfile.Location = new System.Drawing.Point(1237, 19);
            this.GroupBoxProfile.Name = "GroupBoxProfile";
            this.GroupBoxProfile.Size = new System.Drawing.Size(316, 319);
            this.GroupBoxProfile.TabIndex = 0;
            this.GroupBoxProfile.TabStop = false;
            this.GroupBoxProfile.Text = "Profile";
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
            // TotalCollectionCount
            // 
            this.TotalCollectionCount.AutoSize = true;
            this.TotalCollectionCount.Location = new System.Drawing.Point(12, 56);
            this.TotalCollectionCount.Name = "TotalCollectionCount";
            this.TotalCollectionCount.Size = new System.Drawing.Size(66, 13);
            this.TotalCollectionCount.TabIndex = 1;
            this.TotalCollectionCount.Text = "7 collections";
            // 
            // TotalFigureCount
            // 
            this.TotalFigureCount.AutoSize = true;
            this.TotalFigureCount.Location = new System.Drawing.Point(12, 81);
            this.TotalFigureCount.Name = "TotalFigureCount";
            this.TotalFigureCount.Size = new System.Drawing.Size(59, 13);
            this.TotalFigureCount.TabIndex = 2;
            this.TotalFigureCount.Text = "500 figures";
            // 
            // CollectionListBox
            // 
            this.CollectionListBox.FormattingEnabled = true;
            this.CollectionListBox.Location = new System.Drawing.Point(1237, 345);
            this.CollectionListBox.Name = "CollectionListBox";
            this.CollectionListBox.Size = new System.Drawing.Size(316, 485);
            this.CollectionListBox.TabIndex = 1;
            // 
            // SelectedCollectionInfoGroupBox
            // 
            this.SelectedCollectionInfoGroupBox.Location = new System.Drawing.Point(7, 19);
            this.SelectedCollectionInfoGroupBox.Name = "SelectedCollectionInfoGroupBox";
            this.SelectedCollectionInfoGroupBox.Size = new System.Drawing.Size(1224, 319);
            this.SelectedCollectionInfoGroupBox.TabIndex = 2;
            this.SelectedCollectionInfoGroupBox.TabStop = false;
            this.SelectedCollectionInfoGroupBox.Text = "Selected Collection";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(7, 345);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1223, 484);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Actions";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1584, 861);
            this.Controls.Add(this.GroupBoxMain);
            this.Name = "Form1";
            this.Text = "Pop! Vinyl Collection-manager";
            this.GroupBoxMain.ResumeLayout(false);
            this.GroupBoxProfile.ResumeLayout(false);
            this.GroupBoxProfile.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GroupBoxMain;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox SelectedCollectionInfoGroupBox;
        private System.Windows.Forms.ListBox CollectionListBox;
        private System.Windows.Forms.GroupBox GroupBoxProfile;
        private System.Windows.Forms.Label TotalFigureCount;
        private System.Windows.Forms.Label TotalCollectionCount;
        private System.Windows.Forms.Label UserNameLabel;
    }
}

