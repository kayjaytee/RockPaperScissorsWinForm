using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.IO;

namespace RockPaperScissorsWinForm.Forms
{
    public partial class Form4 : Form
    {


        private StreamReader strReader;
        private StreamWriter strWriter;
        private string recieve;
        private string textToSend;

        public Form4()
        {
            InitializeComponent();

            //strReader = new StreamReader(/*THIS ROOM*/);
            //strWriter = new StreamWriter(/*THIS ROOM*/);
            strWriter.AutoFlush = true;
            backgroundWorker1.RunWorkerAsync();
            backgroundWorker2.WorkerSupportsCancellation = true;
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void SendMessageTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            while(/*USER*/true)
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
            }
        }

        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {
            if (/*USER*/true)
            {

                strWriter.WriteLine(textToSend);
                this.SendMessageTextBox.Invoke(new MethodInvoker(delegate ()
                {
                    SendMessageTextBox.AppendText("You: " + textToSend + "\n");
                }));
            }
            else
            {
                MessageBox.Show("Sending Failed");
            }

            backgroundWorker2.CancelAsync();
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

        }

        private void choosePaperButton_Click(object sender, EventArgs e)
        {

        }

        private void chooseScissorButton_Click(object sender, EventArgs e)
        {

        }
    }
}
