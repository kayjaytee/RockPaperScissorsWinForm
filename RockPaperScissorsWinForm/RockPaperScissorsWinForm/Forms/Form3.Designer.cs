namespace RockPaperScissorsWinForm
{
    partial class Form3
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
            this.listUserOnline = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.HostGameButton = new System.Windows.Forms.Button();
            this.listGamesOpen = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.JoinGameButton = new System.Windows.Forms.Button();
            this.LogOutButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.richStatisticsTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // listUserOnline
            // 
            this.listUserOnline.FormattingEnabled = true;
            this.listUserOnline.ItemHeight = 20;
            this.listUserOnline.Location = new System.Drawing.Point(12, 60);
            this.listUserOnline.Name = "listUserOnline";
            this.listUserOnline.Size = new System.Drawing.Size(305, 324);
            this.listUserOnline.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 28);
            this.label2.TabIndex = 4;
            this.label2.Text = "All Your Friends :D";
            // 
            // HostGameButton
            // 
            this.HostGameButton.Location = new System.Drawing.Point(112, 431);
            this.HostGameButton.Name = "HostGameButton";
            this.HostGameButton.Size = new System.Drawing.Size(268, 43);
            this.HostGameButton.TabIndex = 5;
            this.HostGameButton.Text = "HOST GAME";
            this.HostGameButton.UseVisualStyleBackColor = true;
            this.HostGameButton.Click += new System.EventHandler(this.HostGameButton_Click);
            // 
            // listGamesOpen
            // 
            this.listGamesOpen.FormattingEnabled = true;
            this.listGamesOpen.ItemHeight = 20;
            this.listGamesOpen.Location = new System.Drawing.Point(797, 60);
            this.listGamesOpen.Name = "listGamesOpen";
            this.listGamesOpen.Size = new System.Drawing.Size(305, 324);
            this.listGamesOpen.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(797, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 28);
            this.label3.TabIndex = 8;
            this.label3.Text = "games open";
            // 
            // JoinGameButton
            // 
            this.JoinGameButton.Location = new System.Drawing.Point(417, 431);
            this.JoinGameButton.Name = "JoinGameButton";
            this.JoinGameButton.Size = new System.Drawing.Size(268, 43);
            this.JoinGameButton.TabIndex = 9;
            this.JoinGameButton.Text = "JOIN GAME";
            this.JoinGameButton.UseVisualStyleBackColor = true;
            // 
            // LogOutButton
            // 
            this.LogOutButton.Location = new System.Drawing.Point(714, 431);
            this.LogOutButton.Name = "LogOutButton";
            this.LogOutButton.Size = new System.Drawing.Size(268, 43);
            this.LogOutButton.TabIndex = 10;
            this.LogOutButton.Text = "LOGOUT";
            this.LogOutButton.UseVisualStyleBackColor = true;
            this.LogOutButton.Click += new System.EventHandler(this.LogOutButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(391, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Statistics";
            // 
            // richStatisticsTextBox
            // 
            this.richStatisticsTextBox.Location = new System.Drawing.Point(391, 60);
            this.richStatisticsTextBox.Name = "richStatisticsTextBox";
            this.richStatisticsTextBox.Size = new System.Drawing.Size(337, 324);
            this.richStatisticsTextBox.TabIndex = 12;
            this.richStatisticsTextBox.Text = "";
            this.richStatisticsTextBox.TextChanged += new System.EventHandler(this.richStatisticsTextBox_TextChanged);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1165, 531);
            this.Controls.Add(this.richStatisticsTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LogOutButton);
            this.Controls.Add(this.JoinGameButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listGamesOpen);
            this.Controls.Add(this.HostGameButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listUserOnline);
            this.Name = "Form3";
            this.Text = "Lobby";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ListBox listUserOnline;
        private Label label2;
        private Button HostGameButton;
        private ListBox listGamesOpen;
        private Label label3;
        private Button JoinGameButton;
        private Button LogOutButton;
        private Label label1;
        private RichTextBox richStatisticsTextBox;
    }
}