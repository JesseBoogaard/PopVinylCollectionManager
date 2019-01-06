namespace PopVinylCollectionManager {
    partial class ProductCatalogForm {
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
            this.AvailableProductsListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SelectSeriesFilter = new System.Windows.Forms.ComboBox();
            this.ProductOverViewBox = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ProductNameLabel = new System.Windows.Forms.Label();
            this.ProductNumberLabel = new System.Windows.Forms.Label();
            this.ProductSeriesLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.ProductOverViewBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SelectSeriesFilter);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.AvailableProductsListBox);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(373, 719);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Available Figures";
            // 
            // AvailableProductsListBox
            // 
            this.AvailableProductsListBox.FormattingEnabled = true;
            this.AvailableProductsListBox.Location = new System.Drawing.Point(7, 20);
            this.AvailableProductsListBox.Name = "AvailableProductsListBox";
            this.AvailableProductsListBox.Size = new System.Drawing.Size(360, 602);
            this.AvailableProductsListBox.TabIndex = 0;
            this.AvailableProductsListBox.SelectedIndexChanged += new System.EventHandler(this.AvailableProductsListBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 638);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select series";
            // 
            // SelectSeriesFilter
            // 
            this.SelectSeriesFilter.FormattingEnabled = true;
            this.SelectSeriesFilter.Location = new System.Drawing.Point(10, 655);
            this.SelectSeriesFilter.Name = "SelectSeriesFilter";
            this.SelectSeriesFilter.Size = new System.Drawing.Size(357, 21);
            this.SelectSeriesFilter.TabIndex = 2;
            // 
            // ProductOverViewBox
            // 
            this.ProductOverViewBox.Controls.Add(this.ProductSeriesLabel);
            this.ProductOverViewBox.Controls.Add(this.ProductNumberLabel);
            this.ProductOverViewBox.Controls.Add(this.ProductNameLabel);
            this.ProductOverViewBox.Controls.Add(this.label5);
            this.ProductOverViewBox.Controls.Add(this.label4);
            this.ProductOverViewBox.Controls.Add(this.label3);
            this.ProductOverViewBox.Controls.Add(this.label2);
            this.ProductOverViewBox.Controls.Add(this.pictureBox1);
            this.ProductOverViewBox.Location = new System.Drawing.Point(393, 13);
            this.ProductOverViewBox.Name = "ProductOverViewBox";
            this.ProductOverViewBox.Size = new System.Drawing.Size(464, 719);
            this.ProductOverViewBox.TabIndex = 1;
            this.ProductOverViewBox.TabStop = false;
            this.ProductOverViewBox.Text = "Figure Overview";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(7, 134);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(451, 579);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Image";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Product Number:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Series:";
            // 
            // ProductNameLabel
            // 
            this.ProductNameLabel.AutoSize = true;
            this.ProductNameLabel.Location = new System.Drawing.Point(135, 32);
            this.ProductNameLabel.Name = "ProductNameLabel";
            this.ProductNameLabel.Size = new System.Drawing.Size(0, 13);
            this.ProductNameLabel.TabIndex = 5;
            // 
            // ProductNumberLabel
            // 
            this.ProductNumberLabel.AutoSize = true;
            this.ProductNumberLabel.Location = new System.Drawing.Point(135, 60);
            this.ProductNumberLabel.Name = "ProductNumberLabel";
            this.ProductNumberLabel.Size = new System.Drawing.Size(0, 13);
            this.ProductNumberLabel.TabIndex = 6;
            // 
            // ProductSeriesLabel
            // 
            this.ProductSeriesLabel.AutoSize = true;
            this.ProductSeriesLabel.Location = new System.Drawing.Point(135, 91);
            this.ProductSeriesLabel.Name = "ProductSeriesLabel";
            this.ProductSeriesLabel.Size = new System.Drawing.Size(0, 13);
            this.ProductSeriesLabel.TabIndex = 7;
            // 
            // ProductCatalogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 744);
            this.Controls.Add(this.ProductOverViewBox);
            this.Controls.Add(this.groupBox1);
            this.Name = "ProductCatalogForm";
            this.Text = "ProductCatalogForm";
            this.Load += new System.EventHandler(this.ProductCatalogForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ProductOverViewBox.ResumeLayout(false);
            this.ProductOverViewBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox SelectSeriesFilter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox AvailableProductsListBox;
        private System.Windows.Forms.GroupBox ProductOverViewBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label ProductSeriesLabel;
        private System.Windows.Forms.Label ProductNumberLabel;
        private System.Windows.Forms.Label ProductNameLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}