using System.Globalization;
using MBExtensions.Extensions.Decimal.Enums;

namespace MBExtensions.Extensions.Decimal
{
    public static class DecimalExtensions
    {
        /// <summary>
        /// Convert a <see cref="decimal"/> to a currency as a <see cref="string"/>
        /// </summary>
        /// <param name="value">Value to be converted</param>
        /// <returns><see cref="string"/></returns>
        public static string ToStringCurrencyFormat( this decimal value )
        {
            return value.ToString( "C" );
        }

        /// <summary>
        /// Convert a <see cref="decimal"/> to a specific currency as a <see cref="string"/>
        /// </summary>
        /// <param name="value">Value to be converted</param>
        /// <param name="currency"><see cref="SupportedCurrency"/> as abbreviation</param>
        /// <returns><see cref="string"/></returns>
        public static string ToStringCurrencyFormat( this decimal value, SupportedCurrency currency )
        {
            return value.ToString( "00.00 " + currency.ToString() );
        }

        /// <summary>
        /// Convert a <see cref="decimal"/> to a specific currency as a <see cref="string"/>
        /// </summary>
        /// <param name="value">Value to be converted</param>
        /// <param name="cultureInfo">Culture info</param>
        /// <returns></returns>
        public static string ToStringCurrencyFormat(this decimal value, CultureInfo cultureInfo)
        {
            return string.Format( cultureInfo , "{0:c0}" , value );
        }
    }
}