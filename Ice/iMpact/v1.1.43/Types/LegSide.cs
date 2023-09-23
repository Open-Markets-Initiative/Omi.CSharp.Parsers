using System.Runtime.CompilerServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  Leg Side: Zeroed Character Enum
    /// </summary>

    public struct LegSide
    {
        /// <summary>
        ///  None
        /// </summary>
        public const char None = '';

        /// <summary>
        ///  Bid
        /// </summary>
        public const char Bid = '1';

        /// <summary>
        ///  Offer
        /// </summary>
        public const char Offer = '2';

        /// <summary>
        ///  Length of Leg Side in bytes
        /// </summary>
        public const int Length = 1;
    }
}