using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Thembelihle
{
    //color #3498DB
    public partial class Form1 : Form
    {
        static Form active = null;
        static Panel main;
        static Panel login_signup;
        public Form1()
        {
            InitializeComponent();
            main = this.main_panel;
            login_signup = this.login_signup_panel;
            loadLoginPage();

        }
        public static void loadLoginPage()
        {
            if(active != null)
            {
                active.Close();
            }
            Form form = new Login();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            login_signup.Controls.Add(form);
            login_signup.Tag = form;
            form.BringToFront();
            form.Show();
        }
        public static void adminOnLogin()
        {
            if (active != null)
            {
                active.Close();
            }
            Form form = new Admin();
            active = form;
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            main.Controls.Add(form);
            main.Tag = form;
            form.BringToFront();
            form.Show();
        }
        public static void onSignUp()
        {
            if (active != null)
            {
                active.Close();
            }
            Form form = new SignUp();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            login_signup.Controls.Add(form);
            login_signup.Tag = form;
            form.BringToFront();
            form.Show();
        }
        public static void onLogin()
        {
            if(active != null)
            {
                active.Close();
            }
            Form form = new Main();
            active = form;
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            main.Controls.Add(form);
            main.Tag = form;
            form.BringToFront();
            form.Show();
        }
    }
}
