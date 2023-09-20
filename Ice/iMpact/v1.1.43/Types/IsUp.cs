using System.Runtime.CompilerServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  Is Up
    /// </summary>

    public struct IsUp
    {
        /// <summary>
        ///  Ipl Upper Bound Violation Bidding Too High
        /// </summary>
        public const char IplUpperBoundViolation = 'Y';

        /// <summary>
        ///  Ipl Lower Bound Violation Asking Too Low
        /// </summary>
        public const char IplLowerBoundViolation = 'N';

        /// <summary>
        ///  Final
        /// </summary>
        public const char Final = 'F';

        /// <summary>
        ///  Non Endex Spot Market
        /// </summary>
        public const char NonEndexSpotMarket = '';

        /// <summary>
        ///  Length of Is Up in bytes
        /// </summary>
        public const int Length = 1;
    }
}