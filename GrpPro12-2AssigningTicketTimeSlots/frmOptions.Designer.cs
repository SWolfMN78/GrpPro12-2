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
            this.dtpStartTime = new System.Windows.Forms.DateTimePicker();
            this.dtpEndTime = new System.Windows.Forms.DateTimePicker();
            this.numRidersPer = new System.Windows.Forms.NumericUpDown();
            this.numMinutes = new System.Windows.Forms.NumericUpDown();
            this.numFirstTickets = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numRidersPer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFirstTickets)).BeginInit();
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
            // dtpStartTime
            // 
            this.dtpStartTime.CustomFormat = "hh:mm tt";
            this.dtpStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStartTime.Location = new System.Drawing.Point(128, 110);
            this.dtpStartTime.Name = "dtpStartTime";
            this.dtpStartTime.ShowUpDown = true;
            this.dtpStartTime.Size = new System.Drawing.Size(128, 20);
            this.dtpStartTime.TabIndex = 2;
            this.dtpStartTime.Value = new System.DateTime(2015, 11, 30, 13, 24, 55, 0);
            // 
            // dtpEndTime
            // 
            this.dtpEndTime.CustomFormat = "hh:mm tt";
            this.dtpEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEndTime.Location = new System.Drawing.Point(128, 150);
            this.dtpEndTime.Name = "dtpEndTime";
            this.dtpEndTime.ShowUpDown = true;
            this.dtpEndTime.Size = new System.Drawing.Size(128, 20);
            this.dtpEndTime.TabIndex = 3;
            this.dtpEndTime.Value = new System.DateTime(2015, 11, 30, 13, 24, 55, 0);
            // 
            // numRidersPer
            // 
            this.numRidersPer.Location = new System.Drawing.Point(128, 69);
            this.numRidersPer.Margin = new System.Windows.Forms.Padding(2);
            this.numRidersPer.Name = "numRidersPer";
            this.numRidersPer.Size = new System.Drawing.Size(126, 20);
            this.numRidersPer.TabIndex = 1;
            // 
            // numMinutes
            // 
            this.numMinutes.Location = new System.Drawing.Point(128, 29);
            this.numMinutes.Margin = new System.Windows.Forms.Padding(2);
            this.numMinutes.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numMinutes.Name = "numMinutes";
            this.numMinutes.Size = new System.Drawing.Size(126, 20);
            this.numMinutes.TabIndex = 0;
            this.numMinutes.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numFirstTickets
            // 
            this.numFirstTickets.Location = new System.Drawing.Point(128, 189);
            this.numFirstTickets.Margin = new System.Windows.Forms.Padding(2);
            this.numFirstTickets.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numFirstTickets.Name = "numFirstTickets";
            this.numFirstTickets.Size = new System.Drawing.Size(126, 20);
            this.numFirstTickets.TabIndex = 4;
            this.numFirstTickets.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // frmOptions
            // 
            this.AcceptButton = this.btnOkay;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnOkay;
            this.ClientSize = new System.Drawing.Size(271, 281);
            this.Controls.Add(this.numFirstTickets);
            this.Controls.Add(this.numMinutes);
            this.Controls.Add(this.numRidersPer);
            this.Controls.Add(this.dtpEndTime);
            this.Controls.Add(this.dtpStartTime);
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
            ((System.ComponentModel.ISupportInitialize)(this.numRidersPer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFirstTickets)).EndInit();
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
        private System.Windows.Forms.DateTimePicker dtpStartTime;
        private System.Windows.Forms.DateTimePicker dtpEndTime;
        private System.Windows.Forms.NumericUpDown numRidersPer;
        private System.Windows.Forms.NumericUpDown numMinutes;
        private System.Windows.Forms.NumericUpDown numFirstTickets;
    }
}