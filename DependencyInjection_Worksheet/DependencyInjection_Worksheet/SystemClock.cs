using System;

namespace DependencyInjection_Worksheet
{
    public class SystemClock : IClock
    {
        public DateTime Now {
            get { return new DateTime(2013, 06, 17); }
        }
        
    }
}