using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrpPro12_2AssigningTicketTimeSlots
{
    /// <summary>
    /// Class defining a group of windows in a day
    /// holds the open property to dictace the titlebar
    /// </summary>
    public class Day
    {
        private string open;
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public List<oWindow> Windows { get; private set; }
        public TimeSpan WindowSize { get; set; }
        public oWindow CurrentWindow { get; set; }
        public int MaxRiders { get; set; }
        public int TicketNumber { get; set; }
        public List<oTicket> PendingTickets { get; set; } 

        public string Open
        {
            get
            {
                if (Windows.Count > 0)
                {
                    return "OPEN";
                }
                return "CLOSED";
            }
        }

        /// <summary>
        /// Default constructor sets open at 9am and close 8 hours later
        /// the window size is 5 minutes creating 96 windows
        /// </summary>
        public Day()
        {
            Start = DateTime.Parse("19:00");
            End = Start.AddHours(8);
            WindowSize = TimeSpan.Parse("00:01:00");
            MaxRiders = 5;
            TicketNumber = 1;

            SetWindows();
        }

        /// <summary>
        /// This constructor allows the programmer to input a start and end time
        /// as well as a time for each window.  The constructor will account
        /// for any remainder time and remove the time from the input end time
        /// </summary>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="windowSize"></param>
        public Day(DateTime start, DateTime end, string windowSize, int maxRiders, int startingTicket)
        {
            Start = start;
            End = end;
            WindowSize = TimeSpan.Parse(string.Format("00:{0}:00", windowSize));
            MaxRiders = maxRiders;
            SetWindows();
            //after the total full windows have been counted
            //this reduces the end time by any remainder
            End = Start.AddMinutes(Windows.Count*int.Parse(windowSize));
            TicketNumber = startingTicket;
        }

        private void SetWindows()
        {
            this.Windows = new List<oWindow>();
            TimeSpan minutes = End.Subtract(Start);
            int minutesOpen = minutes.Hours * 60;
            int windowNumber = (minutesOpen/WindowSize.Minutes);
            for (int i = 0; i < windowNumber; i++)
            {
                DateTime start = Start.AddMinutes(WindowSize.Minutes*i);
                Windows.Add(new oWindow(start, MaxRiders,WindowSize.Minutes));
            }
            PendingTickets = new List<oTicket>();
            CheckWindows();
        }

        public void CheckWindows()
        {
            if (Windows.Count > 0 && (CurrentWindow == null || CurrentWindow.Queue.Count <= 0 || CurrentWindow.StartTime.Ticks <= DateTime.Now.Ticks))
            {
                removeOldWindows();
                CurrentWindow = Windows[0];
                Windows.RemoveAt(0);
                
            }
            checkTickets();
        }

        private void removeOldWindows()
        {
            List<oWindow> updatedOWindows = new List<oWindow>();
            foreach (var oWindow in Windows)
            {
                if (oWindow.StartTime.Ticks > DateTime.Now.Ticks)
                {
                    updatedOWindows.Add(oWindow);
                }
            }
            Windows = updatedOWindows;
        }

        public void GiveTicket()
        {
            if (CurrentWindow.Queue.Count > 0)
            {
                CurrentWindow.Queue[0].index = TicketNumber;
                PendingTickets.Add(CurrentWindow.Queue[0]);
                TicketNumber ++;
                CurrentWindow.Queue.RemoveAt(0);
                CheckWindows();
            }
        }

        private void checkTickets()
        {
            var tempTickets = new List<oTicket>();
            foreach (var pendingTicket in PendingTickets)
            {
                if (pendingTicket.Time.Ticks > DateTime.Now.Ticks)
                {
                    tempTickets.Add(pendingTicket);
                }
            }
            PendingTickets = tempTickets;
        }
    }
}
