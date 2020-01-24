﻿using System;
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
                    /*
                    string reservation = "INSERT INTO Reservation (FlightNo, Departing, Arriving, Date, Time, SeatClass, BookingReference, PassengerName, PassengerEmail) " +
                        "VALUES (" + flightNoValue.Text + ", " + departingValue.Text + ", " + arrivingValue.Text + ", " + dateValue.Text + ", " + timeValue.Text + ", " + seatValue.Text + ", " + flightNoValue.Text + referenceNumber + seatValue.Text + ", " + nameTextBox.Text + ", " + emailTextBox.Text + ")";
                    OleDbCommand query = new OleDbCommand(reservation, conn);
                    MessageBox.Show("query: " + reservation);

                    query.ExecuteNonQuery();
                    */

                   

                   string reservation = "INSERT INTO Reservation "
                                    + "(FlightNo, Departing, Arriving, [Date], [Time], SeatClass, BookingReference, PassengerName, PassengerEmail) "
                                    + "VALUES (@FlightNo, @Departing, @Arriving, @Date, @Time, @SeatClass, @BookingReference, @PassengerName, @PassengerEmail)";

                    OleDbCommand insertCommand = new OleDbCommand(reservation, conn);
                    insertCommand.CommandType = CommandType.Text;

                    // insertCommand.Parameters.AddWithValue("ID", OleDbType.Integer).Value = 1;
                    insertCommand.Parameters.AddWithValue("FlightNo", this.flightNoValue.Text);
                    insertCommand.Parameters.AddWithValue("Departing", this.departingValue);
                    insertCommand.Parameters.AddWithValue("Arriving", this.arrivingValue.Text);
                    insertCommand.Parameters.AddWithValue("Date", this.dateValue.Text);
                    insertCommand.Parameters.AddWithValue("Time", this.timeValue.Text);
                    insertCommand.Parameters.AddWithValue("SeatClass", this.seatValue.Text);
                    insertCommand.Parameters.AddWithValue("BookingReference", referenceNumber);
                    insertCommand.Parameters.AddWithValue("PassengerName", this.nameTextBox.Text);
                    insertCommand.Parameters.AddWithValue("PassengerEmail", this.emailTextBox.Text);
                    OleDbDataAdapter adapter = new OleDbDataAdapter(insertCommand);
                    adapter.InsertCommand = insertCommand;

                    MessageBox.Show("query: " + insertCommand);

                    insertCommand.ExecuteNonQuery();
                    conn.Close();
                    

                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Booking Failed: \n" + ex);
            }
        }
    }
}
