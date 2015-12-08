using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrpPro12_2AssigningTicketTimeSlots
{
    //Class object that will be what is composed of a ticket.
    public class oTicket
    {
        public DateTime Time { get; set; }

        public int index { get; set; }
                
        public oTicket(DateTime time)
        {
            Time = time;
        }

        public override string ToString()
        {
            return string.Format("Ticket {0}: {1}",index,Time); 
        }
    }
}
