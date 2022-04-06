using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RockPaperScissorsWinForm
{
    public partial class Form2 : Form
    {
        public string initiate { get; set; }

        public Form2(string Initiate)
        {
            InitializeComponent();
            initiate = Initiate;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CreateNewUserButton_Click(object sender, EventArgs e)
        {
            //Behöver en SQL Kod här; ska titta i konsollappen och implantera saker därifrån

            if (UsernameTextBox.Text == "")
            {
                MessageBox.Show("You are missing an Username for your account.");
            }
            if (PasswordTextBox.Text == "")
            {
                MessageBox.Show("You are missing a Password for your account.");
            }
            if (FirstNameTextBox.Text == "")
            {
                MessageBox.Show("Your first name is missing.");
            }
            if (LastNameTextBox.Text == "")
            {
                MessageBox.Show("Your last name is missing.");
            }
            else
            {
                MessageBox.Show("Account creation successful!");
                Close();
            }

        }
    }
}
