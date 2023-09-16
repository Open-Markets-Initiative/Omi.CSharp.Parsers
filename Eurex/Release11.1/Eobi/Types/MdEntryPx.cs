using System.Runtime.CompilerServices;;

namespace Eurex.Eobi
{
    /// <summary>
    ///  Md Entry Px: 8 Byte Fixed Width Integer with 8 Decimal Place Precision
    /// </summary>

    public struct MdEntryPx
    {
        /// <summary>
        ///  Length of Md Entry Px in bytes
        /// </summary>
        public const int Length = 8;

        /// <summary>
        ///  Decimal place factor for Md Entry Px
        /// </summary>
        public const int Factor = 100000000;
    }
}