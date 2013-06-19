using System;
namespace DependencyInjection_Worksheet
{
    //
    // You will need to refactor this class so you can test it properly
    // You are not allowed to pass in primitives (i.e. ints)
    // You are also not allow to edit the method signature of the
    // GenerateNotification method
    //
    public class PublicHolidayNotifier
    {
        private readonly IClock _clock;
        private static DateTime TimeNow {
            get {return new DateTime(2013,06,17);}
        }
        public PublicHolidayNotifier(IClock clock)
        {
            _clock = clock;
        }

        public string GenerateNotification()
        {
            var now = _clock.Now;
            return now == TimeNow ? "Today is Youth Day" : "Today is a normal day";
        }
    }
}