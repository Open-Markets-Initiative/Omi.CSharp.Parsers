namespace Cme.Sbe
{
    using System.Runtime.CompilerServices;

    /// <summary>
    ///  Tradeable Size: Optional 4 Byte Fixed Width Integer
    /// </summary>

    public struct TradeableSize
    {
        /// <summary>
        ///  Length of Tradeable Size in bytes
        /// </summary>
        public const int Length = 4;

        /// <summary>
        ///  Null value for Tradeable Size
        /// </summary>
        public const int NoValue = 2147483647;
    }
}