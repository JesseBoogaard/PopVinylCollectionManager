namespace PopVinylCollectionManager {
    partial class Form2 {
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
            this.CreateCollGroupBox = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.NewCollNameInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.NewCollInfoInput = new System.Windows.Forms.TextBox();
            this.NewCollSubmit = new System.Windows.Forms.Button();
            this.CreateCollGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // CreateCollGroupBox
            // 
            this.CreateCollGroupBox.Controls.Add(this.NewCollSubmit);
            this.CreateCollGroupBox.Controls.Add(this.NewCollInfoInput);
            this.CreateCollGroupBox.Controls.Add(this.label2);
            this.CreateCollGroupBox.Controls.Add(this.NewCollNameInput);
            this.CreateCollGroupBox.Controls.Add(this.label1);
            this.CreateCollGroupBox.Location = new System.Drawing.Point(12, 12);
            this.CreateCollGroupBox.Name = "CreateCollGroupBox";
            this.CreateCollGroupBox.Size = new System.Drawing.Size(287, 426);
            this.CreateCollGroupBox.TabIndex = 0;
            this.CreateCollGroupBox.TabStop = false;
            this.CreateCollGroupBox.Text = "Create collection";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Collection name";
            // 
            // NewCollNameInput
            // 
            this.NewCollNameInput.Location = new System.Drawing.Point(23, 54);
            this.NewCollNameInput.Name = "NewCollNameInput";
            this.NewCollNameInput.Size = new System.Drawing.Size(240, 20);
            this.NewCollNameInput.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Collection info";
            // 
            // NewCollInfoInput
            // 
            this.NewCollInfoInput.Location = new System.Drawing.Point(26, 118);
            this.NewCollInfoInput.Multiline = true;
            this.NewCollInfoInput.Name = "NewCollInfoInput";
            this.NewCollInfoInput.Size = new System.Drawing.Size(237, 108);
            this.NewCollInfoInput.TabIndex = 3;
            // 
            // NewCollSubmit
            // 
            this.NewCollSubmit.Location = new System.Drawing.Point(131, 247);
            this.NewCollSubmit.Name = "NewCollSubmit";
            this.NewCollSubmit.Size = new System.Drawing.Size(131, 23);
            this.NewCollSubmit.TabIndex = 4;
            this.NewCollSubmit.Text = "Create new collection";
            this.NewCollSubmit.UseVisualStyleBackColor = true;
            this.NewCollSubmit.Click += new System.EventHandler(this.NewCollSubmit_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 450);
            this.Controls.Add(this.CreateCollGroupBox);
            this.Name = "Form2";
            this.Text = "Form2";
            this.CreateCollGroupBox.ResumeLayout(false);
            this.CreateCollGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox CreateCollGroupBox;
        private System.Windows.Forms.Button NewCollSubmit;
        private System.Windows.Forms.TextBox NewCollInfoInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NewCollNameInput;
        private System.Windows.Forms.Label label1;
    }
}