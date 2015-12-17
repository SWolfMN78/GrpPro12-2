using System;
using System.Collections.Generic;
using System.Linq;

namespace GrpPro12_2AssigningTicketTimeSlots.Domain
{
    /// <summary>
    /// Class defining a group of windows in a day
    /// holds the open property to dictace the titlebar
    /// </summary>
    public class RidingDay
    {
        private string open;
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public List<RidingWindow> Windows { get; private set; }
        public TimeSpan WindowSize { get; set; }
        public RidingWindow CurrentRidingWindow { get; set; }
        public int MaxRiders { get; set; }
        public int TicketNumber { get; set; }
        public List<Ticket> PendingTickets { get; set; } 
        public List<Ticket> CurrentRiders { get; set; }

        public string riders
        {
            get
            {
                if (CurrentRiders.Count > 0)
                {
                    return string.Format("{0} - {1}", CurrentRiders[0].index, CurrentRiders[CurrentRiders.Count-1].index);
                }
                return "No current riders";
            }
        }

        public string Open
        {
            get
            {
                if (DateTime.Now.Ticks > Start.Ticks && DateTime.Now.Ticks < End.Ticks && Windows.Count > 0)
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
        public RidingDay()
        {
            Start = DateTime.Parse("17:00");
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
        public RidingDay(DateTime start, DateTime end, string windowSize, int maxRiders, int startingTicket)
        {
            Start = start;
            End = end;
            WindowSize = TimeSpan.Parse(string.Format("00:{0}:00", windowSize));
            MaxRiders = maxRiders;
            SetWindows();
            //after the total full windows have been counted
            //this reduces the end time by any remainder
            
            TicketNumber = startingTicket;
        }

        /// <summary>
        /// create the list of windows required for a day and update the end time to be
        /// end at the end of the last windows (this is probably needless)
        /// </summary>
        private void SetWindows()
        {
            this.Windows = new List<RidingWindow>();
            TimeSpan minutes = End.Subtract(Start);
            int minutesOpen = minutes.Hours * 60;
            int windowNumber = (minutesOpen/WindowSize.Minutes);
            for (int i = 0; i < windowNumber; i++)
            {
                DateTime start = Start.AddMinutes(WindowSize.Minutes*i);
                Windows.Add(new RidingWindow(start, MaxRiders,WindowSize.Minutes));
            }
            PendingTickets = new List<Ticket>();
            CurrentRiders = new List<Ticket>();
            CheckWindows();
        }

        /// <summary>
        /// check that the windows have not expired
        /// </summary>
        public void CheckWindows()
        {
            if (Windows.Count > 0 && (CurrentRidingWindow == null || CurrentRidingWindow.Queue.Count <= 0 || CurrentRidingWindow.StartTime.Ticks <= DateTime.Now.Ticks))
            {
                removeOldWindows();
                //found that the code was drilling down and removing all windows then breaking because there was nothing.
                if (Windows.Count > 0)
                {
                    
                    CurrentRidingWindow = Windows[0];
                    Windows.RemoveAt(0);
                }
            }
            CheckTickets();
        }

        /// <summary>
        /// if the windows have pased the end time, remove them from the list of windows
        /// </summary>
        private void removeOldWindows()
        {
            List<RidingWindow> updatedOWindows = new List<RidingWindow>();
            foreach (var oWindow in Windows)
            {
                if (oWindow.StartTime.Ticks > DateTime.Now.Ticks)
                {
                    updatedOWindows.Add(oWindow);
                }
            }
            Windows = updatedOWindows;
        }

        /// <summary>
        /// remove a ticket from the current window's ticket queue
        /// and provide it the correct ticket ID
        /// </summary>
        public void GiveTicket()
        {
            if (CurrentRidingWindow.Queue.Count > 0)
            {
                CurrentRidingWindow.Queue[0].index = TicketNumber;
                PendingTickets.Add(CurrentRidingWindow.Queue[0]);
                TicketNumber ++;
                CurrentRidingWindow.Queue.RemoveAt(0);
                CheckWindows();
            }
        }

        /// <summary>
        /// check to make sure that all the tickets in pending tickets have not passed their start time
        /// </summary>
        private void CheckTickets()
        {
            var tempTickets = new List<Ticket>();
            var noLongerPending = new List<Ticket>();
            foreach (var pendingTicket in PendingTickets)
            {
                if (pendingTicket.Time.Ticks > DateTime.Now.Ticks)
                {

                    tempTickets.Add(pendingTicket);
                }
                else
                {
                    noLongerPending.Add(pendingTicket);
                }

            }
            PendingTickets = tempTickets;
            foreach (var currentRider in noLongerPending)
            {
                CurrentRiders.Add(currentRider);
            }
            CurrentRiders = CurrentRiders.Where(t => t.Time.Add(WindowSize).Ticks > DateTime.Now.Ticks).ToList();
        }

    }
}
