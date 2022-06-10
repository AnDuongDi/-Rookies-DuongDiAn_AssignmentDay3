namespace CSharpFundamental3
{
    public class TimeInfoEventArgs
    {
        public readonly int _hour;
        public readonly int _minute;
        public readonly int _second;

        public TimeInfoEventArgs(int hour, int minute, int second)
        {
            this._hour=hour;
            this._minute=minute;
            this._second=second;
        }
    }
}