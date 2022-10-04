using System;

namespace MBExtensions.Extensions.Bool
{
    public static class BoolExtensions
    {
        /// <summary>
        /// Return a speific string value if a boolean is <b>True</b> or <b>False</b> 
        /// </summary>
        /// <param name="booleanValue">Boolean value to be checked</param>
        /// <param name="valueIfTrue">Value if the <b>boolean</b> is <b>True</b></param>
        /// <param name="valueIfFalse">Value if the <b>boolean</b> is <b>False</b></param>
        /// <returns></returns>
        public static string ToString( this bool booleanValue , string valueIfTrue , string valueIfFalse ) => booleanValue ? valueIfTrue : valueIfFalse;

        /// <summary>
        /// Return a YES if a boolean is <b>True</b> or NO if <b>False</b> 
        /// </summary>
        /// <param name="booleanValue">Boolean value to be checked</param>
        /// <returns></returns>
        public static string ToYesNo( this bool booleanValue ) => booleanValue ? "Yes" : "No";

        /// <summary>
        /// Return a OUI if a boolean is <b>True</b> or NON if <b>False</b> 
        /// </summary>
        /// <param name="booleanValue">Boolean value to be checked</param>
        /// <returns></returns>
        public static string ToOuiNon( this bool booleanValue ) => booleanValue ? "Oui" : "Non";


        /// <summary>
        /// Return a specific string value if a boolean is <b>True</b> or <b>False</b> 
        /// </summary>
        /// <param name="booleanValue">Boolean value to be checked</param>
        /// <param name="valueIfTrue">Value if the <b>boolean</b> is <b>True</b></param>
        /// <param name="valueIfFalse">Value if the <b>boolean</b> is <b>False</b></param>
        /// <param name="throwExceptionIfNull">Determines if the Method should throw a NULL Exception if the boolean is NULL</param>
        public static string ToString( this bool? booleanValue , string valueIfTrue , string valueIfFalse, bool throwExceptionIfNull = false  ) => throwExceptionIfNull && booleanValue is null ? throw new ArgumentNullException(nameof( booleanValue )) : ( bool ) booleanValue ? valueIfTrue : valueIfFalse;

        /// <summary>
        /// Return a YES if a boolean is <b>True</b> or NO if <b>False</b> 
        /// </summary>
        /// <param name="booleanValue">Boolean value to be checked</param>
        /// <param name="throwExceptionIfNull">Determines if the Method should throw a NULL Exception if the boolean is NULL</param>
        public static string ToYesNo( this bool? booleanValue, bool throwExceptionIfNull = false ) => throwExceptionIfNull && booleanValue is null ? throw new ArgumentNullException(nameof( booleanValue )) : ( bool ) booleanValue ? "Yes" : "No";

        /// <summary>
        /// Return a OUI if a boolean is <b>True</b> or NON if <b>False</b> 
        /// </summary>
        /// <param name="booleanValue">Boolean value to be checked</param>
        /// <param name="throwExceptionIfNull">Determines if the Method should throw a NULL Exception if the boolean is NULL</param>
        public static string ToOuiNon( this bool? booleanValue, bool throwExceptionIfNull = false ) =>  throwExceptionIfNull && booleanValue is null ? throw new ArgumentNullException(nameof( booleanValue )) : ( bool ) booleanValue ? "Oui" : "Non";
    }
}