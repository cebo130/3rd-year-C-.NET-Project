using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Thembelihle
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
            init();
        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1.loadLoginPage();
        }
        private void init()
        {
            string query = "SELECT COUNT(*) FROM booking where check_in >= " + DateTime.Today.Ticks;
            String connect = "Data Source=146.230.177.46;User ID=GroupPmb7;Password=8yrrvz";
            SqlConnection con = new SqlConnection(connect);
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if(dt.Rows.Count > 0)
            {
                booking_labels.Text = dt.Rows[0][0].ToString() + "\nBookings";
            }else
            {
                booking_labels.Text = "0\nBooking";
            }
            query = "SELECT SUM(quantity) FROM room";
            sda = new SqlDataAdapter(query, con);
            dt = new DataTable();
            sda.Fill(dt);
            rooms_label.Text = dt.Rows[0][0].ToString() + "\nRooms Quantinty";
            query = "SELECT SUM(amount) FROM booking where check_in >= " + new DateTime(DateTime.Today.Month).Ticks;
            sda = new SqlDataAdapter(query, con);
            dt = new DataTable();
            sda.Fill(dt);
            if(dt.Rows.Count> 0)
            {
                revenue_label.Text = "R" + dt.Rows[0][0].ToString() + "\nMonth\nRevenue";
            }else
            {
                revenue_label.Text = "R0\nMonth\nRevenue";
            }
            query = "SELECT COUNT(*) FROM customer";
            sda = new SqlDataAdapter(query, con);
            dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                users_label.Text =  dt.Rows[0][0].ToString() + "\nUsers";
            }
            else
            {
                users_label.Text = "0\nUsers";
            }
            query = "SELECT COUNT(*) FROM promotion";
            sda = new SqlDataAdapter(query, con);
            dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                promo_label.Text = dt.Rows[0][0].ToString() + "\nPromotions";
            }
            else
            {
                promo_label.Text = "0\nPromotions";
            }
            query = "SELECT COUNT(*) FROM extra";
            sda = new SqlDataAdapter(query, con);
            dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                extra_label.Text = dt.Rows[0][0].ToString() + "\nExtras";
            }
            else
            {
                extra_label.Text = "0\nExtra";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
      
        }

        private void button6_Click(object sender, EventArgs e)
        {
   
        }
    }
}