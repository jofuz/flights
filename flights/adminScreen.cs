using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace flights
{
    public partial class adminScreen : Form
    {
        public adminScreen()
        {
            InitializeComponent();
        }

        private void AdminScreen_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'flightsDataSet.Schedule' table. You can move, or remove it, as needed.
            this.scheduleTableAdapter.Fill(this.flightsDataSet.Schedule);
           // LoadData();
        }

        // decalare private varibales to interact with SQLite database
        // to be used for connection string
        private SQLiteConnection sql_con;
        // to be used for SQL queries
        private SQLiteCommand sql_cmd;
        // establish connection with Visual Studio data adapter
        private SQLiteDataAdapter DB;
        private DataSet DS = new DataSet();
        private DataTable DT = new DataTable();

        // set connection
        private void SetConnection()
        {
            // data source is relative to the executable file; using SQLite version 3;
            sql_con = new SQLiteConnection("Data Source=flights.db;Version=3");
        }

        // set execute query
        private void ExecuteQuery(string textQuery)
        {
            // call SetConnection method
            SetConnection();
            // open the SQL connection
            sql_con.Open();
            // create the SQL command
            sql_cmd = sql_con.CreateCommand();
            // sql command text is whatever is within the textQuery
            sql_cmd.CommandText = textQuery;
            sql_cmd.ExecuteNonQuery();
            // close connection to DB
            sql_con.Close();
        }

        // load the DB
        private void LoadData()
        {
            try
            {
                SetConnection();
                sql_con.Open();
                sql_cmd = sql_con.CreateCommand();

                // select all from the Schedule table
                string CommandText = "SELECT * FROM Schedule";

                DB = new SQLiteDataAdapter(CommandText, sql_con);
                DS.Reset();
                DB.Fill(DS);

                // Fill DataTable with the DataSet from the SQL DB Tables
                DT = DS.Tables[0];
                dataGridView1.DataSource = DT;
                sql_con.Close();

                MessageBox.Show("Data successfully loaded: \n");
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Failed to load data: \n" + ex);
            }
        }

        private void saveChangesBtn_Click(object sender, EventArgs e)
        {
            try
            {
                /* this.Validate();
                 this.DT.AcceptChanges();
                 DB.Update(this.DS);
                 DS.Reset();
                 DB.Fill(DS);
                 // Fill DataTable with the DataSet from the SQL DB Tables
                 DT = DS.Tables[0];
                 dataGridView1.DataSource = DT;*/
                this.Validate();
                this.scheduleBindingSource.EndEdit();
                this.scheduleTableAdapter.Update(this.flightsDataSet);
                MessageBox.Show("Update Successful");
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Update Failed: \n" + ex);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //flightNoBox.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
        }
    }
}
