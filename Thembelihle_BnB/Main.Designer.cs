namespace Thembelihle
{
    partial class Main
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.payment_btn = new System.Windows.Forms.Button();
            this.manage_profile_btn = new System.Windows.Forms.Button();
            this.mybookings_btn = new System.Windows.Forms.Button();
            this.home_btn = new System.Windows.Forms.Button();
            this.user_name = new System.Windows.Forms.Label();
            this.user_icon = new System.Windows.Forms.PictureBox();
            this.logout_btn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tab_view = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.user_icon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.user_name);
            this.panel1.Controls.Add(this.user_icon);
            this.panel1.Controls.Add(this.logout_btn);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(5, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(234, 661);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.payment_btn);
            this.panel2.Controls.Add(this.manage_profile_btn);
            this.panel2.Controls.Add(this.mybookings_btn);
            this.panel2.Controls.Add(this.home_btn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 252);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(234, 364);
            this.panel2.TabIndex = 4;
            // 
            // payment_btn
            // 
            this.payment_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.payment_btn.Image = global::Thembelihle.Properties.Resources.payment;
            this.payment_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.payment_btn.Location = new System.Drawing.Point(0, 135);
            this.payment_btn.Name = "payment_btn";
            this.payment_btn.Size = new System.Drawing.Size(234, 45);
            this.payment_btn.TabIndex = 1;
            this.payment_btn.Text = "PAYMENT";
            this.payment_btn.UseVisualStyleBackColor = true;
            this.payment_btn.Click += new System.EventHandler(this.payment_btn_Click);
            // 
            // manage_profile_btn
            // 
            this.manage_profile_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.manage_profile_btn.Image = global::Thembelihle.Properties.Resources.profile;
            this.manage_profile_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.manage_profile_btn.Location = new System.Drawing.Point(0, 90);
            this.manage_profile_btn.Name = "manage_profile_btn";
            this.manage_profile_btn.Size = new System.Drawing.Size(234, 45);
            this.manage_profile_btn.TabIndex = 2;
            this.manage_profile_btn.Text = "MANAGE PROFILE";
            this.manage_profile_btn.UseVisualStyleBackColor = true;
            this.manage_profile_btn.Click += new System.EventHandler(this.manage_profile_btn_Click);
            // 
            // mybookings_btn
            // 
            this.mybookings_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.mybookings_btn.Image = global::Thembelihle.Properties.Resources.booking;
            this.mybookings_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.mybookings_btn.Location = new System.Drawing.Point(0, 45);
            this.mybookings_btn.Name = "mybookings_btn";
            this.mybookings_btn.Size = new System.Drawing.Size(234, 45);
            this.mybookings_btn.TabIndex = 1;
            this.mybookings_btn.Text = "MY BOOKING";
            this.mybookings_btn.UseVisualStyleBackColor = true;
            this.mybookings_btn.Click += new System.EventHandler(this.mybookings_btn_Click);
            // 
            // home_btn
            // 
            this.home_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.home_btn.Image = global::Thembelihle.Properties.Resources.home;
            this.home_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.home_btn.Location = new System.Drawing.Point(0, 0);
            this.home_btn.Name = "home_btn";
            this.home_btn.Size = new System.Drawing.Size(234, 45);
            this.home_btn.TabIndex = 0;
            this.home_btn.Text = "HOME";
            this.home_btn.UseVisualStyleBackColor = true;
            this.home_btn.Click += new System.EventHandler(this.home_btn_Click);
            // 
            // user_name
            // 
            this.user_name.Dock = System.Windows.Forms.DockStyle.Top;
            this.user_name.Font = new System.Drawing.Font("Segoe Marker", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_name.Location = new System.Drawing.Point(0, 207);
            this.user_name.Name = "user_name";
            this.user_name.Size = new System.Drawing.Size(234, 45);
            this.user_name.TabIndex = 3;
            this.user_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // user_icon
            // 
            this.user_icon.Dock = System.Windows.Forms.DockStyle.Top;
            this.user_icon.Image = global::Thembelihle.Properties.Resources.user;
            this.user_icon.Location = new System.Drawing.Point(0, 128);
            this.user_icon.Name = "user_icon";
            this.user_icon.Size = new System.Drawing.Size(234, 79);
            this.user_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.user_icon.TabIndex = 2;
            this.user_icon.TabStop = false;
            // 
            // logout_btn
            // 
            this.logout_btn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.logout_btn.Image = global::Thembelihle.Properties.Resources.logout;
            this.logout_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.logout_btn.Location = new System.Drawing.Point(0, 616);
            this.logout_btn.Name = "logout_btn";
            this.logout_btn.Size = new System.Drawing.Size(234, 45);
            this.logout_btn.TabIndex = 1;
            this.logout_btn.Text = "LOGOUT";
            this.logout_btn.UseVisualStyleBackColor = true;
            this.logout_btn.Click += new System.EventHandler(this.logout_btn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::Thembelihle.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(234, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tab_view
            // 
            this.tab_view.Location = new System.Drawing.Point(245, 5);
            this.tab_view.Name = "tab_view";
            this.tab_view.Size = new System.Drawing.Size(997, 654);
            this.tab_view.TabIndex = 1;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1254, 671);
            this.Controls.Add(this.tab_view);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.Text = "Main";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.user_icon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox user_icon;
        private System.Windows.Forms.Button logout_btn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label user_name;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button payment_btn;
        private System.Windows.Forms.Button manage_profile_btn;
        private System.Windows.Forms.Button mybookings_btn;
        private System.Windows.Forms.Button home_btn;
        private System.Windows.Forms.Panel tab_view;
    }
}