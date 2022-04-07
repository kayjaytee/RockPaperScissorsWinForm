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
            this.button1 = new System.Windows.Forms.Button();
            this.listGamesOpen = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(112, 431);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(268, 43);
            this.button1.TabIndex = 5;
            this.button1.Text = "HOST GAME";
            this.button1.UseVisualStyleBackColor = true;
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
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(417, 431);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(268, 43);
            this.button2.TabIndex = 9;
            this.button2.Text = "JOIN GAME";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(714, 431);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(268, 43);
            this.button3.TabIndex = 10;
            this.button3.Text = "LOGOUT";
            this.button3.UseVisualStyleBackColor = true;
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
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1165, 531);
            this.Controls.Add(this.richStatisticsTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listGamesOpen);
            this.Controls.Add(this.button1);
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
        private Button button1;
        private ListBox listGamesOpen;
        private Label label3;
        private Button button2;
        private Button button3;
        private Label label1;
        private RichTextBox richStatisticsTextBox;
    }
}