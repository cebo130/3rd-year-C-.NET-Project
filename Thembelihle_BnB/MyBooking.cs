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
    public partial class MyBooking : Form
    {
        public MyBooking()
        {
            InitializeComponent();
            renderItems();
        }

        public void renderItems()
        {
            string query = "select booking.id, r2.type,booking.status,booking.number_guests, booking.amount, booking.check_in, booking.check_out, booking.date from booking left join booked_room br on booking.id = br.booking_id left join room r2 on br.room_id = r2.id left join booked_extra be on booking.id = be.booking_id left join extra e on be.extra_id = e.id where customer_id="+Main.customer.Id+ " group by  booking.id, r2.type, booking.amount, booking.check_in, booking.check_out, booking.date, booking.status, booking.number_guests order by id desc;";
            String connect = "Data Source=146.230.177.46;User ID=GroupPmb7;Password=8yrrvz";
            SqlConnection con = new SqlConnection(connect);
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            BookingView[] bookings = new BookingView[dt.Rows.Count];
            if (flowLayout.Controls.Count > 0)
            {
                flowLayout.Controls.Clear();
            }
            for (int i = 0; i < bookings.Length; i++)
            {
                int id = int.Parse(dt.Rows[i][0].ToString());
                string name = dt.Rows[i][1].ToString();
                string status = dt.Rows[i][2].ToString();
                int numberOfGuest = int.Parse(dt.Rows[i][3].ToString());
                float price = float.Parse(dt.Rows[i][4].ToString());
                long checkIn = long.Parse(dt.Rows[i][5].ToString());
                long checkOut = long.Parse(dt.Rows[i][6].ToString());
                long date = long.Parse(dt.Rows[i][7].ToString());
                bookings[i] = new BookingView(id, price, name, status, numberOfGuest, date, checkIn, checkOut, this);
                flowLayout.Controls.Add(bookings[i]);

            }
        }
    }
}
