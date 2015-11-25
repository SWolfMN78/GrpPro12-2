using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrpPro12_2AssigningTicketTimeSlots
{
    // object which holds information of what is going to go into the window.
    class oWindow
    {
        public DateTime StartTime { get; set; }
        public int People { get; set; }
        public DateTime Duration { get; set; }
    }
}
