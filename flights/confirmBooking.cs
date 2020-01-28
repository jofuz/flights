using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace flights
{
    public partial class confirmBooking : Form
    {
        public confirmBooking()
        {
            InitializeComponent();
        }
        // static variables which will contain customer email, name and booking ref
        public static string refStore = "";
        public static string nameStore = "";
        public static string emailStore = "";

        private void confirmBooking_Load(object sender, EventArgs e)
        {
            // load the static variables used to store the booking information from the booking screen
            idValue.Text = bookFlight.idStore;
            flightNoValue.Text =  bookFlight.flightNoStore;
            departingValue.Text = bookFlight.departStore;
            arrivingValue.Text = bookFlight.arriveStore;
            dateValue.Text = bookFlight.dateStore;
            timeValue.Text = bookFlight.timeStore;
            seatValue.Text = bookFlight.seatStore;
        }

        // Generate a random string with a given size    
        public string bookingRefGen(int size, bool uppercase)
        {
            StringBuilder builder = new StringBuilder();
            Random random = new Random();
            char text;
            for (int i = 0; i < size; i++)
            {
                text = Convert.ToChar(Convert.ToInt32(Math.Floor(21 * random.NextDouble() + 71)));
                builder.Append(text);
            }
            if (uppercase)
                return builder.ToString().ToLower();
            return builder.ToString();
        }

        // confirm booking
        private void confirmBtn_Click(object sender, EventArgs e)
        {
            // generate booking reference ysing flight number, random string and seat class
            string referenceNumber = this.flightNoValue.Text + "-" + bookingRefGen(10, true) + "-" + this.seatValue.Text;

            try
            {
                string connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=flights.mdb";

                using (OleDbConnection conn = new OleDbConnection(connectionString))
                {
                    conn.Open();

                   // query to write to the Reservation table 
                   string reservation = "INSERT INTO Reservation "
                                    + "(FlightNo, Departing, Arriving, [Date], [Time], SeatClass, BookingReference, PassengerName, PassengerEmail) "
                                    + "VALUES (@FlightNo, @Departing, @Arriving, @Date, @Time, @SeatClass, @BookingReference, @PassengerName, @PassengerEmail)";

                    OleDbCommand insertCommand = new OleDbCommand(reservation, conn);
                    insertCommand.CommandType = CommandType.Text;

                    // get the information displayed on the page to use when inserting into table
                    insertCommand.Parameters.AddWithValue("FlightNo", this.flightNoValue.Text);
                    insertCommand.Parameters.AddWithValue("Departing", this.departingValue.Text);
                    insertCommand.Parameters.AddWithValue("Arriving", this.arrivingValue.Text);
                    insertCommand.Parameters.AddWithValue("Date", this.dateValue.Text);
                    insertCommand.Parameters.AddWithValue("Time", this.timeValue.Text);
                    insertCommand.Parameters.AddWithValue("SeatClass", this.seatValue.Text);
                    insertCommand.Parameters.AddWithValue("BookingReference", referenceNumber);
                    insertCommand.Parameters.AddWithValue("PassengerName", this.nameTextBox.Text);
                    insertCommand.Parameters.AddWithValue("PassengerEmail", this.emailTextBox.Text);
                    OleDbDataAdapter adapter = new OleDbDataAdapter(insertCommand);
                    adapter.InsertCommand = insertCommand;

                    MessageBox.Show("query: " + reservation);

                    insertCommand.ExecuteNonQuery();

                    // update seat availability in the flight schedule
                    string seatQuery = "UPDATE Schedule SET " + seatValue.Text + "=" + seatValue.Text + "-1 WHERE FlightNo ='" + flightNoValue.Text + "';";
                    OleDbCommand query = new OleDbCommand(seatQuery, conn);
                    MessageBox.Show("query: " + seatQuery);

                    query.ExecuteNonQuery();

                    conn.Close();

                    // store reference number, name and email.
                    refStore = referenceNumber;
                    nameStore = nameTextBox.Text;
                    emailStore = emailTextBox.Text;

                    // open the booking confirmed page
                    bookingConfirmed bC = new bookingConfirmed();
                    bC.Show();

                    this.Close();
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Booking Failed: \n" + ex);
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            // open the book a flight page
            bookFlight bF = new bookFlight();
            bF.Show();
            this.Close();
        }
    }
}
