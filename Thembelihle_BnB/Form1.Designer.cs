namespace Thembelihle
{
    partial class Form1
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
            main_panel = new System.Windows.Forms.Panel();
            login_signup_panel = new System.Windows.Forms.Panel();
            main_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // main_panel
            // 
            main_panel.Controls.Add(login_signup_panel);
            main_panel.Location = new System.Drawing.Point(4, 2);
            main_panel.Name = "main_panel";
            main_panel.Size = new System.Drawing.Size(1255, 676);
            main_panel.TabIndex = 0;
            // 
            // login_signup_panel
            // 
            login_signup_panel.Location = new System.Drawing.Point(445, 10);
            login_signup_panel.Name = "login_signup_panel";
            login_signup_panel.Size = new System.Drawing.Size(346, 657);
            login_signup_panel.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(main_panel);
            this.Name = "Form1";
            this.Text = "Form1";
            main_panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel main_panel;
        private System.Windows.Forms.Panel login_signup_panel;
    }
}

