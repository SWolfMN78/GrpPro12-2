namespace GrpPro12_2AssigningTicketTimeSlots
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            this.btnOptions = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblTicketCountOfGuest = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnIssueTicket = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblTicketTime = new System.Windows.Forms.Label();
            this.lblTicketsOutstanding = new System.Windows.Forms.Label();
            this.lstTicketDisplayInfo = new System.Windows.Forms.ListBox();
            this.tmrClock = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOptions
            // 
            this.btnOptions.Location = new System.Drawing.Point(32, 769);
            this.btnOptions.Margin = new System.Windows.Forms.Padding(6);
            this.btnOptions.Name = "btnOptions";
            this.btnOptions.Size = new System.Drawing.Size(192, 44);
            this.btnOptions.TabIndex = 0;
            this.btnOptions.Text = "Options";
            this.btnOptions.UseVisualStyleBackColor = true;
            this.btnOptions.Click += new System.EventHandler(this.btnOptions_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(400, 769);
            this.btnExit.Margin = new System.Windows.Forms.Padding(6);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(198, 44);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblTicketCountOfGuest
            // 
            this.lblTicketCountOfGuest.AutoSize = true;
            this.lblTicketCountOfGuest.ForeColor = System.Drawing.Color.Black;
            this.lblTicketCountOfGuest.Location = new System.Drawing.Point(48, 62);
            this.lblTicketCountOfGuest.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblTicketCountOfGuest.Name = "lblTicketCountOfGuest";
            this.lblTicketCountOfGuest.Size = new System.Drawing.Size(55, 25);
            this.lblTicketCountOfGuest.TabIndex = 2;
            this.lblTicketCountOfGuest.Text = "1 - 5";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblTicketCountOfGuest);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.groupBox1.Location = new System.Drawing.Point(32, 31);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox1.Size = new System.Drawing.Size(560, 123);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Guest with the following tickets may now enter:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(32, 62);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(252, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Total tickets outstanding:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(32, 123);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(214, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Next availalbe entry: ";
            // 
            // btnIssueTicket
            // 
            this.btnIssueTicket.ForeColor = System.Drawing.Color.Black;
            this.btnIssueTicket.Location = new System.Drawing.Point(32, 185);
            this.btnIssueTicket.Margin = new System.Windows.Forms.Padding(6);
            this.btnIssueTicket.Name = "btnIssueTicket";
            this.btnIssueTicket.Size = new System.Drawing.Size(224, 44);
            this.btnIssueTicket.TabIndex = 6;
            this.btnIssueTicket.Text = "Issue Ticket";
            this.btnIssueTicket.UseVisualStyleBackColor = true;
            this.btnIssueTicket.Click += new System.EventHandler(this.btnIssueTicket_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblTicketTime);
            this.groupBox2.Controls.Add(this.lblTicketsOutstanding);
            this.groupBox2.Controls.Add(this.btnIssueTicket);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.groupBox2.Location = new System.Drawing.Point(32, 169);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox2.Size = new System.Drawing.Size(560, 262);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ticket Availability";
            // 
            // lblTicketTime
            // 
            this.lblTicketTime.AutoSize = true;
            this.lblTicketTime.ForeColor = System.Drawing.Color.Black;
            this.lblTicketTime.Location = new System.Drawing.Point(320, 123);
            this.lblTicketTime.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblTicketTime.Name = "lblTicketTime";
            this.lblTicketTime.Size = new System.Drawing.Size(188, 25);
            this.lblTicketTime.TabIndex = 8;
            this.lblTicketTime.Text = "Time Place Holder";
            // 
            // lblTicketsOutstanding
            // 
            this.lblTicketsOutstanding.AutoSize = true;
            this.lblTicketsOutstanding.ForeColor = System.Drawing.Color.Black;
            this.lblTicketsOutstanding.Location = new System.Drawing.Point(320, 62);
            this.lblTicketsOutstanding.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblTicketsOutstanding.Name = "lblTicketsOutstanding";
            this.lblTicketsOutstanding.Size = new System.Drawing.Size(153, 25);
            this.lblTicketsOutstanding.TabIndex = 7;
            this.lblTicketsOutstanding.Text = "# Place Holder";
            // 
            // lstTicketDisplayInfo
            // 
            this.lstTicketDisplayInfo.FormattingEnabled = true;
            this.lstTicketDisplayInfo.ItemHeight = 25;
            this.lstTicketDisplayInfo.Items.AddRange(new object[] {
            "Ticket 6: 10:59 AM",
            "Ticket 7: 10:59 AM",
            "Ticket 8: 10:59 AM",
            "Ticket 9: 10:59 AM",
            "Ticket 10: 10:59 AM",
            "Ticket 11: 11:04 AM",
            "Ticket 12: 11:04 AM"});
            this.lstTicketDisplayInfo.Location = new System.Drawing.Point(32, 446);
            this.lstTicketDisplayInfo.Margin = new System.Windows.Forms.Padding(6);
            this.lstTicketDisplayInfo.Name = "lstTicketDisplayInfo";
            this.lstTicketDisplayInfo.Size = new System.Drawing.Size(556, 279);
            this.lstTicketDisplayInfo.TabIndex = 8;
            // 
            // tmrClock
            // 
            this.tmrClock.Interval = 1000;
            this.tmrClock.Tick += new System.EventHandler(this.updateTime);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(626, 835);
            this.Controls.Add(this.lstTicketDisplayInfo);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnOptions);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOptions;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblTicketCountOfGuest;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnIssueTicket;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lstTicketDisplayInfo;
        private System.Windows.Forms.Label lblTicketTime;
        private System.Windows.Forms.Label lblTicketsOutstanding;
        private System.Windows.Forms.Timer tmrClock;
    }
}

