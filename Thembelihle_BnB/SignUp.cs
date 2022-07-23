

using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Thembelihle
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.email_text = new System.Windows.Forms.TextBox();
            this.password_text = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.status = new System.Windows.Forms.Label();
            this.email_label = new System.Windows.Forms.Label();
            this.password_label = new System.Windows.Forms.Label();
            this.show_password = new System.Windows.Forms.Label();
            this.sign_in = new System.Windows.Forms.Button();
            this.sign_up = new System.Windows.Forms.Label();
            this.show_pwd = new System.Windows.Forms.CheckBox();
            this.name_text = new System.Windows.Forms.TextBox();
            this.surname_text = new System.Windows.Forms.TextBox();
            this.phone_number_text = new System.Windows.Forms.TextBox();
            this.full_name_label = new System.Windows.Forms.Label();
            this.surname_label = new System.Windows.Forms.Label();
            this.phone_number = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // email_text
            // 
            this.email_text.Location = new System.Drawing.Point(64, 348);
            this.email_text.Name = "email_text";
            this.email_text.Size = new System.Drawing.Size(224, 20);
            this.email_text.TabIndex = 1;
            // 
            // password_text
            // 
            this.password_text.Location = new System.Drawing.Point(64, 392);
            this.password_text.Name = "password_text";
            this.password_text.PasswordChar = '*';
            this.password_text.Size = new System.Drawing.Size(224, 20);
            this.password_text.TabIndex = 2;
            this.password_text.TextChanged += new System.EventHandler(this.password_text_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Thembelihle.Properties.Resources.user;
            this.pictureBox1.Location = new System.Drawing.Point(53, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(257, 162);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // status
            // 
            this.status.ForeColor = System.Drawing.SystemColors.ControlText;
            this.status.Location = new System.Drawing.Point(55, 461);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(223, 46);
            this.status.TabIndex = 5;
            this.status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // email_label
            // 
            this.email_label.AutoSize = true;
            this.email_label.Location = new System.Drawing.Point(64, 330);
            this.email_label.Name = "email_label";
            this.email_label.Size = new System.Drawing.Size(73, 13);
            this.email_label.TabIndex = 7;
            this.email_label.Text = "Email Address";
            // 
            // password_label
            // 
            this.password_label.AutoSize = true;
            this.password_label.Location = new System.Drawing.Point(64, 374);
            this.password_label.Name = "password_label";
            this.password_label.Size = new System.Drawing.Size(53, 13);
            this.password_label.TabIndex = 8;
            this.password_label.Text = "Password";
            // 
            // show_password
            // 
            this.show_password.AutoSize = true;
            this.show_password.Location = new System.Drawing.Point(65, 418);
            this.show_password.Name = "show_password";
            this.show_password.Size = new System.Drawing.Size(0, 13);
            this.show_password.TabIndex = 9;
            // 
            // sign_in
            // 
            this.sign_in.Location = new System.Drawing.Point(55, 515);
            this.sign_in.Name = "sign_in";
            this.sign_in.Size = new System.Drawing.Size(224, 30);
            this.sign_in.TabIndex = 10;
            this.sign_in.Text = "Sign Up";
            this.sign_in.UseVisualStyleBackColor = true;
            this.sign_in.Click += new System.EventHandler(this.sign_in_Click);
            // 
            // sign_up
            // 
            this.sign_up.AutoSize = true;
            this.sign_up.Location = new System.Drawing.Point(110, 556);
            this.sign_up.Name = "sign_up";
            this.sign_up.Size = new System.Drawing.Size(132, 13);
            this.sign_up.TabIndex = 12;
            this.sign_up.Text = "Already have an account?";
            this.sign_up.Click += new System.EventHandler(this.sign_up_Click);
            this.sign_up.MouseLeave += new System.EventHandler(this.sign_up_MouseLeave);
            this.sign_up.MouseHover += new System.EventHandler(this.sign_up_MouseHover);
            // 
            // show_pwd
            // 
            this.show_pwd.AutoSize = true;
            this.show_pwd.Location = new System.Drawing.Point(67, 441);
            this.show_pwd.Name = "show_pwd";
            this.show_pwd.Size = new System.Drawing.Size(102, 17);
            this.show_pwd.TabIndex = 13;
            this.show_pwd.Text = "Show Password";
            this.show_pwd.UseVisualStyleBackColor = true;
            this.show_pwd.CheckedChanged += new System.EventHandler(this.show_pwd_CheckedChanged);
            // 
            // name_text
            // 
            this.name_text.Location = new System.Drawing.Point(64, 207);
            this.name_text.Name = "name_text";
            this.name_text.Size = new System.Drawing.Size(224, 20);
            this.name_text.TabIndex = 18;
            // 
            // surname_text
            // 
            this.surname_text.Location = new System.Drawing.Point(63, 254);
            this.surname_text.Name = "surname_text";
            this.surname_text.Size = new System.Drawing.Size(224, 20);
            this.surname_text.TabIndex = 19;
            // 
            // phone_number_text
            // 
            this.phone_number_text.Location = new System.Drawing.Point(63, 302);
            this.phone_number_text.Name = "phone_number_text";
            this.phone_number_text.Size = new System.Drawing.Size(224, 20);
            this.phone_number_text.TabIndex = 20;
            // 
            // full_name_label
            // 
            this.full_name_label.AutoSize = true;
            this.full_name_label.Location = new System.Drawing.Point(64, 188);
            this.full_name_label.Name = "full_name_label";
            this.full_name_label.Size = new System.Drawing.Size(54, 13);
            this.full_name_label.TabIndex = 21;
            this.full_name_label.Text = "Full Name";
            // 
            // surname_label
            // 
            this.surname_label.AutoSize = true;
            this.surname_label.Location = new System.Drawing.Point(64, 235);
            this.surname_label.Name = "surname_label";
            this.surname_label.Size = new System.Drawing.Size(49, 13);
            this.surname_label.TabIndex = 22;
            this.surname_label.Text = "Surname";
            // 
            // phone_number
            // 
            this.phone_number.AutoSize = true;
            this.phone_number.Location = new System.Drawing.Point(63, 284);
            this.phone_number.Name = "phone_number";
            this.phone_number.Size = new System.Drawing.Size(78, 13);
            this.phone_number.TabIndex = 23;
            this.phone_number.Text = "Phone Number";
            // 
            // SignUp
            // 
            this.ClientSize = new System.Drawing.Size(356, 580);
            this.Controls.Add(this.phone_number);
            this.Controls.Add(this.surname_label);
            this.Controls.Add(this.full_name_label);
            this.Controls.Add(this.phone_number_text);
            this.Controls.Add(this.surname_text);
            this.Controls.Add(this.name_text);
            this.Controls.Add(this.show_pwd);
            this.Controls.Add(this.sign_up);
            this.Controls.Add(this.sign_in);
            this.Controls.Add(this.show_password);
            this.Controls.Add(this.password_label);
            this.Controls.Add(this.email_label);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.status);
            this.Controls.Add(this.password_text);
            this.Controls.Add(this.email_text);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "SignUp";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        protected void user_signup()
        {
            String connect = "Data Source=146.230.177.46;User ID=GroupPmb7;Password=8yrrvz";
            String query = "INSERT INTO customer (name,surname,phone_number,password,email) VALUES (@name,@surname,@phone_number,@password,@email)";
            SqlConnection connection = new SqlConnection(connect);
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@name", this.name_text.Text.ToString());
                command.Parameters.AddWithValue("@surname", this.surname_text.Text.ToString());
                command.Parameters.AddWithValue("@password", this.password_text.Text.ToString());
                command.Parameters.AddWithValue("@email", this.email_text.Text.ToLower().Trim().ToString());
                command.Parameters.AddWithValue("@phone_number", this.phone_number_text.Text.ToString());
                connection.Open();
                try
                {
                    command.ExecuteNonQuery();
                    MessageBox.Show("Account created successful", "Account created");
                    user_login(this.email_text.Text.ToLower().Trim().ToString(), this.password_text.Text.ToString());
                }
                catch(SqlException ex)
                {
                    String error = ex.Errors[0].Message;
                    string e = error.Substring(error.LastIndexOf("(") + 1).Replace(").", "") + " is already registered";
             
                    status.Text = "Error creating the an account! \n" + e;
                }
            }
        }
        protected void user_login(String email, String password)
        {
            String connect = "Data Source=146.230.177.46;User ID=GroupPmb7;Password=8yrrvz";
            SqlConnection con = new SqlConnection(connect);
            con.Open();
            String quary = "SELECT COUNT(*) FROM customer where email='" + email + "'and password like '" + password + "'";
            SqlDataAdapter sda = new SqlDataAdapter(quary, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                quary = "SELECT * FROM customer where email='" + email + "'and password like '" + password + "'";
                sda = new SqlDataAdapter(quary, con);
                dt = new DataTable();
                sda.Fill(dt);
                #pragma warning disable CS8604 // Possible null reference argument.
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
                }
                catch (Exception ex)
                {
                    //
                }
                Customer customer = new Customer(id, name, surname, phone, _email, _password, address);
                status.Text = "login success";
                status.ForeColor = System.Drawing.Color.Green;
                this.Hide();
                Main.customer = customer;
                new Home().Show();
            }
            else
            {
                status.Text = "Unable to login go sign in page";
                status.ForeColor = System.Drawing.Color.Red;
            }
        }
        private void sign_in_Click(object sender, EventArgs e)
        {
            this.user_signup();
        }
        private void show_pwd_CheckedChanged(object sender, EventArgs e)
        {
            if (show_pwd.Checked)
            {
                show_password.Text = this.password_text.Text.ToString();
            }
            else
            {
                this.show_password.Text = "";
            }
        }

        private void password_text_TextChanged(object sender, EventArgs e)
        {
            if (show_pwd.Checked)
            {
                this.show_password.Text = password_text.Text.ToString();
            }
        }

        private void sign_up_MouseHover(object sender, EventArgs e)
        {
            sign_up.Font = new Font(sign_up.Font, FontStyle.Underline);
            Cursor.Current = Cursors.Hand;
        }

        private void sign_up_MouseLeave(object sender, EventArgs e)
        {
            sign_up.Font = new Font(sign_up.Font, FontStyle.Regular);
            Cursor.Current = Cursors.Default;
        }

        private void sign_up_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1.loadLoginPage();
        }
    }
}