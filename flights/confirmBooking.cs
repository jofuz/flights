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
    public partial class confirmBooking : Form
    {
        public confirmBooking()
        {
            InitializeComponent();
        }

        private void confirmBooking_Load(object sender, EventArgs e)
        {
            flightNoLabel.Text = flightNoLabel.Text + " " + bookFlight.flightNoStore;
            departingLabel.Text = departingLabel.Text + " " + bookFlight.departStore;
            arrivingLabel.Text = arrivingLabel.Text + " " + bookFlight.arriveStore;
            dateLabel.Text = dateLabel.Text + " " + bookFlight.dateStore;
            timeLabel.Text = timeLabel.Text + " " + bookFlight.timeStore;
            seatLabel.Text = seatLabel.Text + " " + bookFlight.seatStore;



        }
    }
}
