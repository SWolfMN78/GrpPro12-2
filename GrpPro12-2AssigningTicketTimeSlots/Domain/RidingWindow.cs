using System;
using System.Collections.Generic;

namespace GrpPro12_2AssigningTicketTimeSlots.Domain
{
    public class RidingWindow
    {
        public TimeSpan StartTime { get; private set; }
        public int Duration { get; private set; }
        public int MaxRiders { get; private set; }
        public List<Ticket> RiderTickets {get; private set; }

        
        public RidingWindow(TimeSpan start, int maxTickets, int duration)
        {
            StartTime = start;
            Duration = duration;
            MaxRiders = maxTickets;
            RiderTickets = new List<Ticket>(maxTickets);
            LoadTickets();
        }     


        public void LoadTickets()
        {
            for (int i = 0; i < MaxRiders; i++)
            {
                RiderTickets.Add(new Ticket(StartTime));
            }
        }
        
    }
}
