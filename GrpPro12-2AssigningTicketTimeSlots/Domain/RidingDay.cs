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
        public TimeSpan Start { get; private set; }
        public TimeSpan End { get; private set; }
        public List<RidingWindow> Windows { get; private set; }
        public int WindowSize { get; private set; }
        public RidingWindow CurrentRidingWindow { get; private set; }
        public int MaxRiders { get; private set; }
        public int TicketNumber { get; private set; }
        public List<Ticket> PendingTickets { get; private set; } 
        public List<Ticket> CurrentRiders { get; private set; }

        private const int DefaultStartHour = 12;
        private const int DefaultEndHour = 20;
        private const int DefaultWindowSize = 1;
        private const int DefaultMaxRiders = 5;
        private const int DefaultStartingTicketNumber = 1;

        public string Riders
        {
            get
            {
                if (CurrentRiders.Count > 0)
                {
                    return $"{CurrentRiders[0].index} - {CurrentRiders[CurrentRiders.Count - 1].index}";
                }
                return "No current riders";
            }
        }

        public DayStatus Status
        {
            get
            {
                if (DateTime.Now.TimeOfDay.Ticks > Start.Ticks && DateTime.Now.TimeOfDay.Ticks < End.Ticks && Windows.Count > 0)
                {
                    return DayStatus.Open;
                }
                return DayStatus.Closed;
            }
        }

        /// <summary>
        /// Default constructor sets open at 9am and close 8 hours later
        /// the window size is 5 minutes creating 96 windows
        /// </summary>
        public RidingDay
            (
                int start = DefaultStartHour, 
                int end = DefaultEndHour, 
                int windowSize = DefaultWindowSize, 
                int maxRiders = DefaultMaxRiders,
                int startTicketNumber = DefaultStartingTicketNumber
            )
        {
            Start = TimeSpan.FromHours(start);
            End = TimeSpan.FromHours(end);
            WindowSize = windowSize;
            MaxRiders = maxRiders;
            TicketNumber = startTicketNumber;

            PendingTickets = new List<Ticket>();
            CurrentRiders = new List<Ticket>();

            InitializeWindows();
        }
        

        /// <summary>
        /// create the list of windows required for a day and update the end time to be
        /// end at the end of the last windows (this is probably needless)
        /// </summary>
        private void InitializeWindows()
        {
            var windows = new List<RidingWindow>();
            var duration = End.Subtract(Start).TotalMinutes;
            var totalWindows = duration/WindowSize;

            for (int i = 0; i < totalWindows; i++)
            {
                var windowStartTime = Start.Add(TimeSpan.FromMinutes(WindowSize*i));
                windows.Add(new RidingWindow(windowStartTime, MaxRiders, WindowSize));
            }

            Windows = windows;
       
            CheckWindows();
        }

        /// <summary>
        /// check that the windows have not expired
        /// </summary>
        public void CheckWindows()
        {
            if (Windows.Count > 0 && (CurrentRidingWindow == null || CurrentRidingWindow.Queue.Count <= 0 || CurrentRidingWindow.StartTime.Ticks <= DateTime.Now.TimeOfDay.Ticks))
            {
                RemoveOldWindows();
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
        private void RemoveOldWindows()
        {
            List<RidingWindow> updatedOWindows = new List<RidingWindow>();
            foreach (var window in Windows)
            {
                if (window.StartTime.Ticks > DateTime.Now.TimeOfDay.Ticks)
                {
                    updatedOWindows.Add(window);
                }
            }
            Windows = updatedOWindows;
        }

        /// <summary>
        /// remove a ticket from the current window's ticket queue
        /// and provide it the correct ticket ID
        /// </summary>
        public void IssueTicket()
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
                if (pendingTicket.Time.Ticks > DateTime.Now.TimeOfDay.Ticks)
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
            CurrentRiders = CurrentRiders.Where(t => t.Time.Add(TimeSpan.FromMinutes(WindowSize)).Ticks > DateTime.Now.TimeOfDay.Ticks).ToList();
        }

    }
}
