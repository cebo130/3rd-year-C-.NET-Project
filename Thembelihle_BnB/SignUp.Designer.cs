
using System.Windows.Forms;

namespace Thembelihle
{

    partial class SignUp
    {

        private System.ComponentModel.IContainer components = null;


        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        protected TextBox email;
        protected TextBox password;
        private TextBox email_text;
        private TextBox password_text;
        private Label status;
        private PictureBox pictureBox1;
        private Label email_label;
        private Label password_label;
        private Label show_password;
        private Button sign_in;
        private Label sign_up;
        private CheckBox show_pwd;
        private TextBox name_text;
        private TextBox surname_text;
        private TextBox phone_number_text;
        private Label full_name_label;
        private Label surname_label;
        private Label phone_number;
    }
}