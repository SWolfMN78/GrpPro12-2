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

        public bool Open
        {
            get
            {
                if (Windows.Count <= 0)
                {
                    return false;
                }
                return true;
            }
        }

        /// <summary>
        /// Default constructor sets open at 9am and close 8 hours later
        /// the window size is 5 minutes creating 96 windows
        /// </summary>
        public Day()
        {
            Start = DateTime.Parse("09:00");
            End = Start.AddHours(8);
            WindowSize = TimeSpan.Parse("00:05:00");
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
        public Day(DateTime start, DateTime end, TimeSpan windowSize)
        {
            Start = start;
            End = end;
            WindowSize = windowSize;
            SetWindows();
            //after the total full windows have been counted
            //this reduces the end time by any remainder
            End = Start.AddMinutes(Windows.Count*windowSize.Minutes);
        }

        private void SetWindows()
        {
            int minutesOpen = End.Subtract(Start).Minutes;
            int windowNumber = (minutesOpen/WindowSize.Minutes);
            for (int i = 0; i < windowNumber; i++)
            {
                DateTime start = Start.AddMinutes(WindowSize.Minutes*i);
                Windows.Add(new oWindow(start,minutesOpen,WindowSize.Minutes));
            }
        }

        public void CheckWindows()
        {
            List<oWindow> updatedOWindows = new List<oWindow>();
            foreach (var oWindow in Windows)
            {
                if (oWindow.StartTime > DateTime.Now && oWindow.Queue.Count > 0)
                {
                    updatedOWindows.Add(oWindow);
                }
            }
            Windows = updatedOWindows;
        }
    }
}
