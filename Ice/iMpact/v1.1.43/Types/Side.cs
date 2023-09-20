using System.Runtime.CompilerServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  Side
    /// </summary>

    public struct Side
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
        ///  Length of Side in bytes
        /// </summary>
        public const int Length = 1;
    }
}