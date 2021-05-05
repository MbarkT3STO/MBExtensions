using System;
using System.Globalization;

namespace MBExtensions.Extensions.Date_and_Time
{
    public static class DateTimeExtensions
    {
        /// <summary>
        /// Convert a <see cref="DateTime"/> to French date
        /// </summary>
        /// <param name="dateTime"><see cref="DateTime"/> to be converted</param>
        /// <returns><see cref="string"/></returns>
        public static string ToFrenchDateString( this DateTime dateTime )
        {
            return dateTime.ToString( "dd/MM/yyyy" , new CultureInfo( "fr-MA" ) );
        }
        
        /// <summary>
        /// Convert a <see cref="DateTime"/> to French date with time
        /// </summary>
        /// <param name="dateTime"><see cref="DateTime"/> to be converted</param>
        /// <returns><see cref="string"/></returns>
        public static string ToFrenchDateTimeString( this DateTime dateTime )
        {
            return dateTime.ToString( "dd/MM/yyyy hh:mm tt" , new CultureInfo( "fr-MA" ) );
        } 
        
        /// <summary>
        /// Convert a <see cref="TimeSpan"/> to a simple string time
        /// </summary>
        /// <param name="timeSpan"><see cref="TimeSpan"/> to be converted</param>
        /// <returns><see cref="string"/></returns>
        public static string ToTimeString( this TimeSpan timeSpan )
        {
            return new DateTime( timeSpan.Ticks ).ToString( "hh:mm tt" );
        }
    }
}