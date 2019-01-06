namespace PopVinylCollectionManager {
    partial class NewProductForm {
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
            this.AvailableSeriesSelect = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ProductNumberInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ProductNameInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.NewProductSubmit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.AvailableSeriesSelect);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.ProductNumberInput);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.ProductNameInput);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.NewProductSubmit);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(338, 279);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Register new figure";
            // 
            // AvailableSeriesSelect
            // 
            this.AvailableSeriesSelect.FormattingEnabled = true;
            this.AvailableSeriesSelect.Location = new System.Drawing.Point(7, 164);
            this.AvailableSeriesSelect.Name = "AvailableSeriesSelect";
            this.AvailableSeriesSelect.Size = new System.Drawing.Size(121, 21);
            this.AvailableSeriesSelect.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Series";
            // 
            // ProductNumberInput
            // 
            this.ProductNumberInput.Location = new System.Drawing.Point(7, 104);
            this.ProductNumberInput.Name = "ProductNumberInput";
            this.ProductNumberInput.Size = new System.Drawing.Size(325, 20);
            this.ProductNumberInput.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Figure Number";
            // 
            // ProductNameInput
            // 
            this.ProductNameInput.Location = new System.Drawing.Point(7, 47);
            this.ProductNameInput.Name = "ProductNameInput";
            this.ProductNameInput.Size = new System.Drawing.Size(325, 20);
            this.ProductNameInput.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Figure Name";
            // 
            // NewProductSubmit
            // 
            this.NewProductSubmit.Location = new System.Drawing.Point(257, 250);
            this.NewProductSubmit.Name = "NewProductSubmit";
            this.NewProductSubmit.Size = new System.Drawing.Size(75, 23);
            this.NewProductSubmit.TabIndex = 0;
            this.NewProductSubmit.Text = "Add figure";
            this.NewProductSubmit.UseVisualStyleBackColor = true;
            this.NewProductSubmit.Click += new System.EventHandler(this.NewProductSubmit_Click);
            // 
            // NewProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 304);
            this.Controls.Add(this.groupBox1);
            this.Name = "NewProductForm";
            this.Text = "New Figure";
            this.Load += new System.EventHandler(this.NewProductForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox ProductNumberInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ProductNameInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button NewProductSubmit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox AvailableSeriesSelect;
    }
}