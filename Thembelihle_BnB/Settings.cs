using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Thembelihle
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
            init();
        }
        public void init()
        {
            Customer customer = Main.customer;
            name_textbox.Text = customer.Name;
            surname_textbox.Text = customer.Surname;
            email_textbox.Text = customer.Email;
            phone_textbox.Text = customer.PhoneNumber;
            country_textbox.Text = customer.Address.Country;
            state_textbox.Text = customer.Address.State;
            city_textbox.Text = customer.Address.City;
            zipCode_textbox.Text = customer.Address.ZipCode.ToString();
        }
        public void update(Customer customer)
        {
            string query1 = "UPDATE customer set name = '" + customer.Name + "', surname = '" + customer.Surname + "', phone_number = '" + customer.PhoneNumber + "', email = '" + customer.Email + "', password = '" + customer.Password + "', blocked = 0 where id = " +customer.Id;
            string query2 = "BEGIN transaction; UPDATE address set country = '" + customer.Address.Country + "', state = '" + customer.Address.State + "', city = '" + customer.Address.City + "', zip = " + customer.Address.ZipCode + " where customer_id = " + customer.Id+ ";IF @@ROWCOUNT = 0 INSERT INTO address(customer_id, country, state, city, zip) VALUES ("+customer.Id+", '"+ customer.Address.Country + "', '"+ customer.Address.State + "', '"+ customer.Address.City + "', "+ customer.Address.ZipCode + "); COMMIT;";

            string start = execSQLq(query1);
            if (start.Equals("pass"))
            {
                start = execSQLq(query2);
                if (start.Equals("pass"))
                {
                    Main.customer = customer;
                    Form1.onLogin();
                }else
                {
                    MessageBox.Show(start);
                }
            }else
            {
                MessageBox.Show(start);
            }

        }
        private String execSQLq(String query)
        {
            String connect = "Data Source=146.230.177.46;User ID=GroupPmb7;Password=8yrrvz";
            SqlConnection con = new SqlConnection(connect);
            con.Open();
            SqlCommand command = new SqlCommand(query, con);
            try
            {
                SqlDataReader reader = command.ExecuteReader();
                return "pass";
            }
            catch (SqlException ex)
            {
                String error = ex.Errors[0].Message;
                return error.Substring(error.LastIndexOf("(") + 1).Replace(").", "") + " is already registered";
            }
        }

        private void delete(Customer customer)
        {
            string query1 = "UPDATE booking set customer_id = 100085 where booking.customer_id =" + customer.Id;
            string query2 = "DELETE customer where id=" + customer.Id;
            if (execSQLDelete(query1))
            {
                if (execSQLDelete(query2))
                {
                    Main.customer = null;
                    MessageBox.Show("Profile deleted!");
                    Form1.loadLoginPage();
                }
            }
        }
        private bool execSQLDelete(String query)
        {
            String connect = "Data Source=146.230.177.46;User ID=GroupPmb7;Password=8yrrvz";
            SqlConnection con = new SqlConnection(connect);
            con.Open();
            SqlCommand command = new SqlCommand(query, con);
            try
            {
                SqlDataReader reader = command.ExecuteReader();
                return true;
            }
            catch (SqlException ex)
            {
                return false;
            }
        }

        private void save_profile_btn_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            customer.Name = name_textbox.Text.ToString();
            customer.Surname = surname_textbox.Text.ToString();
            customer.Email = email_textbox.Text.ToString();
            customer.PhoneNumber = phone_textbox.Text.ToString();
            customer.Password = newP_textbox.Text.ToString();
            if(!comfirmP_textbox.Text.ToString().Equals(newP_textbox.Text.ToString()))
            {
                MessageBox.Show("Password does not match");
                return;
            }
            if(customer.Password == "")
            {
                customer.Password = Main.customer.Password;
            }
            if(!oldP_textbox.Text.ToString().Equals(Main.customer.Password))
            {
                MessageBox.Show("Invalid old password");
                return;
            }
            Address address = new Address();
            address.Country = country_textbox.Text.ToString();
            address.State = state_textbox.Text.ToString();
            address.City = city_textbox.Text.ToString();
            address.ZipCode = int.Parse(zipCode_textbox.Text.ToString());
            customer.Address = address;
            customer.Id = Main.customer.Id;
            update(customer);
        }

        private void delete_profile_btn_Click(object sender, EventArgs e)
        {
            if (Main.customer.Password.Equals(oldP_textbox.Text.ToString()))
            {
                delete(Main.customer);
            }else
            {
                MessageBox.Show("Invalid old password");
            }
        }
    }
}
