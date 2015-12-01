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
        public TimeSpan Duration { get; private set; }
        public int MaxRiders { get; private set; }
        public List<oTicket> Queue {get; set; }
        
        //generates a defauld window with a starttime of 
        // now, a MaxRiders of 5, and a duration of 5 minutes
        public oWindow()
        {
            StartTime = DateTime.Now;
            Duration = new TimeSpan(0,5,0);
            MaxRiders = 5;
            Queue = new List<oTicket>(5);
        }
        
        public oWindow(DateTime start, int maxTickets, int duration)
        {
            StartTime = start;
            Duration = new TimeSpan(0,duration,0);
            MaxRiders = maxTickets;
            Queue = new List<oTicket>(maxTickets);
        }      

        //this class checks to see how many riders are remaining, if it is 0
        //then it will reset the window to a new time genenerated with the duration property
        //with the maximum number of riders otherwise it will just reduce the RidersRemaining
        //property by 1.
        public void GiveTicket()
        {
            if (Queue.Count > 0)
            {
                //Need to input which ticket that the ticket will be removed.
                Queue.RemoveAt(0);
            }
        }
        
    }
}
