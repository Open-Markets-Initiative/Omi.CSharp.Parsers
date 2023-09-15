namespace Eurex.T7
{
    using System.Runtime.CompilerServices;

    /// <summary>
    ///  Bid Px: 8 Byte Fixed Width Integer with 8 Decimal Place Precision
    /// </summary>

    public struct BidPx
    {
        /// <summary>
        ///  Length of Bid Px in bytes
        /// </summary>
        public const int Length = 8;

        /// <summary>
        ///  Decimal place factor for Bid Px
        /// </summary>
        public const int Factor = 100000000;
    }
}