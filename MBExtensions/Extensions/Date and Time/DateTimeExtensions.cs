using System;
using System.Globalization;

namespace MBExtensions.Extensions.Date_and_Time
{
    public static class DateTimeExtensions
    {

        #region To a specific format

        /// <summary>
        /// Convert a <see cref="DateTime"/> to French date
        /// </summary>
        /// <param name="dateTime"><see cref="DateTime"/> to be converted</param>
        /// <returns><see cref="string"/></returns>
        public static string ToFrenchDateString(this DateTime dateTime)
        {
            return dateTime.ToString("dd/MM/yyyy", new CultureInfo("fr-MA"));
        }

        /// <summary>
        /// Convert a <see cref="DateTime"/> to French date with time
        /// </summary>
        /// <param name="dateTime"><see cref="DateTime"/> to be converted</param>
        /// <returns><see cref="string"/></returns>
        public static string ToFrenchDateTimeString(this DateTime dateTime)
        {
            return dateTime.ToString("dd/MM/yyyy hh:mm tt", new CultureInfo("fr-MA"));
        }

        #endregion

        #region Convertion

        /// <summary>
        /// Convert a <see cref="TimeSpan"/> to a simple string time
        /// </summary>
        /// <param name="timeSpan"><see cref="TimeSpan"/> to be converted</param>
        /// <returns><see cref="string"/></returns>
        public static string ToTimeString(this TimeSpan timeSpan)
        {
            return new DateTime(timeSpan.Ticks).ToString("hh:mm tt");
        }

        #endregion

        #region For a specific country

        /// <summary>
        /// Convert a <see cref="DateTime"/> to its Moroccan equivalent date and time
        /// </summary>
        /// <param name="datetime"><see cref="DateTime"/> to be converted</param>
        /// <returns><see cref="DateTime"/></returns>
        public static DateTime InMorocco(this DateTime datetime)
        {
            var moroccoTimeZoneInfo=TimeZoneInfo.FindSystemTimeZoneById("Morocco Standard Time");
            DateTimeOffset moroccanLocalTime= TimeZoneInfo.ConvertTime(datetime, moroccoTimeZoneInfo);

            return moroccanLocalTime.DateTime;
        }

        #endregion

        #region Get specific dates

        /// <summary>
        /// Get the last day/date of the current <see cref="DateTime"/>
        /// </summary>
        /// <param name="datetime"><see cref="DateTime"/> value</param>
        public static DateTime GetFirstDayOfTheWeek(this DateTime datetime)
        {
            return datetime.AddDays(-(int)datetime.DayOfWeek);
        }

        /// <summary>
        /// Get the last day/date of the current <see cref="DateTime"/>
        /// </summary>
        /// <param name="datetime"><see cref="DateTime"/> value</param>
        public static DateTime GetLastDayOfTheWeek(this DateTime datetime)
        {
            return datetime.AddDays(6 - (int)datetime.DayOfWeek);
        }

        /// <summary>
        /// Get the first day/date of the previous <see cref="DateTime"/> week 
        /// </summary>
        /// <param name="datetime"><see cref="DateTime"/> value</param>
        public static DateTime GetFirstDayOfThePreviousWeek(this DateTime datetime)
        {
            var firstDayOfCurrentWeek     = datetime.AddDays(-(int)datetime.DayOfWeek);
            var lastDayOfThePreviousWeek  = firstDayOfCurrentWeek.AddDays(-1);
            var firstDayOfThePreviousWeek = lastDayOfThePreviousWeek.AddDays(-(int)lastDayOfThePreviousWeek.DayOfWeek);

            return firstDayOfThePreviousWeek;
        }

        /// <summary>
        /// Get the last day/date of the previous <see cref="DateTime"/> week 
        /// </summary>
        /// <param name="datetime"><see cref="DateTime"/> value</param>
        public static DateTime GetLastDayOfThePreviousWeek(this DateTime datetime)
        {
            var firstDayOfCurrentWeek    = datetime.AddDays(-(int)datetime.DayOfWeek);
            var lastDayOfThePreviousWeek = firstDayOfCurrentWeek.AddDays(-1);

            return lastDayOfThePreviousWeek;
        }

        #endregion

        #region Days

        /// <summary>
        /// Get name of the day
        /// </summary>
        /// <param name="dateTime">Date to get name of the day from</param>
        /// <param name="cultureInfo">Culture</param>
        /// <returns></returns>
        public static string GetWeekDay(this DateTime dateTime, CultureInfo cultureInfo)
        {
            var result = dateTime.ToString( "dddd" , cultureInfo );

            return result;
        }

        #endregion
    }
}