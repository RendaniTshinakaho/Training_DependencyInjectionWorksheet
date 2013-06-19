using NUnit.Framework;

namespace DependencyInjection_Worksheet
{
    [TestFixture]
    public class PublicHolidayNotifierTests
    {
        [Test]
        public void IsYouthDayOnThe17June2013()
        {
            var youthDay = new PublicHolidayNotifier(new SystemClock());
            const string expected = "Today is Youth Day";
            var act = youthDay.GenerateNotification();
            Assert.That(act,Is.EqualTo(expected));
        }
        [Test]
        public void IsNormalDayOnThe18June2013()
        {           
            var normalDay = new PublicHolidayNotifier(new NormalClock());
            const string expected = "Today is a normal day";
            var act = normalDay.GenerateNotification();
            Assert.That(act, Is.EqualTo(expected)); 
        }        
    }
}
