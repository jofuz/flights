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
    public partial class adminPassword : Form
    {
        public adminPassword()
        {
            InitializeComponent();
        }

        private void confirmPasswordBtn_Click(object sender, EventArgs e)
        {
            // set admin password
            string adminPassword = "admin";

            // check if the value in the Text Box is the same as the admin password
            if (adminPasswordBox.Text != adminPassword)
            {
                // fill empty label with this string if the text is not equal to the admin password
                wrongPasswordNote.Text = "Wrong password! Try again.";
            }
            else {
                // open admin screen if the password is correct
                adminScreen aS = new adminScreen();
                aS.Show();
                this.Close();
            }

        }

        private void returnToHomeBtn_Click(object sender, EventArgs e)
        {
            // return to home screen
            homeScreen hS = new homeScreen();
            hS.Show();
            this.Hide();
        }
    }
}
