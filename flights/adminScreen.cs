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
           //  this.scheduleTableAdapter.Connection.Close();
        }

        // save changes made to the Schedule table
        private void saveChangesBtn_Click(object sender, EventArgs e)
        {
            try
            {
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

        // cancel changes currently being made
        private void cancelButton_Click(object sender, EventArgs e)
        {
            // confirm if the user wants to cancel
            if (MessageBox.Show("Do you want to cancel all changes?", "Confirm", MessageBoxButtons.OKCancel) == DialogResult.OK)
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
    }
}
