namespace Thembelihle
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.email_textbox = new System.Windows.Forms.TextBox();
            this.password_textbox = new System.Windows.Forms.TextBox();
            this.login_btn = new System.Windows.Forms.Button();
            this.fpasword_label = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.admin_checkbox = new System.Windows.Forms.CheckBox();
            this.signup = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // email_textbox
            // 
            this.email_textbox.Location = new System.Drawing.Point(60, 239);
            this.email_textbox.Name = "email_textbox";
            this.email_textbox.Size = new System.Drawing.Size(201, 20);
            this.email_textbox.TabIndex = 0;
            // 
            // password_textbox
            // 
            this.password_textbox.Location = new System.Drawing.Point(60, 303);
            this.password_textbox.Name = "password_textbox";
            this.password_textbox.Size = new System.Drawing.Size(201, 20);
            this.password_textbox.TabIndex = 1;
            // 
            // login_btn
            // 
            this.login_btn.Location = new System.Drawing.Point(60, 387);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(201, 34);
            this.login_btn.TabIndex = 2;
            this.login_btn.Text = "LOGIN";
            this.login_btn.UseVisualStyleBackColor = true;
            this.login_btn.Click += new System.EventHandler(this.login_btn_Click);
            // 
            // fpasword_label
            // 
            this.fpasword_label.AutoSize = true;
            this.fpasword_label.Location = new System.Drawing.Point(117, 434);
            this.fpasword_label.Name = "fpasword_label";
            this.fpasword_label.Size = new System.Drawing.Size(88, 13);
            this.fpasword_label.TabIndex = 3;
            this.fpasword_label.Text = "forgot password?";
            this.fpasword_label.Click += new System.EventHandler(this.fpasword_label_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Thembelihle.Properties.Resources.user;
            this.pictureBox1.Location = new System.Drawing.Point(60, 86);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(201, 104);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // admin_checkbox
            // 
            this.admin_checkbox.AutoSize = true;
            this.admin_checkbox.Location = new System.Drawing.Point(60, 349);
            this.admin_checkbox.Name = "admin_checkbox";
            this.admin_checkbox.Size = new System.Drawing.Size(55, 17);
            this.admin_checkbox.TabIndex = 7;
            this.admin_checkbox.Text = "Admin";
            this.admin_checkbox.UseVisualStyleBackColor = true;
            // 
            // signup
            // 
            this.signup.AutoSize = true;
            this.signup.Location = new System.Drawing.Point(111, 466);
            this.signup.Name = "signup";
            this.signup.Size = new System.Drawing.Size(96, 13);
            this.signup.TabIndex = 8;
            this.signup.Text = "Create an Account";
            this.signup.Click += new System.EventHandler(this.signup_Click);
            this.signup.MouseLeave += new System.EventHandler(this.sign_up_MouseLeave);
            this.signup.MouseHover += new System.EventHandler(this.sign_up_MouseHover);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 220);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Email Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 287);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Password";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 618);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.signup);
            this.Controls.Add(this.admin_checkbox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.fpasword_label);
            this.Controls.Add(this.login_btn);
            this.Controls.Add(this.password_textbox);
            this.Controls.Add(this.email_textbox);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox email_textbox;
        private System.Windows.Forms.TextBox password_textbox;
        private System.Windows.Forms.Button login_btn;
        private System.Windows.Forms.Label fpasword_label;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox admin_checkbox;
        private System.Windows.Forms.Label signup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}