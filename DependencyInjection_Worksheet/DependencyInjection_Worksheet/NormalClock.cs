using System;

namespace DependencyInjection_Worksheet
{
    public class NormalClock : IClock
    {
        public DateTime Now { get; private set; }
    }
}