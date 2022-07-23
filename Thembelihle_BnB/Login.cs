using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Thembelihle
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            init();
        }
        public void init()
        {
            this.password_textbox.PasswordChar = '*';
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            String email = this.email_textbox.Text.ToLower().Trim().ToString();
            String password = this.password_textbox.Text.ToString();
            String connect = "Data Source=146.230.177.46;User ID=GroupPmb7;Password=8yrrvz";
            SqlConnection con = new SqlConnection(connect);
            con.Open();
            String quary;
            if (admin_checkbox.Checked)
            {
                quary = "SELECT COUNT(*) FROM admin where email='" + email + "'and password like '" + password + "'";
            }
            else
            {
                quary = "SELECT COUNT(*) FROM customer where email='" + email + "'and password like '" + password + "'";
            }
            SqlDataAdapter sda = new SqlDataAdapter(quary, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                if (admin_checkbox.Checked)
                {
                    this.Close();
                    Form1.adminOnLogin();
                    return;
                }
                quary = "SELECT * FROM customer left join address on customer.id = address.customer_id where email='" + email + "'and password like '" + password + "'";
                sda = new SqlDataAdapter(quary, con);
                dt = new DataTable();
                sda.Fill(dt);
                int id = int.Parse(dt.Rows[0][0].ToString());
                string name = dt.Rows[0][1].ToString();
                string surname = dt.Rows[0][2].ToString();
                string phone = dt.Rows[0][3].ToString();
                string _email = dt.Rows[0][4].ToString();
                string _password = dt.Rows[0][5].ToString();
                string _country = dt.Rows[0][9].ToString();
                string _state = dt.Rows[0][10].ToString();
                string _city = dt.Rows[0][11].ToString();
                int _zipCode = -1;
                if (dt.Rows[0][12].ToString() != "")
                {
                    _zipCode = int.Parse(dt.Rows[0][12].ToString());
                }
                Address address = null;
                try
                {
                    address = new Address(_country, _state, _city, _zipCode);
                }catch(Exception ex)
                {
                    //
                }
                Customer customer = new Customer(id, name, surname, phone, _email, _password, address);
                this.Close();
                Main.customer = customer;
                Form1.onLogin();
            }
            else
            {
                MessageBox.Show("Invalid login");
            }
        }
       

        private void Login_Load(object sender, EventArgs e)
        {
           
        }
  
        private void Login_Load_1(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SignUp register = new SignUp();
            register.Show();
            this.Hide();
            
        }

        private void signup_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1.onSignUp();
        }
        
        private void sign_up_MouseHover(object sender, EventArgs e)
        {
            signup.Font = new Font(signup.Font, FontStyle.Underline);
            Cursor.Current = Cursors.Hand;
        }

        private void sign_up_MouseLeave(object sender, EventArgs e)
        {
            signup.Font = new Font(signup.Font, FontStyle.Regular);
            Cursor.Current = Cursors.Default;
        }

        private void fpasword_label_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please contact the admin to reset your password", "Password Reset");
        }
    }
    
}
