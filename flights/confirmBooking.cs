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

        private void confirmBooking_Load(object sender, EventArgs e)
        {
            flightNoValue.Text =  bookFlight.flightNoStore;
            departingValue.Text = bookFlight.departStore;
            arrivingValue.Text = bookFlight.arriveStore;
            dateValue.Text = bookFlight.dateStore;
            timeValue.Text = bookFlight.timeStore;
            seatValue.Text = bookFlight.seatStore;



        }


        // Generate a random string with a given size    
        public string RandomString(int size, bool lowerCase)
        {
            StringBuilder builder = new StringBuilder();
            Random random = new Random();
            char ch;
            for (int i = 0; i < size; i++)
            {
                ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));
                builder.Append(ch);
            }
            if (lowerCase)
                return builder.ToString().ToLower();
            return builder.ToString();
        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            string referenceNumber = RandomString(10, true);

            try
            {
                string connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=flights.mdb";

                using (OleDbConnection conn = new OleDbConnection(connectionString))
                {
                    conn.Open();

                    string reservation = "INSERT INTO Reservation (FlightNo, Departing, Arriving, Date, Time, SeatClass, BookingReference, PassengerName, PassengerEmail) " +
                        "VALUES (" + flightNoValue.Text + ", " + departingValue.Text + ", " + arrivingValue.Text + ", " + dateValue.Text + ", " + timeValue.Text + ", " + seatValue.Text + ", " + flightNoValue.Text + referenceNumber + seatValue.Text + ", " + nameTextBox.Text + ", " + emailTextBox.Text + ")";
                    OleDbCommand query = new OleDbCommand(reservation, conn);
                    MessageBox.Show("query: " + reservation);

                    query.ExecuteNonQuery();
                    

                    /*
                     string reservation = "INSERT INTO Reservation "
                                    + "(FlightNo, Departing, Arriving, Date, Time, SeatClass, BookingReference, PassengerName, PassengerEmail) "
                                    + "VALUES (@FlightNo, @Departing, @Arriving, @Date, @Time, @SeatClass, @BookingRefernce, @PassengerName, @PassengerEmail)";

                    OleDbCommand insertCommand = new OleDbCommand(reservation, conn);
                    OleDbDataAdapter adapter = new OleDbDataAdapter(new OleDbCommand(insertCommand.ToString())); ;

                    // insertCommand.Parameters.Add("@ID", OleDbType.Integer).Value = 1;
                    insertCommand.Parameters.Add("@FlightNo", OleDbType.Char).Value = flightNoValue.Text;
                    insertCommand.Parameters.Add("@Departing", OleDbType.Char).Value = departingValue.Text;
                    insertCommand.Parameters.Add("@Arriving", OleDbType.Char).Value = arrivingValue.Text;
                    insertCommand.Parameters.Add("@Date", OleDbType.Date).Value = dateValue.Text;
                    insertCommand.Parameters.Add("@Time", OleDbType.Char).Value = timeValue.Text;
                    insertCommand.Parameters.Add("@SeatClass", OleDbType.Char).Value = seatValue.Text;
                    insertCommand.Parameters.Add("@BookingReference", OleDbType.Char).Value = referenceNumber;
                    insertCommand.Parameters.Add("@PassengerName", OleDbType.Char).Value = nameTextBox.Text;
                    insertCommand.Parameters.Add("@PassengerEmail", OleDbType.Char).Value = emailTextBox.Text;

                    MessageBox.Show("query: " + reservation);

                    conn.Open();
                    insertCommand.ExecuteNonQuery();
                    */

                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Booking Failed: \n" + ex);
            }
        }
    }
}
