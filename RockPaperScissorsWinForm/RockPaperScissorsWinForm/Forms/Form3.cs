using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RockPaperScissorsWinForm
{
    public partial class Form3 : Form
    {

        public string Initiate { get; set; }

        string connectionstring = "Server=localhost;Database=RockPaperScissor;Trusted_Connection=True";

        public Form3(string Initiate)
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void richStatisticsTextBox_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void LogOutButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void HostGameButton_Click(object sender, EventArgs e)
        {

        }
    }
}
