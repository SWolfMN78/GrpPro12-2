using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrpPro12_2AssigningTicketTimeSlots
{
    //Class object that will be what is composed of a ticket.
    class oTicket
    {
        public DateTime Time { get; set; }
        public int NumberIndex { get; set; }
        
        public oTicket(DateTime time)
        {
            Time = time;
        }
    }
}
