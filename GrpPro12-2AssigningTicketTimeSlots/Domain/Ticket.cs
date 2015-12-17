﻿using System;

namespace GrpPro12_2AssigningTicketTimeSlots.Domain
{
    //Class object that will be what is composed of a ticket.
    public class Ticket
    {
        public DateTime Time { get; set; }

        public int index { get; set; }
        
        /// <summary>
        /// constructor takes in the time at rider can ride
        /// </summary>
        /// <param name="time"></param>
        public Ticket(DateTime time)
        {
            Time = time;
        }

        /// <summary>
        /// provides the ticket number and the time a rider can ride
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            //Adjusted the time to be a AM/PM instead of Military
            return string.Format("Ticket {0}: {1}",index,Time.ToShortTimeString()); 
        }
    }
}