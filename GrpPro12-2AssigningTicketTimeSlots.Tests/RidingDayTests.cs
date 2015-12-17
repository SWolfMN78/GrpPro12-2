using System;
using GrpPro12_2AssigningTicketTimeSlots.Domain;
using NUnit.Framework;

namespace GrpPro12_2AssigningTicketTimeSlots.Tests
{
    [TestFixture]
    public class RidingDayTests
    {

        [Test]
        public void ShouldSetupRidingDayWithCorrectDefaults()
        {
            var sut = new RidingDay();
            
            Assert.AreEqual(TimeSpan.FromHours(17), sut.Start);
            Assert.AreEqual(TimeSpan.FromHours(25),sut.End);
            Assert.AreEqual(1,sut.WindowSize);
            Assert.AreEqual(479,sut.Windows.Count);
            Assert.AreEqual(5,sut.MaxRiders);
        }

        [Test]
        public void ShouldGiveTicket()
        {
            var sut = new RidingDay();
            sut.GiveTicket();

            Assert.AreEqual(2,sut.TicketNumber);
            Assert.AreEqual(1, sut.PendingTickets.Count);
        }

        

    }
}
