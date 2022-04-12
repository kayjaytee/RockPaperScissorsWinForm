using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RockPaperScissorsWinForm
{

    public partial class Form3 : Form
    {
        List <User> User {  get; set; }

        public string Initiate { get; set; }
        public long LoggedInUserID { get; }

        string connectionstring = "Server=localhost;Database=RockPaperScissor;Trusted_Connection=True";


        public Form3(long loggedInUserID)
        {
            this.LoggedInUserID = loggedInUserID;
            //User = GetUsersStats();
            InitializeComponent();
        }

        private List<User> GetUsersStats()
        {
            var list = new List<User>();
            /*list.Add(new User()
            {
                Username = "Person 1",
                Wins = 0,
                Losses = 0,
                GamesPlayed = 0
            });*/

            return list;
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void LogOutButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void HostGameButton_Click(object sender, EventArgs e)
        {
            
            Form4_Load(sender, e, LoggedInUserID);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e, long loggedInUserID)
        {
            Form4 form4 = new Form4(loggedInUserID);
            form4.ShowDialog(this);
        }


    }
}
