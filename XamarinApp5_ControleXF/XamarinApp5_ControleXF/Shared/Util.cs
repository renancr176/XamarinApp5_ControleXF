using System;

namespace XamarinApp5_ControleXF.Shared
{
    public static class Util
    {
        public static TimeSpan ToTimeSpan(this DateTime date)
        {
            var TimeSpan = new TimeSpan(date.Hour, date.Minute, date.Second);
            return TimeSpan;
        }
    }
}
