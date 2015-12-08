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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        public Day today;
        private void Form1_Load(object sender, EventArgs e)
        {
            //this method call handles starting the timer.
            tmrClock.Start();
            today = new Day();
        }

        private void updateTime(object sender, EventArgs e)
        {            
            //This method will display the time in the mainform window.
            this.Text = $"{DateTime.Now.ToString("hh:mm:ss tt")}  {today.Open}";
            updateListbox();
            today.CheckWindows();
        }
        #region buttons
        private void btnOptions_Click(object sender, EventArgs e)
        {
            var frmOptions = new frmOptions(this);
            frmOptions.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion

        private void btnIssueTicket_Click(object sender, EventArgs e)
        {
            today.GiveTicket();
            updateListbox();
        }

        private void updateListbox()
        {
            if (lstTicketDisplayInfo.Items.Count != today.PendingTickets.Count)
            {
                lstTicketDisplayInfo.Items.Clear();
                foreach (var pendingTicket in today.PendingTickets)
                {
                    lstTicketDisplayInfo.Items.Add(pendingTicket);
                }
            }
        }
    }
}
