using System;

namespace CSharpFundamental3
{
    public class DisplayClock
    {
        public void ShowClock(object clock, TimeInfoEventArgs timeInfoEvent)
        {
            Console.WriteLine($"{timeInfoEvent._hour}:{timeInfoEvent._minute}:{timeInfoEvent._second}");
        }

        public void Subcribe(Clock clock)
        {
            clock.clockTickEvent += new Clock.clockTick(ShowClock);
        }
    }
}