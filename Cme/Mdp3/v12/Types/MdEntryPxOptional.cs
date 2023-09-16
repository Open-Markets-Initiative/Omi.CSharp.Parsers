using System.Runtime.CompilerServices;;

namespace Cme.Mdp3
{
    /// <summary>
    ///  Md Entry Px Optional: 8 Byte Fixed Width Nullable Integer with 9 Decimal Place Precision
    /// </summary>

    public struct MdEntryPxOptional
    {
        /// <summary>
        ///  Fix Tag for Md Entry Px Optional
        /// </summary>
        public const ushort FixTag = 270;

        /// <summary>
        ///  Length of Md Entry Px Optional in bytes
        /// </summary>
        public const int Length = 8;

        /// <summary>
        ///  Decimal place factor for Md Entry Px Optional
        /// </summary>
        public const long Factor = 1000000000;

        /// <summary>
        ///  Null value for Md Entry Px Optional
        /// </summary>
        public const long NoValue = 9223372036854775807;
    }
}