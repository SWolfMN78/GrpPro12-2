﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrpPro12_2AssigningTicketTimeSlots
{

    //This is a listing of our tickets
    class oTickets : List<oTicket>
    {
        //pull the information from the book from the product class construction - Chapter 14.
        //Draw information on what all is used to construct a ticket - Ticket number,

        public oTickets(int tickets, DateTime time)
        {
            for (int i = 0; i < tickets; i++)
            {
                this.Add(new oTicket(time));
            }
        }

        //public override void Add(oTicket ticket)
        //{
        //    //TODO: define the method for adding a ticket
        //    this.Add(ticket);
        //}

        //public override void Remove(oTicket ticket)
        //{
        //    //TODO: define the moethod for removing a ticket
        //    this.Remove(ticket);

        //}
        
        public void Reset()
        {
            //TODO: add a method that resets the list to a new list of tickets
            this.Reset();
        }
    }
}
