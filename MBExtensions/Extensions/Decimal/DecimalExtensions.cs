using MBExtensions.Extensions.Decimal.Enums;

namespace MBExtensions.Extensions.Decimal
{
    public static class DecimalExtensions
    {
        /// <summary>
        /// Convert a <see cref="decimal"/> to <see cref="string"/> currency format
        /// </summary>
        /// <param name="value">Value to be converted</param>
        /// <returns><see cref="string"/></returns>
        public static string ToStringCurrencyFormat( this decimal value )
        {
            return value.ToString( "C" );
        } 
        
        /// <summary>
        /// Convert a <see cref="decimal"/> to <see cref="string"/> currency format
        /// </summary>
        /// <param name="value">Value to be converted</param>
        /// <param name="currency"><see cref="SupportedCurrency"/> as abbreviation</param>
        /// <returns><see cref="string"/></returns>
        public static string ToStringCurrencyFormat( this decimal value,SupportedCurrency currency )
        {
            return value.ToString( "00.00 " + currency.ToString() );
        }
    }
}