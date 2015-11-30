namespace GrpPro12_2AssigningTicketTimeSlots
{
    partial class frmOptions
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnOkay = new System.Windows.Forms.Button();
            this.txtMinPerWind = new System.Windows.Forms.TextBox();
            this.txtGuestPerWin = new System.Windows.Forms.TextBox();
            this.txtFirstTicketNum = new System.Windows.Forms.TextBox();
            this.dtpStartTime = new System.Windows.Forms.DateTimePicker();
            this.dtpEndTime = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Minutes per window: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Guest per window: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Start time: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "End time:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "First ticket number: ";
            // 
            // btnOkay
            // 
            this.btnOkay.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnOkay.Location = new System.Drawing.Point(128, 232);
            this.btnOkay.Name = "btnOkay";
            this.btnOkay.Size = new System.Drawing.Size(128, 23);
            this.btnOkay.TabIndex = 5;
            this.btnOkay.Text = "&OK";
            this.btnOkay.UseVisualStyleBackColor = true;
            this.btnOkay.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtMinPerWind
            // 
            this.txtMinPerWind.Location = new System.Drawing.Point(128, 24);
            this.txtMinPerWind.Name = "txtMinPerWind";
            this.txtMinPerWind.Size = new System.Drawing.Size(128, 20);
            this.txtMinPerWind.TabIndex = 6;
            // 
            // txtGuestPerWin
            // 
            this.txtGuestPerWin.Location = new System.Drawing.Point(128, 64);
            this.txtGuestPerWin.Name = "txtGuestPerWin";
            this.txtGuestPerWin.Size = new System.Drawing.Size(128, 20);
            this.txtGuestPerWin.TabIndex = 7;
            // 
            // txtFirstTicketNum
            // 
            this.txtFirstTicketNum.Location = new System.Drawing.Point(128, 184);
            this.txtFirstTicketNum.Name = "txtFirstTicketNum";
            this.txtFirstTicketNum.Size = new System.Drawing.Size(128, 20);
            this.txtFirstTicketNum.TabIndex = 10;
            // 
            // dtpStartTime
            // 
            this.dtpStartTime.CustomFormat = "";
            this.dtpStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpStartTime.Location = new System.Drawing.Point(128, 104);
            this.dtpStartTime.Name = "dtpStartTime";
            this.dtpStartTime.ShowUpDown = true;
            this.dtpStartTime.Size = new System.Drawing.Size(128, 20);
            this.dtpStartTime.TabIndex = 11;
            this.dtpStartTime.Value = new System.DateTime(2015, 11, 30, 13, 24, 55, 0);
            // 
            // dtpEndTime
            // 
            this.dtpEndTime.CustomFormat = "hh:mm tt";
            this.dtpEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpEndTime.Location = new System.Drawing.Point(128, 144);
            this.dtpEndTime.Name = "dtpEndTime";
            this.dtpEndTime.ShowUpDown = true;
            this.dtpEndTime.Size = new System.Drawing.Size(128, 20);
            this.dtpEndTime.TabIndex = 12;
            this.dtpEndTime.Value = new System.DateTime(2015, 11, 30, 13, 24, 55, 0);
            // 
            // frmOptions
            // 
            this.AcceptButton = this.btnOkay;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnOkay;
            this.ClientSize = new System.Drawing.Size(271, 281);
            this.Controls.Add(this.dtpEndTime);
            this.Controls.Add(this.dtpStartTime);
            this.Controls.Add(this.txtFirstTicketNum);
            this.Controls.Add(this.txtGuestPerWin);
            this.Controls.Add(this.txtMinPerWind);
            this.Controls.Add(this.btnOkay);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmOptions";
            this.ShowIcon = false;
            this.Text = "Options";
            this.Load += new System.EventHandler(this.frmOptions_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnOkay;
        private System.Windows.Forms.TextBox txtMinPerWind;
        private System.Windows.Forms.TextBox txtGuestPerWin;
        private System.Windows.Forms.TextBox txtFirstTicketNum;
        private System.Windows.Forms.DateTimePicker dtpStartTime;
        private System.Windows.Forms.DateTimePicker dtpEndTime;
    }
}