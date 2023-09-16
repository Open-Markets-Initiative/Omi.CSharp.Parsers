using System.Runtime.CompilerServices;;

namespace Cme.Streamlined
{
    /// <summary>
    ///  Leg Date Offset: One Byte Fixed Width Integer
    /// </summary>

    public struct LegDateOffset
    {
        /// <summary>
        ///  Fix Tag for Leg Date Offset
        /// </summary>
        public const ushort FixTag = 37503;

        /// <summary>
        ///  Length of Leg Date Offset in bytes
        /// </summary>
        public const int Length = 1;
    }
}