using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrpPro12_2AssigningTicketTimeSlots
{
    public partial class frmOptions : Form
    {
        public frmMain Main;
        public frmOptions(frmMain main)
        {
            InitializeComponent();
            Main = main;
        }
        private void frmOptions_Load(object sender, EventArgs e)
        {
            
        }

        #region button
        private void button1_Click(object sender, EventArgs e)
        {
            //when this is pressed it for now it will close the form.
            //***** This will be considered complete when the information is loaded to
            //the main form.
            TimeSpan ts = new TimeSpan(0, int.Parse(numMinutes.Value.ToString()),0);
            Main.today = new Day(dtpStartTime.Value, dtpEndTime.Value,ts);
            Close();
        }
        #endregion
    }
}
