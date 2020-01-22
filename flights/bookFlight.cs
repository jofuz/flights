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
        
        OleDbDataAdapter myAdapter = new OleDbDataAdapter();

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
                    /* string strSql = "SELECT DISTINCT ID, FlightNo, Arriving, Departing, Date, Time FROM Schedule ORDER BY ID";

                     OleDbDataAdapter adapter = new OleDbDataAdapter(new OleDbCommand(strSql, conn)); ;
                     DataSet ds = new DataSet();

                     adapter.Fill(ds);
                     departingMenu.DataSource = ds.Tables[0];
                     departingMenu.DisplayMember = "Departing";
                     departingMenu.ValueMember = "Departing";

                     arrivingMenu.DataSource = ds.Tables[0];
                     arrivingMenu.DisplayMember = "Arriving";
                     arrivingMenu.ValueMember = "Arriving";

                     dateMenu.DataSource = ds.Tables[0];
                     dateMenu.DisplayMember = "Date";
                     dateMenu.ValueMember = "Date";

                     timeMenu.DataSource = ds.Tables[0];
                     timeMenu.DisplayMember = "Time";
                     timeMenu.ValueMember = "Time";
                     */


                    string strSqlDepart = "SELECT DISTINCT Departing FROM Schedule";
                    string strSqlArrive = "SELECT DISTINCT Arriving FROM Schedule WHERE Departing = @DepartVar";
                    string strSqlDate = "SELECT DISTINCT Date FROM Schedule WHERE Departing = @DepartVar AND Arriving = @ArriveVar";
                    //string strSqlTime = "SELECT DISTINCT Time FROM Schedule WHERE Departing = @DepartVar AND Arriving = @ArriveVar AND Date = @DateVar";
                    this.departingMenu.Text = "DUB";

                    /*
                    string strSqlDate = "SELECT Date FROM Schedule WHERE Departing =" + " '" + departingMenu.Text + "' AND Arriving = '" + arrivingMenu.Text + "'";
                    string strSqlTime = "SELECT Time FROM Schedule WHERE Departing =" + " '" + departingMenu.Text + "' AND Arriving = '" + arrivingMenu.Text + "' AND Date = '" + dateMenu.Text + "'";*/

                    OleDbDataAdapter adapter = new OleDbDataAdapter(new OleDbCommand(strSqlDepart, conn));

                    OleDbCommand arrivalcommand = new OleDbCommand(strSqlArrive, conn);
                    arrivalcommand.Parameters.AddWithValue("DepartVar", this.departingMenu.Text);
                    OleDbDataAdapter adapter1 = new OleDbDataAdapter(arrivalcommand);

                    OleDbCommand datecommand = new OleDbCommand(strSqlDate, conn);
                  
                    datecommand.Parameters.AddWithValue("DepartVar", this.departingMenu.Text);
                    datecommand.Parameters.AddWithValue("ArriveVar", this.arrivingMenu.Text);
                    OleDbDataAdapter adapter2 = new OleDbDataAdapter(datecommand);        
                    //OleDbCommand timecommand = new OleDbCommand(strSqlTime, conn);
                   
                    //timecommand.Parameters.AddWithValue("DepartVar", this.departingMenu.Text);
                    //timecommand.Parameters.AddWithValue("ArriveVar", this.arrivingMenu.Text);
                    //timecommand.Parameters.AddWithValue("DateVar", this.dateMenu.Text);
                    //OleDbDataAdapter adapter3 = new OleDbDataAdapter(timecommand);

                    DataTable departures = new DataTable();
                    adapter.Fill(departures);
                    departingMenu.DataSource = departures;
                    departingMenu.DisplayMember = "Departing";
                    departingMenu.ValueMember = "Departing";
                    departingMenu.SelectedIndex = 1;

                    DataTable arrivals = new DataTable();
                    adapter1.Fill(arrivals);
                    arrivingMenu.DataSource = arrivals;
                    arrivingMenu.DisplayMember = "Arriving";
                    arrivingMenu.ValueMember = "Arriving";


                    DataTable dates = new DataTable();
                    adapter2.Fill(dates);
                    dateMenu.DataSource = dates;
                    dateMenu.DisplayMember = "Date";
                    dateMenu.ValueMember = "Date";

                    //DataTable times = new DataTable();
                    //adapter3.Fill(times);
                    //timeMenu.DataSource = times;
                    //timeMenu.DisplayMember = "Time";
                    //timeMenu.ValueMember = "Time";
                    
                    MessageBox.Show("Connected");

                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Connection Failed: \n" + ex);
            }
       
        }

        private void arrivingMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(this.departingMenu.Text + this.arrivingMenu.Text + "wtf");
            try
            {
                using (OleDbConnection conn = new OleDbConnection(connectionString))
                {
                    conn.Open();
                    string strSqlTime = "SELECT DISTINCT Time FROM Schedule WHERE Departing = @DepartVar AND Arriving = @ArriveVar";// AND Date = @DateVar";
                    OleDbCommand timecommand = new OleDbCommand(strSqlTime, conn);

                    timecommand.Parameters.AddWithValue("DepartVar", this.departingMenu.Text);
                    timecommand.Parameters.AddWithValue("ArriveVar", this.arrivingMenu.Text);
                    //timecommand.Parameters.AddWithValue("DateVar", this.dateMenu.Text);
                    OleDbDataAdapter adapter3 = new OleDbDataAdapter(timecommand);
                    DataTable times = new DataTable();
                    adapter3.Fill(times);
                    this.timeMenu.DataSource = times;
                    this.timeMenu.DisplayMember = "Time";
                   this.timeMenu.ValueMember = "Time";
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
   
        }


    }
}
