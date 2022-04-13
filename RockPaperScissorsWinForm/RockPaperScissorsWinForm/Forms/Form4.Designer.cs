namespace RockPaperScissorsWinForm
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.richChatTextBox = new System.Windows.Forms.RichTextBox();
            this.SendMessageButton = new System.Windows.Forms.Button();
            this.SendMessageTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chooseRockButton = new System.Windows.Forms.Button();
            this.choosePaperButton = new System.Windows.Forms.Button();
            this.chooseScissorButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.label5 = new System.Windows.Forms.Label();
            this.picRightPaper = new System.Windows.Forms.PictureBox();
            this.picLeftPaper = new System.Windows.Forms.PictureBox();
            this.picLeftRock = new System.Windows.Forms.PictureBox();
            this.picRightRock = new System.Windows.Forms.PictureBox();
            this.picRightScissor = new System.Windows.Forms.PictureBox();
            this.picLeftScissor = new System.Windows.Forms.PictureBox();
            this.picRightHidden = new System.Windows.Forms.PictureBox();
            this.picLeftHidden = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picRightPaper)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLeftPaper)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLeftRock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRightRock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRightScissor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLeftScissor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRightHidden)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLeftHidden)).BeginInit();
            this.SuspendLayout();
            // 
            // richChatTextBox
            // 
            this.richChatTextBox.Location = new System.Drawing.Point(662, 399);
            this.richChatTextBox.Name = "richChatTextBox";
            this.richChatTextBox.Size = new System.Drawing.Size(482, 112);
            this.richChatTextBox.TabIndex = 1;
            this.richChatTextBox.Text = "";
            // 
            // SendMessageButton
            // 
            this.SendMessageButton.Location = new System.Drawing.Point(562, 496);
            this.SendMessageButton.Name = "SendMessageButton";
            this.SendMessageButton.Size = new System.Drawing.Size(94, 29);
            this.SendMessageButton.TabIndex = 3;
            this.SendMessageButton.Text = "SEND";
            this.SendMessageButton.UseVisualStyleBackColor = true;
            this.SendMessageButton.Click += new System.EventHandler(this.SendMessageButton_Click);
            // 
            // SendMessageTextBox
            // 
            this.SendMessageTextBox.Location = new System.Drawing.Point(310, 498);
            this.SendMessageTextBox.Name = "SendMessageTextBox";
            this.SendMessageTextBox.Size = new System.Drawing.Size(246, 27);
            this.SendMessageTextBox.TabIndex = 4;
            this.SendMessageTextBox.TextChanged += new System.EventHandler(this.SendMessageTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(617, 399);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Chat";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(310, 475);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Send Message";
            // 
            // chooseRockButton
            // 
            this.chooseRockButton.Location = new System.Drawing.Point(70, 108);
            this.chooseRockButton.Name = "chooseRockButton";
            this.chooseRockButton.Size = new System.Drawing.Size(94, 29);
            this.chooseRockButton.TabIndex = 7;
            this.chooseRockButton.Text = "ROCK";
            this.chooseRockButton.UseVisualStyleBackColor = true;
            this.chooseRockButton.Click += new System.EventHandler(this.chooseRockButton_Click);
            // 
            // choosePaperButton
            // 
            this.choosePaperButton.Location = new System.Drawing.Point(70, 143);
            this.choosePaperButton.Name = "choosePaperButton";
            this.choosePaperButton.Size = new System.Drawing.Size(94, 29);
            this.choosePaperButton.TabIndex = 8;
            this.choosePaperButton.Text = "PAPER";
            this.choosePaperButton.UseVisualStyleBackColor = true;
            this.choosePaperButton.Click += new System.EventHandler(this.choosePaperButton_Click);
            // 
            // chooseScissorButton
            // 
            this.chooseScissorButton.Location = new System.Drawing.Point(70, 178);
            this.chooseScissorButton.Name = "chooseScissorButton";
            this.chooseScissorButton.Size = new System.Drawing.Size(94, 29);
            this.chooseScissorButton.TabIndex = 9;
            this.chooseScissorButton.Text = "SCISSOR";
            this.chooseScissorButton.UseVisualStyleBackColor = true;
            this.chooseScissorButton.Click += new System.EventHandler(this.chooseScissorButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(191, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "YOU:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(863, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "OPPONENT";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // backgroundWorker2
            // 
            this.backgroundWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker2_DoWork);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(237, 402);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 20);
            this.label5.TabIndex = 12;
            // 
            // picRightPaper
            // 
            this.picRightPaper.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.picRightPaper.Image = global::RockPaperScissorsWinForm.Properties.Resources.paper_hand;
            this.picRightPaper.Location = new System.Drawing.Point(594, 78);
            this.picRightPaper.Name = "picRightPaper";
            this.picRightPaper.Size = new System.Drawing.Size(251, 232);
            this.picRightPaper.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRightPaper.TabIndex = 14;
            this.picRightPaper.TabStop = false;
            // 
            // picLeftPaper
            // 
            this.picLeftPaper.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.picLeftPaper.Image = ((System.Drawing.Image)(resources.GetObject("picLeftPaper.Image")));
            this.picLeftPaper.Location = new System.Drawing.Point(237, 78);
            this.picLeftPaper.Name = "picLeftPaper";
            this.picLeftPaper.Size = new System.Drawing.Size(251, 232);
            this.picLeftPaper.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLeftPaper.TabIndex = 15;
            this.picLeftPaper.TabStop = false;
            // 
            // picLeftRock
            // 
            this.picLeftRock.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.picLeftRock.Image = ((System.Drawing.Image)(resources.GetObject("picLeftRock.Image")));
            this.picLeftRock.Location = new System.Drawing.Point(237, 78);
            this.picLeftRock.Name = "picLeftRock";
            this.picLeftRock.Size = new System.Drawing.Size(251, 232);
            this.picLeftRock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLeftRock.TabIndex = 16;
            this.picLeftRock.TabStop = false;
            // 
            // picRightRock
            // 
            this.picRightRock.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.picRightRock.Image = global::RockPaperScissorsWinForm.Properties.Resources.rock_hand;
            this.picRightRock.Location = new System.Drawing.Point(594, 78);
            this.picRightRock.Name = "picRightRock";
            this.picRightRock.Size = new System.Drawing.Size(251, 232);
            this.picRightRock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRightRock.TabIndex = 17;
            this.picRightRock.TabStop = false;
            // 
            // picRightScissor
            // 
            this.picRightScissor.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.picRightScissor.Image = global::RockPaperScissorsWinForm.Properties.Resources.scissor_hand;
            this.picRightScissor.Location = new System.Drawing.Point(594, 78);
            this.picRightScissor.Name = "picRightScissor";
            this.picRightScissor.Size = new System.Drawing.Size(251, 232);
            this.picRightScissor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRightScissor.TabIndex = 18;
            this.picRightScissor.TabStop = false;
            // 
            // picLeftScissor
            // 
            this.picLeftScissor.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.picLeftScissor.Image = ((System.Drawing.Image)(resources.GetObject("picLeftScissor.Image")));
            this.picLeftScissor.Location = new System.Drawing.Point(237, 78);
            this.picLeftScissor.Name = "picLeftScissor";
            this.picLeftScissor.Size = new System.Drawing.Size(251, 232);
            this.picLeftScissor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLeftScissor.TabIndex = 19;
            this.picLeftScissor.TabStop = false;
            // 
            // picRightHidden
            // 
            this.picRightHidden.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.picRightHidden.Location = new System.Drawing.Point(594, 78);
            this.picRightHidden.Name = "picRightHidden";
            this.picRightHidden.Size = new System.Drawing.Size(251, 232);
            this.picRightHidden.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRightHidden.TabIndex = 20;
            this.picRightHidden.TabStop = false;
            // 
            // picLeftHidden
            // 
            this.picLeftHidden.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.picLeftHidden.Location = new System.Drawing.Point(237, 78);
            this.picLeftHidden.Name = "picLeftHidden";
            this.picLeftHidden.Size = new System.Drawing.Size(251, 232);
            this.picLeftHidden.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLeftHidden.TabIndex = 21;
            this.picLeftHidden.TabStop = false;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1136, 537);
            this.Controls.Add(this.picLeftHidden);
            this.Controls.Add(this.picRightHidden);
            this.Controls.Add(this.picLeftScissor);
            this.Controls.Add(this.picRightScissor);
            this.Controls.Add(this.picRightRock);
            this.Controls.Add(this.picLeftRock);
            this.Controls.Add(this.picLeftPaper);
            this.Controls.Add(this.picRightPaper);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chooseScissorButton);
            this.Controls.Add(this.choosePaperButton);
            this.Controls.Add(this.chooseRockButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SendMessageTextBox);
            this.Controls.Add(this.SendMessageButton);
            this.Controls.Add(this.richChatTextBox);
            this.Name = "Form4";
            this.Text = "Game ID";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picRightPaper)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLeftPaper)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLeftRock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRightRock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRightScissor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLeftScissor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRightHidden)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLeftHidden)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private RichTextBox richChatTextBox;
        private Button SendMessageButton;
        private TextBox SendMessageTextBox;
        private Label label1;
        private Label label2;
        private Button chooseRockButton;
        private Button choosePaperButton;
        private Button chooseScissorButton;
        private Label label3;
        private Label label4;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private Label label5;
        private PictureBox picRightPaper;
        private PictureBox picLeftPaper;
        private PictureBox picLeftRock;
        private PictureBox picRightRock;
        private PictureBox picRightScissor;
        private PictureBox picLeftScissor;
        private PictureBox picRightHidden;
        private PictureBox picLeftHidden;
    }
}