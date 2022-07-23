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
    public partial class Main : Form
    {
        Form active = null;
        public static Customer customer;
        public Main()
        {
            InitializeComponent();
            loadPage(0);
            user_name.Text = customer.Name + " " + customer.Surname;
        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            customer = null;
            Form1.loadLoginPage();
            this.Close();
        }
        public void loadPage(int index)
        {
            Form form = null;
            switch (index)
            {
                case 0:
                    {
                        form = new Home();
                        break;
                    }
                case 1:
                    {
                        form = new MyBooking();
                        break;
                    }
                case 2:
                    {
                        form = new Settings();
                        break;
                    }
                case 3:
                    {
                        form = new Payment();
                        break;
                    }
                default: return;
            }
           if(active != null)
            {
                active.Close();
            }
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            tab_view.Controls.Add(form);
            tab_view.Tag = form;
            form.BringToFront();
            form.Show();
            active = form;
        }

        private void home_btn_Click(object sender, EventArgs e)
        {
            loadPage(0);
        }

        private void mybookings_btn_Click(object sender, EventArgs e)
        {
            loadPage(1);
        }

        private void manage_profile_btn_Click(object sender, EventArgs e)
        {
            loadPage(2);
        }

        private void payment_btn_Click(object sender, EventArgs e)
        {
            loadPage(3);
        }
    }
}
