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

            // set default format for time cell to 24 hour clock
            this.timeDataGridViewTextBoxColumn.DefaultCellStyle.Format = "HH:mm";

            // daatagridview causes wait cursor become stuck, this will reset cursor to default
            Application.UseWaitCursor = false;
            dataGridView1.Cursor = null;

        }

        // save changes made to the Schedule table
        private void saveChangesBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to Save Changes?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    this.Validate();
                    this.scheduleBindingSource.EndEdit();
                    this.scheduleTableAdapter.Update(this.flightsDataSet);

                    MessageBox.Show("Update Successful");

                    this.scheduleTableAdapter.Fill(this.flightsDataSet.Schedule);

                    // set default format for time cell to 24 hour clock
                    this.timeDataGridViewTextBoxColumn.DefaultCellStyle.Format = "HH:mm";
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show("Update Failed: \n" + ex);
                }
            }
        }

        // cancel changes currently being made
        private void cancelButton_Click(object sender, EventArgs e)
        {
            // confirm if the user wants to cancel
            if (MessageBox.Show("Do you want to cancel all changes?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                scheduleBindingSource.CancelEdit();
                this.scheduleTableAdapter.Fill(this.flightsDataSet.Schedule);
                MessageBox.Show("Changes Cancelled");
            }
        }

        // return to home screen
        private void exitBtn_Click(object sender, EventArgs e)
        {
            homeScreen hS = new homeScreen();
            hS.Show();
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
            MessageBox.Show("You can create, edit and delete records from the flight schedule.\n" 
                + "Click Add New to create a new record." 
                + "Enter the data into the text fields at the bottom of the screen and click the Save Changes button to save the new flight record.");
        }
    }
}
