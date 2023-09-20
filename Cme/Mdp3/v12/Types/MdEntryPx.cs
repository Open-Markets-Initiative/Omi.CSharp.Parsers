using System.Runtime.CompilerServices;

namespace Cme.Mdp3
{
    /// <summary>
    ///  Md Entry Px: 8 Byte Fixed Width Integer with 9 Decimal Place Precision
    /// </summary>

    public struct MdEntryPx
    {
        /// <summary>
        ///  Fix Tag for Md Entry Px
        /// </summary>
        public const ushort FixTag = 270;

        /// <summary>
        ///  Length of Md Entry Px in bytes
        /// </summary>
        public const int Length = 8;

        /// <summary>
        ///  Decimal place factor for Md Entry Px
        /// </summary>
        public const int Factor = 1000000000;
    }
}