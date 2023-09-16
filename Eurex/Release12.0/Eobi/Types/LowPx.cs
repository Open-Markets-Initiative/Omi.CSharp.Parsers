using System.Runtime.CompilerServices;;

namespace Eurex.Eobi
{
    /// <summary>
    ///  Low Px: 8 Byte Fixed Width Integer with 8 Decimal Place Precision
    /// </summary>

    public struct LowPx
    {
        /// <summary>
        ///  Length of Low Px in bytes
        /// </summary>
        public const int Length = 8;

        /// <summary>
        ///  Decimal place factor for Low Px
        /// </summary>
        public const int Factor = 100000000;
    }
}