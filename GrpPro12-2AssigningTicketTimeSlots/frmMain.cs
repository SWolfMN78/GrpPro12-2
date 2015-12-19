using System;
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

        private void FormLoad(object sender, EventArgs e)
        {
            tmrClock.Start();
            btnIssueTicket.Focus();
        }
        
        private void UpdateTime(object sender, EventArgs e)
        {
            //This method will display the time in the mainform window.
            var status = Today.GetStatus(DateTime.Now);

            Text = DateTime.Now.ToString("hh:mm:ss tt") + " " + Enum.GetName(typeof(DayStatus),status);
            UpdateListbox();
            Today.Refresh(DateTime.Now);
            UpdateButton();
            UpdateLabels();
        }

        private void OptionsButtonClick(object sender, EventArgs e)
        {
            var dialogResult = MessageBox.Show(
                "By going into the Options Settings you will lose all current Tickets.  Press OK to proceed",
                "Options Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (dialogResult != DialogResult.OK) return;

            var frmOptions = new frmOptions(this) { StartPosition = FormStartPosition.CenterParent };
            frmOptions.ShowDialog(this);
        }

        private void ExitButtonClick(object sender, EventArgs e)
        {
            Close();
        }


        private void IssueTicketButtonClick(object sender, EventArgs e)
        {
            Today.IssueTicket(DateTime.Now);
            UpdateListbox();
        }


        private void UpdateListbox()
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

        private void UpdateButton()
        {
            var status = Today.GetStatus(DateTime.Now);
            btnIssueTicket.Enabled = status != DayStatus.Closed;
        }

        private void UpdateLabels()
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
            
            lblTicketCountOfGuest.Text = Today.CurrentRiders.Count > 0 ? $"{Today.CurrentRiders[0].Number} - {Today.CurrentRiders[Today.CurrentRiders.Count - 1].Number}" : "No current riders";
        }

    }
}
