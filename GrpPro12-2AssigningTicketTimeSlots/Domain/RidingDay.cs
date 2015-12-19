using System;
using System.Collections.Generic;
using System.Linq;

namespace GrpPro12_2AssigningTicketTimeSlots.Domain
{

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


        public DayStatus GetStatus(DateTime currentDateTime)
        {
            var open =  currentDateTime.TimeOfDay > Start && currentDateTime.TimeOfDay < End && Windows.Count > 0;
            return open ? DayStatus.Open : DayStatus.Closed;
        }

        
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
        }

        public void IssueTicket(DateTime currentDateTime)
        {
            Refresh(currentDateTime);

            var ticket = CurrentRidingWindow.RiderTickets.FirstOrDefault();
            if (ticket == null) return;

            ticket.Number = TicketNumber;

            PendingTickets.Add(ticket);
            CurrentRidingWindow.RiderTickets.Remove(ticket);
            TicketNumber++;
        }


        public void Refresh(DateTime currentDateTime)
        {
            var updatedWindows = Windows.Where(window => window.StartTime.Ticks > currentDateTime.TimeOfDay.Ticks).ToList();
            Windows = updatedWindows;

            if (Windows.Count > 0 &&
                (CurrentRidingWindow == null || CurrentRidingWindow.RiderTickets.Count <= 0 ||
                CurrentRidingWindow.StartTime.Ticks <= currentDateTime.TimeOfDay.Ticks))
            {
                CurrentRidingWindow = Windows[0];
                Windows.RemoveAt(0);
            }

            var activeTickets = PendingTickets.Where(t => t.Time <= currentDateTime.TimeOfDay).ToList();
            PendingTickets.RemoveAll(t => t.Time <= currentDateTime.TimeOfDay);

            CurrentRiders.AddRange(activeTickets);
            CurrentRiders = CurrentRiders.Where(t => t.Time.Add(TimeSpan.FromMinutes(WindowSize)) > currentDateTime.TimeOfDay).ToList();
        }
    }
}
