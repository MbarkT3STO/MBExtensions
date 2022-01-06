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
    }
}