namespace Cme.Sbe
{
    using System.Runtime.CompilerServices;

    /// <summary>
    ///  Tot Num Reports Optional: Optional 4 Byte Fixed Width Integer
    /// </summary>

    public struct TotNumReportsOptional
    {
        /// <summary>
        ///  Length of Tot Num Reports Optional in bytes
        /// </summary>
        public const int Length = 4;

        /// <summary>
        ///  Null value for Tot Num Reports Optional
        /// </summary>
        public const uint NoValue = 4294967295;
    }
}