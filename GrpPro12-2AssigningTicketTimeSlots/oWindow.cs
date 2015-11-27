using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrpPro12_2AssigningTicketTimeSlots
{
    
    class oWindow
    {
        public DateTime StartTime { get; private set; }
        public TimeSpan Duration { get; private set; }
        public int MaxRiders { get; private set; }
        public int RidersRemaining { get; private set; }
        
        //generates a defauld window with a starttime of 
        // now, a MaxRiders of 5, and a duration of 5 minutes
        public oWindow()
        {
            StartTime = Now();
            Duration = new TimeSpan(0,5,0);
            MaxRiders = 5;
            RidersRemaining = MaxRiders;
        }
        
        public oWindow(DateTime start, int people, int duration)
        {
            this.StartTime = start;
            this.Duration = new TimeSpan(0,duration,0);
            this.MaxRiders = people;
            this.RidersRemaining = this.MaxRiders;
        }
        
        private void ResetWindow()
        {
            StartTime.Add(Duration)
            ResetRiders()
        }
        
        private void ResetRiders()
        {
            this.RidersRemaining = MaxRiders;   
        }
        
        //this class checks to see how many riders are remaining, if it is 0
        //then it will reset the window to a new time genenerated with the duration property
        //with the maximum number of riders otherwise it will just reduce the RidersRemaining
        //property by 1.
        public void RemoveRider()
        {
            if (RidersRemaining > 0)
            {
                this.RidersRemaiing -= 1;
            }
            else
            {
                ResetWindow()
            }
        }
        
    }
}
