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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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

        private void Form1_Load(object sender, EventArgs e) {
            LoadData();
        }
        // set connection
        private void SetConnection() {
            sql_con = new SQLiteConnection("Data Source=flights.db;Version=3;New=false;Compress=True");
        }

        // set execute query
        private void ExecuteQuery(string textQuery) {
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
        private void LoadData() {
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
        }
    }
}
