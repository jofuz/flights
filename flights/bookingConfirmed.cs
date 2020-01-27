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
            homeScreen hS = new homeScreen();
            hS.Show();
            this.Close();
        }

        private void bookAFlightBtn_Click(object sender, EventArgs e)
        {
            bookFlight bF = new bookFlight();
            bF.Show();
            this.Close();
        }
    }
}
