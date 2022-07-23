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
    public partial class Home : Form
    {
        Room[] rooms = new Room[3];
        public Home()
        {
            InitializeComponent();
            from_time.MinDate = DateTime.Today;
            to_time.MinDate = DateTime.Today.AddDays(1);
            loadRooms();
            loadNight();

        }
        private string searchQuery(long start, long end, int days)
        {
            return "SELECT room.id, room.type, room.price*"+days+ " 'price', room.description, room.number_of_beds, room.quantity-count(br.id) 'quantity' from room left join booking b inner join booked_room br on b.id = br.booking_id and ((b.check_in <= "+ start+" and b.check_out  > "+start+ ") or (b.check_in >= "+start+" and b.check_in < "+end+")) on room.id = br.room_id group by room.id, room.type, room.price, room.description, room.number_of_beds,  room.quantity;";
        }

        private void loadRooms()
        {
            long start = from_time.Value.Date.Ticks;
            long end = to_time.Value.Date.Ticks;
            int month = (to_time.Value.Month - from_time.Value.Month);
            long ticks =  to_time.Value.Ticks - from_time.Value.Ticks;
            int days = new DateTime(ticks).Day;
            string query = searchQuery(start, end, days);
            String connect = "Data Source=146.230.177.46;User ID=GroupPmb7;Password=8yrrvz";
            SqlConnection con = new SqlConnection(connect);
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            parseRooms(dt, start, end);
            standard_name.Text = rooms[0].Type;
            standard_discription.Text = rooms[0].Description;
            if(rooms[0].Quantity<= 0)
            {
                rooms[0].Quantity = 0;
                standard_book_btn.Enabled = false;
            }
            standard_price.Text = "R" + rooms[0].Price.ToString();
            standard_quantity.Text = "Rooms Left\n\n" + rooms[0].Quantity.ToString();


            family_name.Text = rooms[1].Type;
            family_discription.Text = rooms[1].Description;
            if (int.Parse(rooms[1].Quantity.ToString()) <= 0)
            {
                rooms[1].Quantity = 0;
                family_book_btn.Enabled = false;
            }
            family_price.Text = "R" + rooms[1].Price.ToString();
            family_quantity.Text = "Rooms Left\n\n" + rooms[1].Quantity.ToString();


            twin_name.Text = rooms[2].Type;
            twin_discription.Text = rooms[2].Description;
            if (int.Parse(rooms[2].Quantity.ToString()) <= 0)
            {
                rooms[2].Quantity = 0;
                twin_book_btn.Enabled = false;
            }
            twin_price.Text = "R" + rooms[2].Price.ToString();
            twin_quantity.Text = "Rooms Left\n\n" + rooms[2].Quantity.ToString();
        }
        private void parseRooms(DataTable dt, long start, long end)
        {
            for(int i = 0; i < 3; i++)
            {
                int id = int.Parse(dt.Rows[i][0].ToString());
                String type = dt.Rows[i][1].ToString();
                int numberOfBeds = int.Parse(dt.Rows[i][4].ToString());
                float price = float.Parse(dt.Rows[i][2].ToString());
                String description = dt.Rows[i][3].ToString();
                int quantity = int.Parse(dt.Rows[i][5].ToString());
                rooms[i] = new Room(id, type, numberOfBeds, price, description, quantity, start, end);
            }
        }

        private void to_time_ValueChanged(object sender, EventArgs e)
        {
            loadNight();
        }

        private void from_time_ValueChanged(object sender, EventArgs e)
        {
            loadNight();
        }
        private void loadNight()
        {
           long night = to_time.Value.Ticks - from_time.Value.Ticks;
            if(night > 0)
            {
                loadRooms();
                night_label.Text = new DateTime(night).Day.ToString() + " night/s";
                standard_book_btn.Enabled = rooms[0].Quantity > 0;
                family_book_btn.Enabled = rooms[1].Quantity > 0;
                twin_book_btn.Enabled = rooms[2].Quantity > 0;
            }
            else
            {
                night_label.Text = "invalid date range";
                standard_book_btn.Enabled = false;
                family_book_btn.Enabled = false;
                twin_book_btn.Enabled = false;
            }
        }

        private void standard_book_btn_Click(object sender, EventArgs e)
        {
            new MakeBooking(rooms[0]).Show();
        }

        private void family_book_btn_Click(object sender, EventArgs e)
        {
            new MakeBooking(rooms[1]).Show();
        }

        private void twin_book_btn_Click(object sender, EventArgs e)
        {
            new MakeBooking(rooms[2]).Show();
        }
    }
}
