using System.Runtime.CompilerServices;

namespace Eurex.Eobi
{
    /// <summary>
    ///  Md Entry Size: 8 Byte Fixed Width Integer with 4 Decimal Place Precision
    /// </summary>

    public struct MdEntrySize
    {
        /// <summary>
        ///  Length of Md Entry Size in bytes
        /// </summary>
        public const int Length = 8;

        /// <summary>
        ///  Decimal place factor for Md Entry Size
        /// </summary>
        public const int Factor = 10000;
    }
}