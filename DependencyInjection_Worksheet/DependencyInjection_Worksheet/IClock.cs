using System;

namespace DependencyInjection_Worksheet
{
    public interface IClock
    {
        DateTime Now { get; }
    }
}