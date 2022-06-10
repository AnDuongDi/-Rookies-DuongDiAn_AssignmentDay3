using System;
using System.Threading;

namespace CSharpFundamental3
{
    public class Clock
    {
        private int _hour;
        private int _minute;
        private int _second;

        public delegate void clockTick(object clock, TimeInfoEventArgs timeEvent); 

        public event clockTick clockTickEvent;

        public void OnTick(object clock, TimeInfoEventArgs timeEvent)
        {
            if (clockTickEvent != null)
            {
                clockTickEvent(clock, timeEvent);
            }
        }

        //Trigger->Event->Subcride delegate -> Handle
        public void Run()
        {
            while(!Console.KeyAvailable)
            {
                Thread.Sleep(1000);
                DateTime now = DateTime.Now;
                if (now.Second != this._second)
                {
                    TimeInfoEventArgs timeInfoEvent = new TimeInfoEventArgs(now.Hour, now.Minute, now.Second);
                    OnTick(this, timeInfoEvent);
                }
            }
        }
    }
}