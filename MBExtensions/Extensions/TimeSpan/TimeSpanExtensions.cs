using System;

namespace MBExtensions.Extensions.TimeSpan
{
    public static class TimeSpanExtensions
    {
        /// <summary>
        /// Returns a string that represents the current TimeSpan object.
        /// </summary>
        /// <returns><see cref="string"/> represents the <see cref="TimeSpan"/>  </returns>
        public static string ToTimeString(this System.TimeSpan timeSpan)
        {
            return new DateTime(timeSpan.Ticks).ToString("hh:mm tt");
        }
        
        /// <summary>
        /// Returns a string that represents the current TimeSpan object.
        /// </summary>
        /// <param name="format">A standard or custom time format string.</param>
        public static string ToTimeString(this System.TimeSpan timeSpan, string format)
        {
            return new DateTime( timeSpan.Ticks ).ToString( format );
        }
    }
}