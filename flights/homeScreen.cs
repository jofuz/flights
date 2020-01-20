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
    public partial class homeScreen : Form
    {
        public homeScreen()
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
            
        }

        // open booking screen
        private void bookFlightBtn_Click(object sender, EventArgs e)
        {
            bookFlight bF = new bookFlight();
            bF.Show();
        }

        // open admin screen
        private void adminScreenBtn_Click(object sender, EventArgs e)
        {
            adminPassword aP = new adminPassword();
            aP.Show();
        }
    }
}
