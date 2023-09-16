using System.Runtime.CompilerServices;;

namespace Eurex.Eobi
{
    /// <summary>
    ///  Bid Size: 8 Byte Fixed Width Integer with 4 Decimal Place Precision
    /// </summary>

    public struct BidSize
    {
        /// <summary>
        ///  Length of Bid Size in bytes
        /// </summary>
        public const int Length = 8;

        /// <summary>
        ///  Decimal place factor for Bid Size
        /// </summary>
        public const int Factor = 10000;
    }
}