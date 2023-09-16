using System.Runtime.CompilerServices;;

namespace Eurex.Eobi
{
    /// <summary>
    ///  High Px: 8 Byte Fixed Width Integer with 8 Decimal Place Precision
    /// </summary>

    public struct HighPx
    {
        /// <summary>
        ///  Length of High Px in bytes
        /// </summary>
        public const int Length = 8;

        /// <summary>
        ///  Decimal place factor for High Px
        /// </summary>
        public const int Factor = 100000000;
    }
}