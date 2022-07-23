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
    public partial class AddCard : Form
    {
        Payment payment;
        Form form;
        public AddCard(Payment payment, Form form)
        {
            this.payment = payment;
            this.form = form;
            InitializeComponent();
        }

        private void submit_btn_Click(object sender, EventArgs e)
        {
            String name = card_holder_textbox.Text.ToString();
            String card_number = card_number_textbox.Text.ToString();
            String card_expirey_date = expirey_date_textbox.Text.ToString();
            int card_cvv = int.Parse(cvv_textbox.Text.ToString());
            String query = "insert into payment (card_holder, card_number, expiry_date, customer_id, cvv) values ('" + name + "', '" + card_number + "', '" + card_expirey_date + "', "+Main.customer.Id+"," + card_cvv+");";
            if (execSQLInsert(query))
            {
                payment.removeAndInit();
                this.Close();
            }else
            {
                MessageBox.Show("Unknown error occured");
            }
        }
        private bool execSQLInsert(String query)
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
                MessageBox.Show(ex.Errors[0].Message.ToString());
                return false;
            }
        }
    }
}
