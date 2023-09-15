namespace Ice.iMpact
{
    using System.Runtime.CompilerServices;

    /// <summary>
    ///  Leg Side
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