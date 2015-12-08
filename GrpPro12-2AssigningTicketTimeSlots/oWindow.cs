using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrpPro12_2AssigningTicketTimeSlots
{
    
    public class oWindow
    {
        public DateTime StartTime { get; private set; }
        public int Duration { get; private set; }
        public int MaxRiders { get; private set; }
        public List<oTicket> Queue {get; set; }
        
        //generates a defauld window with a starttime of 
        // now, a MaxRiders of 5, and a duration of 5 minutes
        public oWindow()
        {
            StartTime = DateTime.Now;
            Duration = 5;
            MaxRiders = 5;
            Queue = new List<oTicket>(5);
            loadTickets();
        }
        
        public oWindow(DateTime start, int maxTickets, int duration)
        {
            StartTime = start;
            Duration = duration;
            MaxRiders = maxTickets;
            Queue = new List<oTicket>(maxTickets);
            loadTickets();
        }     

        public void loadTickets()
        {
            for (int i = 0; i < MaxRiders; i++)
            {
                Queue.Add(new oTicket(StartTime));
            }
        }
        
    }
}
