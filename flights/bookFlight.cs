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
using System.Diagnostics;

namespace flights
{
    public partial class bookFlight : Form
    {

        OleDbConnection connection = new OleDbConnection();
        string connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=flights.mdb";

        // declaring public static variables that will store the booking information to carry over to the confirm booking page.
        public static string idStore = "";
        public static string flightNoStore = "";
        public static string departStore = "";
        public static string arriveStore = "";
        public static string dateStore = "";
        public static string timeStore = "";
        public static string seatStore = "";

        public bookFlight()
        {
            InitializeComponent();
        }

        private void bookFlight_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'flightsDataSet.Schedule' table. You can move, or remove it, as needed.
            //this.scheduleTableAdapter.Fill(this.flightsDataSet.Schedule);
            // TODO: This line of code loads data into the 'flightsDataSet.Schedule' table. You can move, or remove it, as needed.
            //this.scheduleTableAdapter.Fill(this.flightsDataSet.Schedule);
            //this.timeMenu.FormatString = "HH:mm";

            try
            {
                using (OleDbConnection conn = new OleDbConnection(connectionString))
                {
                    conn.Open();

                    // select unique Departing airports from the schedule table
                    string strSqlDepart = "SELECT DISTINCT Departing FROM Schedule";
                    OleDbDataAdapter adapter = new OleDbDataAdapter(new OleDbCommand(strSqlDepart, conn)); ;
                    DataSet ds = new DataSet();

                    // fill the Departing ComboBox with the data from the Departing Column
                    adapter.Fill(ds);
                    departingMenu.DataSource = ds.Tables[0];
                    departingMenu.DisplayMember = "Departing";
                    departingMenu.ValueMember = "Departing";

                    // poplate the seat menu with the first item in the seat menu
                    this.seatMenu.SelectedIndex = 0;

                    Debug.WriteLine("Connected");

                    conn.Close();
                       
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Connection Failed: \n" + ex);
            }
       
        }

        // when destination is selected, query the database for matching arrival airports
        private void departingMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show("Departing: " + this.departingMenu.Text);
            try
            {
                using (OleDbConnection conn = new OleDbConnection(connectionString))
                {
                    conn.Open();

                    // get arrivals
                    // select a distinc arriving airport from the same row as the departing airport that was selected
                    string strSqlArrive = "SELECT DISTINCT Arriving FROM Schedule WHERE Departing = @DepartVar";
                    OleDbCommand arrivecommand = new OleDbCommand(strSqlArrive, conn);

                    // add a variable to the query string
                    arrivecommand.Parameters.AddWithValue("DepartVar", this.departingMenu.Text);
                    OleDbDataAdapter adapter1 = new OleDbDataAdapter(arrivecommand);
                    DataTable arrivals = new DataTable();
                    adapter1.Fill(arrivals);
                    this.arrivingMenu.DataSource = arrivals;
                    this.arrivingMenu.DisplayMember = "Arriving";
                    this.arrivingMenu.ValueMember = "Arriving";
                    conn.Close();

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        // find the matching dates and times for selected airports
        private void arrivingMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                using (OleDbConnection conn = new OleDbConnection(connectionString))
                {
                    conn.Open();
                    
                    // get dates
                    // get dates from the same row as the chosen departure and arrival airports
                    string strSqlDate = "SELECT DISTINCT Date FROM Schedule WHERE Departing = @DepartVar AND Arriving = @ArriveVar";
                    OleDbCommand datecommand = new OleDbCommand(strSqlDate, conn);
                    // using variables helps to keep the query string short and easier to read
                    datecommand.Parameters.AddWithValue("DepartVar", this.departingMenu.Text);
                    datecommand.Parameters.AddWithValue("ArriveVar", this.arrivingMenu.Text);
                    OleDbDataAdapter adapter2 = new OleDbDataAdapter(datecommand);
                    DataTable dates = new DataTable();
                    adapter2.Fill(dates);
                    this.dateMenu.DataSource = dates;
                    this.dateMenu.DisplayMember = "Date";
                    this.dateMenu.ValueMember = "Date";

                    // get times
                    // get dates from the same row as the chosen departing, arrival and dates
                    string strSqlTime = "SELECT DISTINCT Time FROM Schedule WHERE Departing = @DepartVar AND Arriving = @ArriveVar AND Date = @DateVar";
                    OleDbCommand timecommand = new OleDbCommand(strSqlTime, conn);
                    timecommand.Parameters.AddWithValue("DepartVar", this.departingMenu.Text);
                    timecommand.Parameters.AddWithValue("ArriveVar", this.arrivingMenu.Text);
                    timecommand.Parameters.AddWithValue("DateVar", this.dateMenu.Text);
                    OleDbDataAdapter adapter3 = new OleDbDataAdapter(timecommand);
                    DataTable times = new DataTable();
                    adapter3.Fill(times);
                    this.timeMenu.DataSource = times;
                    this.timeMenu.DisplayMember = "Time";
                    this.timeMenu.ValueMember = "Time";

                    // get id
                    // get ID from chosen fields, this is used to carry the flight information over to the next page 
                    string strSqlId = "SELECT DISTINCT ID FROM Schedule WHERE Departing = @DepartVar AND Arriving = @ArriveVar AND Date = @DateVar AND Time = @TimeVar";
                    OleDbCommand idcommand = new OleDbCommand(strSqlId, conn);
                    idcommand.Parameters.AddWithValue("DepartVar", this.departingMenu.Text);
                    idcommand.Parameters.AddWithValue("ArriveVar", this.arrivingMenu.Text);
                    idcommand.Parameters.AddWithValue("DateVar", this.dateMenu.Text);
                    idcommand.Parameters.AddWithValue("TimeVar", this.timeMenu.Text);
                    OleDbDataAdapter idadapter = new OleDbDataAdapter(idcommand);
                    DataTable idSet = new DataTable();
                    idadapter.Fill(idSet);
                    this.idComboBox.DataSource = idSet;
                    this.idComboBox.DisplayMember = "ID";
                    this.idComboBox.ValueMember = "ID";

                    // get flight number
                    // get Flight Number from chosen fields, this is used to carry the flight information over to the next page 
                    string strSqlFlightNo = "SELECT DISTINCT FlightNo FROM Schedule WHERE ID = @IdVar";
                    OleDbCommand flightnocommand = new OleDbCommand(strSqlFlightNo, conn);
                    flightnocommand.Parameters.AddWithValue("IdVar", this.idComboBox.Text);
                    OleDbDataAdapter flightnoadapter = new OleDbDataAdapter(flightnocommand);
                    DataTable fightnoset = new DataTable();
                    flightnoadapter.Fill(fightnoset);
                    this.flightNoComboBox.DataSource = fightnoset;
                    this.flightNoComboBox.DisplayMember = "FlightNo";
                    this.flightNoComboBox.ValueMember = "FlightNo";

                    // check for seat availabilty
                    checkSeats();

                    // display selected flight in debug console
                    Debug.WriteLine("------------------------------- Flight --------------------------------\n" + 
                        "FlightNo: " + this.flightNoComboBox.Text + " Departing: " + this.departingMenu.Text + " & Arriving: " + this.arrivingMenu.Text + " Date: " +this.dateMenu.Text + " Time: " + this.timeMenu.Text 
                        + "\n ---------------------------------------------------------------------------");

                    // close connection to database
                    conn.Close();
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
   
        }

        // this brings the user to the home screen
        private void cancelBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to exit to the home screen?", "Confirm", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                connection.Close();

                homeScreen hS = new homeScreen();
                hS.Show();
                this.Close();
            }
        }

        // check for available seats
        private void checkSeats()
        {
            // clear seats list before trying query to avoid duplications
            seatMenu.Items.Clear();
            try
            {
                using (OleDbConnection conn = new OleDbConnection(connectionString))
                {
                    conn.Open();
                    string seatcheckquery = "SELECT * FROM Schedule WHERE FlightNo = '" + flightNoComboBox.Text + "';";
                    using (OleDbCommand cmd = new OleDbCommand(seatcheckquery, conn))
                    {
                        DataTable dt = new DataTable();
                        dt.Load(cmd.ExecuteReader());
                        DataRow row = dt.Rows[0];

                        // store each column value in a variable and convert to int
                        int economy = Convert.ToInt32(row.ItemArray.GetValue(6));
                        int business = Convert.ToInt32(row.ItemArray.GetValue(7));
                        int first = Convert.ToInt32(row.ItemArray.GetValue(8));

                        // if the seats are available show them in the seats combobox
                        if (economy > 0)
                        {
                            seatMenu.Items.Add("Economy");
                        }
                        if (business > 0) {
                            seatMenu.Items.Add("Business");
                        }
                        if (first > 0) {
                            seatMenu.Items.Add("First");
                        }
                        // display seat 
                        Debug.WriteLine("------------- Available Seats ---------------- \n" + 
                            "Economy: 5" + economy +  " Business: " + business + " First: " + first + 
                            "\n ---------------------------------------");
                    }


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        // continue to confirm booking screen
        private void continueBtn_Click(object sender, EventArgs e)
        {
            // storing flight info
            idStore = idComboBox.Text;
            flightNoStore = flightNoComboBox.Text;
            departStore = departingMenu.Text;
            arriveStore = arrivingMenu.Text;
            dateStore = dateMenu.Text;
            timeStore = timeMenu.Text;
            seatStore = seatMenu.Text;

            // open confirm booking page
            confirmBooking cB = new confirmBooking();
            cB.Show();
            this.Close();

        }
    }
}
