using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace flights
{
    public partial class bookingConfirmed : Form
    {
        public bookingConfirmed()
        {
            InitializeComponent();
        }

        private void bookingConfirmed_Load(object sender, EventArgs e)
        {
            // load the static variables which contain the booking info

            bookingRefValue.Text = confirmBooking.refStore;
            nameValue.Text = confirmBooking.nameStore;
            emailValue.Text = confirmBooking.emailStore;
            departingValue.Text = bookFlight.departStore;
            arrivingValue.Text = bookFlight.arriveStore;
            dateValue.Text = bookFlight.dateStore;
            timeValue.Text = bookFlight.timeStore;
            seatValue.Text = bookFlight.seatStore;
        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            // return to home screen
            homeScreen hS = new homeScreen();
            hS.Show();
            this.Close();
        }

        private void bookAFlightBtn_Click(object sender, EventArgs e)
        {
            // go to book a flight screen
            bookFlight bF = new bookFlight();
            bF.Show();
            this.Close();
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
            MessageBox.Show("If you want to book a return or follow on flight, click the Book A Flight button.");
        }
    }
}
