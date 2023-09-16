using System.Runtime.CompilerServices;;

namespace Eurex.Eobi
{
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