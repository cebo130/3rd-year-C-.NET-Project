using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Thembelihle
{
    public partial class MakeBooking : Form
    {
        Room room;
        List<Card> cards = new List<Card>();
        float totalPrice = 0;
        float breakFastPrice = 0;
        float parkingPrice = 0;
        double promo;
        public MakeBooking(Room room)
        {
            InitializeComponent();
            this.room = room;
            this.totalPrice = room.Price;
            customer_name_label.Text = Main.customer.Name + " " + Main.customer.Surname;
            room_name_label.Text = room.Type;
            this.promo = promoPercentange();
            loadPrice();
            if(room.Type.Equals("Triple /Family Room-Self Cater"))
            {
                number_of_guest_combobox.Items.Add(1);
                number_of_guest_combobox.Items.Add(2);
                number_of_guest_combobox.Items.Add(3);
            }else
            {
                number_of_guest_combobox.Items.Add(1);
                number_of_guest_combobox.Items.Add(2);
            }
            Extra parking = checkParking();
            if(parking != null)
            {
                avaliable_paking_label.Text = " Avalaible Parkings " + parking.Quantity;
                for (int i = 0; i < 3 && i < parking.Quantity; i++)
                {
                    parking_combobox.Items.Add(i);
                }
            }
            parking_combobox.Text = "0";
            number_of_guest_combobox.Text = "1";
            number_of_guest_combobox.DropDownStyle = ComboBoxStyle.DropDownList;
            cards_combobox.DropDownStyle = ComboBoxStyle.DropDownList;
            parking_combobox.DropDownStyle = ComboBoxStyle.DropDownList;
            Extra breakfast = checkBreakFast();
            if(breakfast != null)
            {
                breakfast_checkbox.Text = breakfast.Description;
                food_quantity_label.Text = "Avalaible Food Quantity: " + breakfast.Quantity;
            }
            checkParking();
            checkCards();
        }
        private void loadPrice()
        {
            if (promo > 0)
            {
                sum_price_label.Text = "TOTAL PRICE R" + totalPrice + " AFTER " + promo * 100 + "% PROMO R" + (totalPrice - (totalPrice * promo));
            }
            else
            {
                sum_price_label.Text = "TOTAL PRICE R" + totalPrice;
            }
        }

        private void add_card_Click(object sender, EventArgs e)
        {
            AddCard addCard = new AddCard(new Payment(), this);
            addCard.Show();
        }
        private double promoPercentange()
        {
            string query = "select count(*) from booking where customer_id=" + Main.customer.Id;
            String connect = "Data Source=146.230.177.46;User ID=GroupPmb7;Password=8yrrvz";
            SqlConnection con = new SqlConnection(connect);
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            int numberOfBooking = int.Parse(dt.Rows[0][0].ToString());
            if(numberOfBooking >= 3 && numberOfBooking <= 5)
            {
                return 0.05;
            }else if(numberOfBooking > 5 && numberOfBooking <= 10)
            {
                return 0.1;
            }else if(numberOfBooking > 10)
            {
                return 0.15;
            }
            return 0;
        }

        private void pay_btn_Click(object sender, EventArgs e)
        {
            long time = DateTime.Now.Ticks;
            string query = "";
            if (cards_combobox.Text.ToString().Equals("No billing card"))
            {
                MessageBox.Show("Please add a billing card");
                AddCard addCard = new AddCard(new Payment(), this);
                addCard.Show();
                return;
            }
            else
            {
                string query4 = "select id from payment where card_number like '" + cards_combobox.Text.ToString() + "'";
                try
                {
                    if (cards_combobox.Text.ToString().Equals(""))
                    {
                        MessageBox.Show("Please add card to continue with the payment");
                        return;
                    }
                    String connect = "Data Source=146.230.177.46;User ID=GroupPmb7;Password=8yrrvz";
                    SqlConnection con = new SqlConnection(connect);
                    con.Open();
                    SqlDataAdapter sda = new SqlDataAdapter(query4, con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    string id = dt.Rows[0][0].ToString();
                    String query1 = "BEGIN TRANSACTION; DECLARE @id[int]; INSERT INTO booking(amount, status, number_guests, customer_id, date, check_in, check_out, card) VALUES(" + totalPrice + ", 'inactive', " + number_of_guest_combobox.Text.ToString() + ", " + Main.customer.Id + ", " + time.ToString() + ", " + room.From + ", " + room.To + ", "+id+");";
                    query += query1;
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Unknown error occured while processing the card");
                    return;
                }
            }
             String query2 = "SELECT @id = SCOPE_IDENTITY(); INSERT INTO booked_room(booking_id, room_id) VALUES(@id, " +room.Id+");";
            query += query2;
            Extra extra = checkBreakFast();
            if(extra != null)
            {
                if (extra.Quantity >= int.Parse(number_of_guest_combobox.Text.ToString()) && breakfast_checkbox.Checked)
                {
                    query += "INSERT INTO booked_extra (booking_id, extra_id) values(@id, 104);";
                }
            }
            if (!parking_combobox.Text.ToString().Equals("0"))
            {
                for(int i = 0; i < int.Parse(parking_combobox.Text.ToString()); i++)
                {
                    query += "INSERT INTO booked_extra (booking_id, extra_id) values(@id, 101);";
                }
            }
            query += " COMMIT TRANSACTION;";
            if (execSQLInsert(query))
            {
                MessageBox.Show("Room booked successful");
                Form1.onLogin();
                this.Close();
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
        private Extra checkBreakFast()
        {
            string query = "select extra.id, description , extra.quantity - COALESCE(sum(b.number_guests), 0) 'available', price, name from extra left join booked_extra be on extra.id = be.extra_id left join booking b on be.booking_id = b.id where name like 'Breakfast' and (b.id IS NULL or ((b.check_in <= " + room.From + " and b.check_out  >= " + room.From + ") or (b.check_in >= " + room.From + " and b.check_in <= " + room.To + "))) group by extra.id, extra.name, extra.description, extra.quantity, price;";
            String connect = "Data Source=146.230.177.46;User ID=GroupPmb7;Password=8yrrvz";
            SqlConnection con = new SqlConnection(connect);
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            Extra extra = null;
            if(dt.Rows.Count > 0)
            {
                String dis = dt.Rows[0][1].ToString();
                int id = int.Parse(dt.Rows[0][0].ToString());
                int avaliable = int.Parse(dt.Rows[0][2].ToString());
                float price = float.Parse(dt.Rows[0][3].ToString());
                string name = dt.Rows[0][4].ToString();
                extra = new Extra(id, name, dis, avaliable, price);
            }
            return extra;
        }
        private Extra checkParking()
        {
            string query = "select extra.id, description , extra.quantity - count(be.id) 'available', price, name from extra left join booked_extra be on extra.id = be.extra_id left join booking b on be.booking_id = b.id where name like 'Parking' and (b.id IS NULL or ((b.check_in <= " + room.From + " and b.check_out  >= " + room.From + ") or (b.check_in >= " + room.From + " and b.check_in <= " + room.To + "))) group by extra.id, extra.name, extra.description, extra.quantity,price;";
            String connect = "Data Source=146.230.177.46;User ID=GroupPmb7;Password=8yrrvz";
            SqlConnection con = new SqlConnection(connect);
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            Extra extra = null;
            if (dt.Rows.Count > 0)
            {
                String dis = dt.Rows[0][1].ToString();
                int id = int.Parse(dt.Rows[0][0].ToString());
                int avaliable = int.Parse(dt.Rows[0][2].ToString());
                float price = float.Parse(dt.Rows[0][3].ToString());
                string name = dt.Rows[0][4].ToString();
                extra = new Extra(id, name, dis, avaliable, price);
            };
            return extra;
        }
        private void  checkCards()
        {
            string query = "select * from payment where customer_id=" + Main.customer.Id;
            String connect = "Data Source=146.230.177.46;User ID=GroupPmb7;Password=8yrrvz";
            SqlConnection con = new SqlConnection(connect);
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            parseQuery(dt);
            for(int i = 0; i < cards.Count; i++)
            {
                cards_combobox.Items.Add(cards[i].Number);
            }
            if(cards.Count > 0)
            {
                cards_combobox.Text = cards[0].Number;
            }else
            {
                cards_combobox.Text = "No billing card";
            }
        }
        public void parseQuery(DataTable dt)
        {
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                int id = int.Parse(dt.Rows[i][0].ToString());
                string name = dt.Rows[i][1].ToString();
                string number = dt.Rows[i][2].ToString();
                string expireyDate = dt.Rows[i][3].ToString();
                int cvv = int.Parse(dt.Rows[i][4].ToString());
                cards.Add(new Card(id, name, number, expireyDate, cvv));
            }
        }

        private void breakfast_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            if (breakfast_checkbox.Checked)
            {
                Extra extra = checkBreakFast();
                if(extra != null)
                {
                    if (extra.Quantity < int.Parse(number_of_guest_combobox.Text.ToString()))
                    {
                        MessageBox.Show("Breakfast is not avalible for the number of guest selected");
                        breakfast_checkbox.Checked = false;
                    }else
                    {
                        breakFastPrice = (int.Parse(number_of_guest_combobox.Text.ToString())) * extra.Price;
                        totalPrice += breakFastPrice;
                    }
                }else
                {
                    MessageBox.Show("Breakfast is not avalible");
                    breakfast_checkbox.Checked = false;
                }
            }else
            {
                totalPrice -= breakFastPrice;
            }
            loadPrice();
        }

        private void parking_combobox_TextChanged(object sender, EventArgs e)
        {
            if (!parking_combobox.Text.ToString().Equals("0"))
            {
                Extra extra = checkParking();
                if(extra != null)
                {
                    if(extra.Quantity < int.Parse(parking_combobox.Text.ToString()))
                    {
                        MessageBox.Show("Avaliable parkings are less then the selected number");
                        parking_combobox.Text = "0";
                        parkingPrice = 0;
                    }else
                    {
                        totalPrice -= parkingPrice;
                        parkingPrice = (int.Parse(parking_combobox.Text.ToString())) * extra.Price;
                        totalPrice += parkingPrice;
                    }
                }else
                {
                    totalPrice -= parkingPrice;
                    parking_combobox.Text = "0";
                    parkingPrice = 0;
                }
            }else
            {
                totalPrice -= parkingPrice;
                parkingPrice = 0;
            }
            loadPrice();
        }

        private void number_of_guest_combobox_TextChanged(object sender, EventArgs e)
        {
            if (breakfast_checkbox.Checked)
            {
                Extra extra = checkBreakFast();
                if (extra != null)
                {
                    if (extra.Quantity < int.Parse(number_of_guest_combobox.Text.ToString()))
                    {
                        MessageBox.Show("Breakfast is not avalible for the number of guest selected");
                        breakfast_checkbox.Checked = false;
                    }
                    else
                    {
                        totalPrice -= breakFastPrice;
                        breakFastPrice = (int.Parse(number_of_guest_combobox.Text.ToString())) * extra.Price;
                        totalPrice += breakFastPrice;
                    }
                }
                else
                {
                    MessageBox.Show("Breakfast is not avalible");
                    breakfast_checkbox.Checked = false;
                }
            }
            loadPrice();
        }
    }
}
