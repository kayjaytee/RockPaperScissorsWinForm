using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;


namespace RockPaperScissorsWinForm
{
    public partial class Form1 : Form
    {

        string connectionstring = "Server=localhost;Database=RockPaperScissor;Trusted_Connection=True";
        public Form1()
        {
        
            InitializeComponent();
           

        }

        private void CreateNewUserButton_Click(object sender, EventArgs e)
        {
            Form2_Load(sender, e);
        }

        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            if (UserNameTextBox.Text == "")
            {
                MessageBox.Show("Enter your Username, please");
            }
            else if (PasswordTextBox.Text == "")
            {
                MessageBox.Show("Enter your Password, please");
            }
            else
            {
                try
                {

                    using (SqlConnection connect = new SqlConnection //Öppnar koppling till SQL Server
                    (connectionstring))
                    {
                        connect.Open();

                        using (SqlCommand cmd = new SqlCommand //Skickar en förfrågan till SQL Server
                        ("SELECT * FROM [User] WHERE [UserName] = @username AND [PasswordHash] =  @passwordhash", connect))
                        {
                            cmd.Parameters.AddWithValue("@username", UserNameTextBox.Text);
                            cmd.Parameters.AddWithValue("@passwordhash", PasswordTextBox.Text);
                        
                            using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                            { //Datatable tillåter hämtning och formgivning av databasen; adapter är bryggan för att kommunikationen ska fungera.
                                using (DataTable datatable = new DataTable())
                                {
                                    adapter.Fill(datatable);

                                    if (datatable.Rows.Count > 0)
                                    {
                                        MessageBox.Show("Login Successfull");
                                    }
                                    else
                                    {
                                        MessageBox.Show("Login Failed. Your username or password could not be found");
                                    }
                                }
                            }
                        }
                       
                        connect.Close();
                    }     
                        
                } 
                
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex.Message);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Form2 form2 = new Form2("");
            form2.Initiate = "";
            form2.ShowDialog(this);
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }

}