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

        public partial class Form2 : Form
        {
            public string Initiate { get; set; }

            string connectionstring = "Server=localhost;Database=RockPaperScissor;Trusted_Connection=True";

            public Form2(string initiate)
            {
                InitializeComponent();
            }

            private void CancelButton_Click(object sender, EventArgs e)
            {
                Close();
            }

            private void CreateNewUserButton_Click(object sender, EventArgs e)
            {
                try
                {

                using (SqlConnection connect = new SqlConnection
                (connectionstring)) //Öppnar koppling till SQL Server
                {
                    connect.Open();

                    using (SqlCommand cmd = new SqlCommand
                    ("[Procedure_UserAdd]", connect))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@UserName", UserNameTextBox.Text);
                        cmd.Parameters.AddWithValue("@FirstName", FirstNameTextBox.Text);
                        cmd.Parameters.AddWithValue("@LastName", LastNameTextBox.Text);
                        cmd.Parameters.AddWithValue("@Passwordhash", PasswordTextBox.Text);
                        cmd.Parameters.AddWithValue("@UserEmail", EmailTextBox.Text);
                        cmd.Parameters.AddWithValue("@Token", "N/A");
                        cmd.Parameters.AddWithValue("@TokenIssued", DateTime.Now);
                        cmd.Parameters.AddWithValue("@Wins", 0);
                        cmd.Parameters.AddWithValue("@Losses", 0);
                        cmd.Parameters.AddWithValue("@GamesPlayed", 0);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Account Created!");
                        Close();


                       
                    }

                    connect.Close();
                }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex.Message);
                }


            }

            private void Form2_Load(Object sender, EventArgs e)
            {
    
            }




        }

}
