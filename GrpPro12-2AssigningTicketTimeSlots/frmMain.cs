﻿using System;
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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            tmrClock.Start();

        }

        private void updateTime(object sender, EventArgs e)
        {
            this.Text = tmrClock.ToString();
        }
    }
}
