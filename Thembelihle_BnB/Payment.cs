using System;
using System.Collections;
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
    public partial class Payment : Form
    {
        List<Card> cards;
        public Payment()
        {
            InitializeComponent();
            cards = new List<Card>();
            initPayment();

        }
        private void initPayment()
        {
            string query = "SELECT * FROM payment where customer_id=" + Main.customer.Id + " order by id desc";
            String connect = "Data Source=146.230.177.46;User ID=GroupPmb7;Password=8yrrvz";
            SqlConnection con = new SqlConnection(connect);
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            parseQuery(dt);
            for(int i = 0; i < cards.Count; i++)
            {
                Card card = cards[i];
                cards_list.Rows.Add(card.HolderName, card.Number, card.ExpireyDate);
            }
        }
        public void removeAndInit()
        {
            for(int i = 0; i < cards.Count; i++)
            {
                cards_list.Rows.RemoveAt(0);
            }
            cards = new List<Card>();
            initPayment();
        }
        public void parseQuery(DataTable dt)
        { 
            for(int i=0; i < dt.Rows.Count; i++)
            {
                int id = int.Parse(dt.Rows[i][0].ToString());
                string name = dt.Rows[i][1].ToString();
                string number = dt.Rows[i][2].ToString();
                string expireyDate = dt.Rows[i][3].ToString();
                int cvv = int.Parse(dt.Rows[i][4].ToString());
                cards.Add(new Card(id, name, number, expireyDate, cvv));
            }
        }

        private void delete_seleted_btn_Click(object sender, EventArgs e)
        {
            if (cards_list.SelectedRows.Count != 0)
            {
                int index = cards_list.CurrentRow.Index;
                Card card = cards[index];
                string query = "DELETE payment where id=" + card.ID;
                if (execSQLDelete(query))
                {
                    MessageBox.Show("Card deleted");
                    for (int i = 0; i < cards.Count; i++)
                    {
                        cards_list.Rows.RemoveAt(0);
                    }
                    cards = new List<Card>();
                    initPayment();
                }else
                {
                    MessageBox.Show("ZAMO");
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

        private void add_card_btn_Click(object sender, EventArgs e)
        {
            AddCard addCard = new AddCard(this, this);
            addCard.Show();
        }
    }
}
