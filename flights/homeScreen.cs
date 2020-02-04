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
            // open book flight page
            bookFlight bF = new bookFlight();
            bF.Show();
            this.Hide();
        }

        // open admin screen
        private void adminScreenBtn_Click(object sender, EventArgs e)
        {
            // open admin password page
            adminPassword aP = new adminPassword();
            aP.Show();
            this.Hide();
        }

        // force close application
        private void exitAppBtn_Click(object sender, EventArgs e)
        {
            // confirm if the user wants to cancel
            if (MessageBox.Show("Are you sure you want to exit the application?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void helpBtn_Click(object sender, EventArgs e)
        {
            //System.Diagnostics.Process.Start(@"help.txt");
            MessageBox.Show("Click the Book A Flight button or click the Admin Screen button.");
        }
    }
}
