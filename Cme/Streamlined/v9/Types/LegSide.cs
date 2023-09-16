using System.Runtime.CompilerServices;;

namespace Cme.Streamlined
{
    /// <summary>
    ///  Leg Side: One Byte Fixed Width Integer
    /// </summary>

    public struct LegSide
    {
        /// <summary>
        ///  Fix Tag for Leg Side
        /// </summary>
        public const ushort FixTag = 624;

        /// <summary>
        ///  Length of Leg Side in bytes
        /// </summary>
        public const int Length = 1;
    }
}