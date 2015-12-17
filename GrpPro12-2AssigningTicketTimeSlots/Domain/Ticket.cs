using System;

namespace GrpPro12_2AssigningTicketTimeSlots.Domain
{
    public class Ticket
    {
        public TimeSpan Time { get; set; }
        public int Number { get; set; }
        
        public Ticket(TimeSpan time)
        {
            Time = time;
        }

        public override string ToString()
        {
            return $"Ticket {Number}: {Time}";
        }
    }
}
