namespace PopVinylCollectionManager {
    partial class AddToCollectionForm {
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AllProductsList = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Submit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Submit);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.AllProductsList);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(323, 105);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add new figure";
            // 
            // AllProductsList
            // 
            this.AllProductsList.FormattingEnabled = true;
            this.AllProductsList.Location = new System.Drawing.Point(7, 42);
            this.AllProductsList.Name = "AllProductsList";
            this.AllProductsList.Size = new System.Drawing.Size(310, 21);
            this.AllProductsList.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Available figures";
            // 
            // Submit
            // 
            this.Submit.Location = new System.Drawing.Point(221, 70);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(95, 23);
            this.Submit.TabIndex = 2;
            this.Submit.Text = "Add to collection";
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // AddToCollectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 130);
            this.Controls.Add(this.groupBox1);
            this.Name = "AddToCollectionForm";
            this.Text = "AddToCollectionForm";
            this.Load += new System.EventHandler(this.AddToCollectionForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox AllProductsList;
    }
}