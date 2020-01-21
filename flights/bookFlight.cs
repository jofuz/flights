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
        string queryString;
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

                    string idText = "ID";
                    string flightNoText = "FlightNo";
                    string departText = "Departing";
                    string arriveText = "Arriving";
                    string dateText = "Date";
                    string timeText = "Time";


                    string strSqlDepart = "SELECT DISTINCT Departing FROM Schedule";
                    string strSqlArrive = "SELECT Arriving FROM Schedule WHERE Arriving = '" + arrivingMenu.Text + "'";
                    string strSqlDate = "SELECT DISTINCT Date FROM Schedule";
                    string strSqlTime = "SELECT DISTINCT Time FROM Schedule";

                    OleDbDataAdapter adapter = new OleDbDataAdapter(new OleDbCommand(strSqlDepart, conn)); ;
                    OleDbDataAdapter adapter1 = new OleDbDataAdapter(new OleDbCommand(strSqlArrive, conn)); ;
                    OleDbDataAdapter adapter2 = new OleDbDataAdapter(new OleDbCommand(strSqlDate, conn)); ;
                    OleDbDataAdapter adapter3 = new OleDbDataAdapter(new OleDbCommand(strSqlTime, conn)); ;

                    DataSet ds = new DataSet();

                    adapter.Fill(ds);
                    departingMenu.DataSource = ds.Tables[0];
                    departingMenu.DisplayMember = "Departing";
                    departingMenu.ValueMember = "Departing";

                    adapter1.Fill(ds);
                    arrivingMenu.DataSource = ds.Tables[0];
                    arrivingMenu.DisplayMember = "Arriving";
                    arrivingMenu.ValueMember = "Arriving";

                    adapter2.Fill(ds);
                    dateMenu.DataSource = ds.Tables[0];
                    dateMenu.DisplayMember = "Date";
                    dateMenu.ValueMember = "Date";

                    adapter3.Fill(ds);
                    timeMenu.DataSource = ds.Tables[0];
                    timeMenu.DisplayMember = "Time";
                    timeMenu.ValueMember = "Time";
                    
                    MessageBox.Show("Connected");

                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Connection Failed: \n" + ex);
            }
        }
    }
}
