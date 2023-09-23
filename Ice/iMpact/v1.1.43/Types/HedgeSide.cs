using System.Runtime.CompilerServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  Hedge Side: Zeroed Character Enum
    /// </summary>

    public struct HedgeSide
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
        ///  Length of Hedge Side in bytes
        /// </summary>
        public const int Length = 1;
    }
}