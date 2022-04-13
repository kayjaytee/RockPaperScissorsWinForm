using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.IO;

namespace RockPaperScissorsWinForm
{
    public partial class Form4 : Form
    {
        private SqlConnection connect = new SqlConnection();
        private StreamReader strReader;
        private StreamWriter strWriter;
        private string recieve;
        private string textToSend;


        string[] moves = new string[3]
        { "scissors", "papers", "rock" };
        string playerOneMove = "", playerTwoMove = "";


        public Form4(long loggedInUserID)
        {
            InitializeComponent();

        }

        private void PlayerOneChoice(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {
       

        }

        private void SendMessageTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }


        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            /*while(true)
            {
                try
                {
                    recieve = strReader.ReadLine();
                    this.richChatTextBox.Invoke(new MethodInvoker(delegate ()
                    {
                        richChatTextBox.AppendText("Opponent: " + recieve + "\n");
                    }));
                    recieve = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }*/
        }

        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {
            //if ()
            //{

            //    strWriter.WriteLine(textToSend);
            //    this.SendMessageTextBox.Invoke(new MethodInvoker(delegate ()
            //    {
            //        richChatTextBox.AppendText("You: " + textToSend + "\n");
            //    }));
            //}
            //else
            //{
            //    MessageBox.Show("Sending Failed");
            //}

            //backgroundWorker2.CancelAsync();
        }

        private void SendMessageButton_Click(object sender, EventArgs e)
        {
            if (SendMessageTextBox.Text != "")
            {
                textToSend = SendMessageTextBox.Text;
                backgroundWorker2.RunWorkerAsync();
            }
            SendMessageTextBox.Text = "";
        }

        private void chooseRockButton_Click(object sender, EventArgs e)
        {
            playerOneMove = "rock";
            picLeftHidden.Visible = false;
            picLeftPaper.Visible = false;
            picLeftRock.Visible = true;
            picLeftScissor.Visible = false;
        }

        private void choosePaperButton_Click(object sender, EventArgs e)
        {
            playerOneMove = "paper";
            picLeftHidden.Visible = false;
            picLeftPaper.Visible = true;
            picLeftRock.Visible = false;
            picLeftScissor.Visible = false;
        }

        private void chooseScissorButton_Click(object sender, EventArgs e)
        {
            playerOneMove = "scissor";
            picLeftHidden.Visible = false;
            picLeftPaper.Visible = false;
            picLeftRock.Visible = false;
            picLeftScissor.Visible = true;
        }
    }
}
