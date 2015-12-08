using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrpPro12_2AssigningTicketTimeSlots
{
    /// <summary>
    /// Depicts a windw that a ride can issue tickets for
    /// </summary>
    public class oWindow
    {
        public DateTime StartTime { get; private set; }
        public int Duration { get; private set; }
        public int MaxRiders { get; private set; }
        public List<oTicket> Queue {get; set; }

        /// <summary>
        /// generates a defauld window with a starttime of
        /// now, a MaxRiders of 5, and a duration of 1 minutes
        /// </summary>
        public oWindow()
        {
            StartTime = DateTime.Now;
            Duration = 1;
            MaxRiders = 5;
            Queue = new List<oTicket>(5);
            loadTickets();
        }
        
        /// <summary>
        /// create a windows with the passed arguments
        /// </summary>
        /// <param name="start"></param>
        /// <param name="maxTickets"></param>
        /// <param name="duration"></param>
        public oWindow(DateTime start, int maxTickets, int duration)
        {
            StartTime = start;
            Duration = duration;
            MaxRiders = maxTickets;
            Queue = new List<oTicket>(maxTickets);
            loadTickets();
        }     

        /// <summary>
        /// generate the required tickets for the window
        /// </summary>
        public void loadTickets()
        {
            for (int i = 0; i < MaxRiders; i++)
            {
                Queue.Add(new oTicket(StartTime));
            }
        }
        
    }
}
