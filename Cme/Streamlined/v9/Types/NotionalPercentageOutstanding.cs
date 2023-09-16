using System.Runtime.CompilerServices;;

namespace Cme.Streamlined
{
    /// <summary>
    ///  Notional Percentage Outstanding: 4 Byte Fixed Width Nullable Integer with 4 Decimal Place Precision
    /// </summary>

    public struct NotionalPercentageOutstanding
    {
        /// <summary>
        ///  Fix Tag for Notional Percentage Outstanding
        /// </summary>
        public const ushort FixTag = 1451;

        /// <summary>
        ///  Length of Notional Percentage Outstanding in bytes
        /// </summary>
        public const int Length = 4;

        /// <summary>
        ///  Decimal place factor for Notional Percentage Outstanding
        /// </summary>
        public const int Factor = 10000;

        /// <summary>
        ///  Null value for Notional Percentage Outstanding
        /// </summary>
        public const int NoValue = 2147483647;
    }
}