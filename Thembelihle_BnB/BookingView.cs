using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Thembelihle
{
    public partial class BookingView : UserControl
    {
        private long createdDate;
        private long checkInDate;
        private long checkOutDate;
        private float price;
        private int numberOfGuest;
        private string room;
        private string status;
        private int id;
        private Extra[] extras;
        private MyBooking booking;
        public BookingView(int id, float price, string room, string status, int numberOfGuest, long createdDate, long checkInDate, long checkOutDate, MyBooking booking)
        {
            InitializeComponent();
            this.extras = extras;
            this.id = id;
            this.numberOfGuest = numberOfGuest;
            this.checkInDate = checkInDate;
            this.checkOutDate = checkOutDate;
            this.createdDate = createdDate;
            this.price = price;
            this.room = room;
            this.status = status;
            init();
            this.booking = booking;
        }
        public void init()
        {
            room_type_label.Text = room;
            price_label.Text = "R"+ price.ToString();
            number_of_guest_label.Text = numberOfGuest.ToString();
            status_label.Text = status;
            DateTime chIn = new DateTime(checkInDate);
            DateTime chOut = new DateTime(checkOutDate);
            DateTime date = new DateTime(createdDate);
            check_in_label.Text = chIn.ToString("MMMM dd, yyyy");
            check_out_label.Text = chOut.ToString("MMMM dd, yyyy");
            created_time_label.Text = date.ToString("MMMM dd, yyyy");
            if(chIn <= DateTime.Today)
            {
                cancel_btn.Enabled = false;
            }
            checkExtra();
        }
        private void checkExtra()
        {
            string query = "select e.name, COUNT(e.id)'count', booking.number_guests from booking left join booked_room br on booking.id = br.booking_id left join room r2 on br.room_id = r2.id left join booked_extra be on booking.id = be.booking_id left join extra e on be.extra_id = e.id where booking.id="+this.id+" group by e.name, booking.number_guests;";
            String connect = "Data Source=146.230.177.46;User ID=GroupPmb7;Password=8yrrvz";
            SqlConnection con = new SqlConnection(connect);
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            for(int i = 0; i < dt.Rows.Count; i++)
            {
                string name = dt.Rows[i][0].ToString();
                int count = int.Parse(dt.Rows[i][1].ToString());
                switch (name)
                {
                    case "Breakfast":
                        {
                            extras_label.Text += "Breakfast, ";
                            break;
                        }
                    case "Parking":
                        {
                            extras_label.Text += count + " times parking slot\\s";
                            break;
                        }
                }
            }
        }

        public string Status
        {
            get { return this.status; }
            set { this.status = value; }
        }

        public long CreatedDate
        {
            get { return this.createdDate;}
            set { this.createdDate = value; }
        }
        public long CheckInDate
        {
            get { return this.checkInDate; }
            set { this.checkInDate = value; }
        }
        public long CheckOutDate
        {
            get { return this.checkOutDate; }
            set { this.checkOutDate = value; }
        }
        public float Price
        {
            get { return this.price; }
            set { this.price = value; }
        }
        public Extra[] Extras
        {
            get { return this.extras; }
            set { this.extras = value; }
        }
        public int BookingId
        {
            get { return this.id; }
            set { this.id = value; }
        }
        public int NumberOfGuest
        {
            get { return this.numberOfGuest; }
            set { this.numberOfGuest = value; }
        }
        public string Room
        {
            get { return this.room; }
            set { this.room = value; }
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to cancel the booking", "Cancel booking", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string query = "delete booking where id = " + id;
                if (changeId(query))
                {
                    MessageBox.Show("Booking canceled successful\nYou should recieved your payment in 3 working days?");
                    this.booking.renderItems();
                }
                else
                {
                    MessageBox.Show("Failed to cancel the booking");
                }
            }
        }
        private bool changeId(String query)
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
    }
}
