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
        private void Form1_Load(object sender, EventArgs e) {
            
        }

        // open booking screen
        private void bookFlightBtn_Click(object sender, EventArgs e)
        {
            bookFlight bF = new bookFlight();
            bF.Show();
            this.Hide();
        }

        // open admin screen
        private void adminScreenBtn_Click(object sender, EventArgs e)
        {
            adminPassword aP = new adminPassword();
            aP.Show();
            this.Hide();
        }
    }
}
