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
    public partial class bookFlight : Form
    {

        OleDbConnection connection = new OleDbConnection();
        string connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=flights.mdb";
        
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

            this.seatMenu.SelectedIndex = 0;

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



                    //string strSqlDepart = "SELECT DISTINCT Departing FROM Schedule";
                    //string strSqlArrive = "SELECT DISTINCT Arriving FROM Schedule WHERE Departing = @DepartVar";
                    //string strSqlDate = "SELECT DISTINCT Date FROM Schedule WHERE Departing = @DepartVar AND Arriving = @ArriveVar";
                    ////string strSqlTime = "SELECT DISTINCT Time FROM Schedule WHERE Departing = @DepartVar AND Arriving = @ArriveVar AND Date = @DateVar";
                    //this.departingMenu.Text = "DUB";

                    ///*
                    //string strSqlDate = "SELECT Date FROM Schedule WHERE Departing =" + " '" + departingMenu.Text + "' AND Arriving = '" + arrivingMenu.Text + "'";
                    //string strSqlTime = "SELECT Time FROM Schedule WHERE Departing =" + " '" + departingMenu.Text + "' AND Arriving = '" + arrivingMenu.Text + "' AND Date = '" + dateMenu.Text + "'";*/

                    //OleDbDataAdapter adapter = new OleDbDataAdapter(new OleDbCommand(strSqlDepart, conn));

                    //OleDbCommand arrivalcommand = new OleDbCommand(strSqlArrive, conn);
                    //arrivalcommand.Parameters.AddWithValue("DepartVar", this.departingMenu.Text);
                    //OleDbDataAdapter adapter1 = new OleDbDataAdapter(arrivalcommand);

                    //OleDbCommand datecommand = new OleDbCommand(strSqlDate, conn);

                    //datecommand.Parameters.AddWithValue("DepartVar", this.departingMenu.Text);
                    //datecommand.Parameters.AddWithValue("ArriveVar", this.arrivingMenu.Text);
                    //OleDbDataAdapter adapter2 = new OleDbDataAdapter(datecommand);        
                    ////OleDbCommand timecommand = new OleDbCommand(strSqlTime, conn);

                    ////timecommand.Parameters.AddWithValue("DepartVar", this.departingMenu.Text);
                    ////timecommand.Parameters.AddWithValue("ArriveVar", this.arrivingMenu.Text);
                    ////timecommand.Parameters.AddWithValue("DateVar", this.dateMenu.Text);
                    ////OleDbDataAdapter adapter3 = new OleDbDataAdapter(timecommand);

                    //DataTable departures = new DataTable();
                    //adapter.Fill(departures);
                    //departingMenu.DataSource = departures;
                    //departingMenu.DisplayMember = "Departing";
                    //departingMenu.ValueMember = "Departing";
                    //departingMenu.SelectedIndex = 1;

                    //DataTable arrivals = new DataTable();
                    //adapter1.Fill(arrivals);
                    //arrivingMenu.DataSource = arrivals;
                    //arrivingMenu.DisplayMember = "Arriving";
                    //arrivingMenu.ValueMember = "Arriving";


                    //DataTable dates = new DataTable();
                    //adapter2.Fill(dates);
                    //dateMenu.DataSource = dates;
                    //dateMenu.DisplayMember = "Date";
                    //dateMenu.ValueMember = "Date";

                    ////DataTable times = new DataTable();
                    ////adapter3.Fill(times);
                    ////timeMenu.DataSource = times;
                    ////timeMenu.DisplayMember = "Time";
                    ////timeMenu.ValueMember = "Time";

                    MessageBox.Show("Connected");

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
                    string strSqlArrive = "SELECT DISTINCT Arriving FROM Schedule WHERE Departing = @DepartVar";
                    OleDbCommand arrivecommand = new OleDbCommand(strSqlArrive, conn);
                    arrivecommand.Parameters.AddWithValue("DepartVar", this.departingMenu.Text);
                    OleDbDataAdapter adapter1 = new OleDbDataAdapter(arrivecommand);
                    DataTable arrivals = new DataTable();
                    adapter1.Fill(arrivals);
                    this.arrivingMenu.DataSource = arrivals;
                    this.arrivingMenu.DisplayMember = "Arriving";
                    this.arrivingMenu.ValueMember = "Arriving";
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
           // MessageBox.Show("Departing: " + this.departingMenu.Text + " & Arriving: " + this.arrivingMenu.Text);
            try
            {
                using (OleDbConnection conn = new OleDbConnection(connectionString))
                {
                    conn.Open();
                    
                    // get dates
                    string strSqlDate = "SELECT DISTINCT Date FROM Schedule WHERE Departing = @DepartVar AND Arriving = @ArriveVar";
                    OleDbCommand datecommand = new OleDbCommand(strSqlDate, conn);
                    datecommand.Parameters.AddWithValue("DepartVar", this.departingMenu.Text);
                    datecommand.Parameters.AddWithValue("ArriveVar", this.arrivingMenu.Text);
                    OleDbDataAdapter adapter2 = new OleDbDataAdapter(datecommand);
                    DataTable dates = new DataTable();
                    adapter2.Fill(dates);
                    this.dateMenu.DataSource = dates;
                    this.dateMenu.DisplayMember = "Date";
                    this.dateMenu.ValueMember = "Date";

                    // get times
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
                    string strSqlFlightNo = "SELECT DISTINCT FlightNo FROM Schedule WHERE ID = @IdVar";
                    OleDbCommand flightnocommand = new OleDbCommand(strSqlFlightNo, conn);
                    flightnocommand.Parameters.AddWithValue("IdVar", this.idComboBox.Text);
                    OleDbDataAdapter flightnoadapter = new OleDbDataAdapter(flightnocommand);
                    DataTable fightnoset = new DataTable();
                    flightnoadapter.Fill(fightnoset);
                    this.flightNoComboBox.DataSource = fightnoset;
                    this.flightNoComboBox.DisplayMember = "FlightNo";
                    this.flightNoComboBox.ValueMember = "FlightNo";

                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
   
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to exit to the home screen?", "Confirm", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                connection.Close();                
                this.Close();
            }
        }

        private void continueBtn_Click(object sender, EventArgs e)
        {
            idStore = idComboBox.Text;
            flightNoStore = flightNoComboBox.Text;
            departStore = departingMenu.Text;
            arriveStore = arrivingMenu.Text;
            dateStore = dateMenu.Text;
            timeStore = timeMenu.Text;
            seatStore = seatMenu.Text;

            confirmBooking cB = new confirmBooking();
            cB.Show();

        }
    }
}
