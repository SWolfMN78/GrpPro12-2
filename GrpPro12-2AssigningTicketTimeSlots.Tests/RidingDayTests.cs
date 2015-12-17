using System;
using GrpPro12_2AssigningTicketTimeSlots.Domain;
using NUnit.Framework;

namespace GrpPro12_2AssigningTicketTimeSlots.Tests
{
    [TestFixture]
    public class RidingDayTests
    {
        [Test]
        public void ShouldStartAtFivePMByDefault()
        {
            var sut = new RidingDay();

            Assert.AreEqual(DateTime.Parse("17:00"),sut.Start);

        }

    }
}
