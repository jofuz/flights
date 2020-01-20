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
    public partial class bookFlight : Form
    {
        public bookFlight()
        {
            InitializeComponent();
        }

        private void bookFlight_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'flightsDataSet.Schedule' table. You can move, or remove it, as needed.
            this.scheduleTableAdapter.Fill(this.flightsDataSet.Schedule);
            // TODO: This line of code loads data into the 'flightsDataSet.Schedule' table. You can move, or remove it, as needed.
            this.scheduleTableAdapter.Fill(this.flightsDataSet.Schedule);
            this.timeMenu.FormatString = "HH:mm";
            /*
            this.departingMenu.Items.AddRange(this.flightsDataSet.Schedule.AsEnumerable().Select(i => i.ItemArray[0]).Distinct().ToArray());
            this.arrivingMenu.Items.AddRange(this.flightsDataSet.Schedule.AsEnumerable().Select(i => i.ItemArray[1]).Distinct().ToArray());
            this.dateMenu.Items.AddRange(this.flightsDataSet.Schedule.AsEnumerable().Select(i => i.ItemArray[2]).Distinct().ToArray());
            this.timeMenu.Items.AddRange(this.flightsDataSet.Schedule.AsEnumerable().Select(i => i.ItemArray[3]).Distinct().ToArray());
            */
        }
    }
}
