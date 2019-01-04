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
            this.EditCollButton = new System.Windows.Forms.Button();
            this.CollectionListBox = new System.Windows.Forms.ListBox();
            this.GroupBoxProfile = new System.Windows.Forms.GroupBox();
            this.CreateCollButton = new System.Windows.Forms.Button();
            this.TotalFigureCount = new System.Windows.Forms.Label();
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
            this.SelectedCollectionInfoGroupBox.Controls.Add(this.EditCollButton);
            this.SelectedCollectionInfoGroupBox.Location = new System.Drawing.Point(7, 19);
            this.SelectedCollectionInfoGroupBox.Name = "SelectedCollectionInfoGroupBox";
            this.SelectedCollectionInfoGroupBox.Size = new System.Drawing.Size(1224, 319);
            this.SelectedCollectionInfoGroupBox.TabIndex = 2;
            this.SelectedCollectionInfoGroupBox.TabStop = false;
            this.SelectedCollectionInfoGroupBox.Text = "Selected Collection";
            // 
            // EditCollButton
            // 
            this.EditCollButton.Location = new System.Drawing.Point(1126, 290);
            this.EditCollButton.Name = "EditCollButton";
            this.EditCollButton.Size = new System.Drawing.Size(92, 23);
            this.EditCollButton.TabIndex = 0;
            this.EditCollButton.Text = "Edit collection";
            this.EditCollButton.UseVisualStyleBackColor = true;
            // 
            // CollectionListBox
            // 
            this.CollectionListBox.FormattingEnabled = true;
            this.CollectionListBox.Location = new System.Drawing.Point(1237, 345);
            this.CollectionListBox.Name = "CollectionListBox";
            this.CollectionListBox.Size = new System.Drawing.Size(316, 485);
            this.CollectionListBox.TabIndex = 1;
            // 
            // GroupBoxProfile
            // 
            this.GroupBoxProfile.Controls.Add(this.CreateCollButton);
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
            // CreateCollButton
            // 
            this.CreateCollButton.Location = new System.Drawing.Point(186, 289);
            this.CreateCollButton.Name = "CreateCollButton";
            this.CreateCollButton.Size = new System.Drawing.Size(124, 23);
            this.CreateCollButton.TabIndex = 3;
            this.CreateCollButton.Text = "Create new collection";
            this.CreateCollButton.UseVisualStyleBackColor = true;
            this.CreateCollButton.Click += new System.EventHandler(this.CreateCollButton_Click);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1584, 861);
            this.Controls.Add(this.GroupBoxMain);
            this.Name = "Form1";
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
        private System.Windows.Forms.Label TotalFigureCount;
        private System.Windows.Forms.Label TotalCollectionCount;
        private System.Windows.Forms.Label UserNameLabel;
        private System.Windows.Forms.Button EditCollButton;
        private System.Windows.Forms.Button CreateCollButton;
    }
}

