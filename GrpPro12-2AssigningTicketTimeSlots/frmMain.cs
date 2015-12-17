using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GrpPro12_2AssigningTicketTimeSlots.Domain;

namespace GrpPro12_2AssigningTicketTimeSlots
{
    public partial class frmMain : Form
    {
        
        public frmMain()
        {
            Today = new RidingDay();
            InitializeComponent();
        }

        public RidingDay Today;

        #region Event Handlers
        /// <summary>
        /// start the timer and create a new day
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            //this method call handles starting the timer.
            tmrClock.Start();
            btnIssueTicket.Focus();
        }
        
        /// <summary>
        /// Update the tiem every second, check the windows and update the button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void updateTime(object sender, EventArgs e)
        {
            //This method will display the time in the mainform window.
            this.Text = DateTime.Now.ToString("hh:mm:ss tt") + " " + Today.Status;
            updateListbox();
            Today.CheckWindows();
            updateButton();
            updateLabels();
        }

        /// <summary>
        /// Open the button window and pass the main form instance to it
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOptions_Click(object sender, EventArgs e)
        {
            //Display a warning to the user for when they open the Options window.
            if (MessageBox.Show("By going into the Options Settings you will lose all current Tickets.  Press OK to proceed",
             "Options Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                 //Load the Option window.
                var frmOptions = new frmOptions(this);
                frmOptions.ControlBox = false;
                frmOptions.Show();
            }
        }

        /// <summary>
        /// close the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExit_Click(object sender, EventArgs e)
        {
            //close the form when done.
            Close();
        }

        /// <summary>
        /// give out a ticket and update the listbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnIssueTicket_Click(object sender, EventArgs e)
        {
            Today.GiveTicket();
            updateListbox();
        }
        #endregion

        #region Form Updates
        /// <summary>
        /// reloads the listbox when the items collection is different than the 
        /// pending tickets
        /// </summary>
        private void updateListbox()
        {
            if (lstTicketDisplayInfo.Items.Count != Today.PendingTickets.Count)
            {
                lstTicketDisplayInfo.Items.Clear();
                foreach (var pendingTicket in Today.PendingTickets)
                {
                    lstTicketDisplayInfo.Items.Add(pendingTicket);
                }
            }
        }

        /// <summary>
        /// checks if the ride is open and disables the button if not
        /// </summary>
        private void updateButton()
        {
            if (Today.Status == DayStatus.Closed)
            {
                btnIssueTicket.Enabled = false;
            }
            if (Today.Status == DayStatus.Open)
            {
                btnIssueTicket.Enabled = true;
            }
        }

        private void updateLabels()
        {
            
            lblTicketsOutstanding.Text = Today.PendingTickets.Count.ToString();
            if (Today.CurrentRidingWindow != null)
            {
                lblTicketTime.Text = Today.CurrentRidingWindow.StartTime.ToString();
            }
            else
            {
                lblTicketTime.Text = "No available ticket time, please wait!";
            }
            
            lblTicketCountOfGuest.Text = Today.Riders;
        }
        #endregion


        
    }
}
