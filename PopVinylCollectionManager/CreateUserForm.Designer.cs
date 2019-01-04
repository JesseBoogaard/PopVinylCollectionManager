namespace PopVinylCollectionManager {
    partial class CreateUserForm {
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
            this.NewUserSubmit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NewUserNameInput = new System.Windows.Forms.TextBox();
            this.NewPasswordInput = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.UserPasswordInput = new System.Windows.Forms.TextBox();
            this.UserNameInput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.UserLoginSubmit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.NewPasswordInput);
            this.groupBox1.Controls.Add(this.NewUserNameInput);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.NewUserSubmit);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(294, 207);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sign up";
            // 
            // NewUserSubmit
            // 
            this.NewUserSubmit.Location = new System.Drawing.Point(213, 178);
            this.NewUserSubmit.Name = "NewUserSubmit";
            this.NewUserSubmit.Size = new System.Drawing.Size(75, 23);
            this.NewUserSubmit.TabIndex = 0;
            this.NewUserSubmit.Text = "Register";
            this.NewUserSubmit.UseVisualStyleBackColor = true;
            this.NewUserSubmit.Click += new System.EventHandler(this.NewUserSubmit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password";
            // 
            // NewUserNameInput
            // 
            this.NewUserNameInput.Location = new System.Drawing.Point(10, 47);
            this.NewUserNameInput.Name = "NewUserNameInput";
            this.NewUserNameInput.Size = new System.Drawing.Size(278, 20);
            this.NewUserNameInput.TabIndex = 3;
            // 
            // NewPasswordInput
            // 
            this.NewPasswordInput.Location = new System.Drawing.Point(13, 120);
            this.NewPasswordInput.Name = "NewPasswordInput";
            this.NewPasswordInput.PasswordChar = '*';
            this.NewPasswordInput.Size = new System.Drawing.Size(275, 20);
            this.NewPasswordInput.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.UserPasswordInput);
            this.groupBox2.Controls.Add(this.UserNameInput);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.UserLoginSubmit);
            this.groupBox2.Location = new System.Drawing.Point(13, 231);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(294, 207);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Login";
            // 
            // UserPasswordInput
            // 
            this.UserPasswordInput.Location = new System.Drawing.Point(13, 120);
            this.UserPasswordInput.Name = "UserPasswordInput";
            this.UserPasswordInput.PasswordChar = '*';
            this.UserPasswordInput.Size = new System.Drawing.Size(275, 20);
            this.UserPasswordInput.TabIndex = 4;
            // 
            // UserNameInput
            // 
            this.UserNameInput.Location = new System.Drawing.Point(10, 47);
            this.UserNameInput.Name = "UserNameInput";
            this.UserNameInput.Size = new System.Drawing.Size(278, 20);
            this.UserNameInput.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Username";
            // 
            // UserLoginSubmit
            // 
            this.UserLoginSubmit.Location = new System.Drawing.Point(213, 178);
            this.UserLoginSubmit.Name = "UserLoginSubmit";
            this.UserLoginSubmit.Size = new System.Drawing.Size(75, 23);
            this.UserLoginSubmit.TabIndex = 0;
            this.UserLoginSubmit.Text = "Login";
            this.UserLoginSubmit.UseVisualStyleBackColor = true;
            this.UserLoginSubmit.Click += new System.EventHandler(this.UserLoginSubmit_Click);
            // 
            // CreateUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "CreateUserForm";
            this.Text = "Register";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox NewPasswordInput;
        private System.Windows.Forms.TextBox NewUserNameInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button NewUserSubmit;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox UserPasswordInput;
        private System.Windows.Forms.TextBox UserNameInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button UserLoginSubmit;
    }
}