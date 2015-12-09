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
        /// <summary>
        /// this holds our main form instance
        /// </summary>
        public frmMain Main;

        /// <summary>
        /// create a new for and set the main form variables into the 
        /// correct controls on the options form
        /// </summary>
        /// <param name="main"></param>
        public frmOptions(frmMain main)
        {
            InitializeComponent();
            Main = main;
            dtpStartTime.Value = main.today.Start;
            dtpEndTime.Value = main.today.End;
            numMinutes.Value = main.today.WindowSize.Minutes;
            numRidersPer.Value = main.today.MaxRiders;
        }


        #region button
        /// <summary>
        /// create a new day and pass the values from the 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            oDay newDay = new oDay(dtpStartTime.Value, dtpEndTime.Value, numMinutes.Text, (int)numRidersPer.Value, (int)numFirstTickets.Value);
            Main.today = newDay;
            Main.Show();
            Close();
        }
        #endregion

        private void frmOptions_Load(object sender, EventArgs e)
        {
            //hide the main form upon load.
            Main.Hide();
        }
    }
}
