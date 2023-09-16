using System.Runtime.CompilerServices;;

namespace Ice.iMpact
{
    /// <summary>
    ///  Leg Deal Suppressed
    /// </summary>

    public struct LegDealSuppressed
    {
        /// <summary>
        ///  Leg Deals Are Suppressed
        /// </summary>
        public const char Yes = 'Y';

        /// <summary>
        ///  Leg Deals Are Not Suppressed
        /// </summary>
        public const char No = 'N';

        /// <summary>
        ///  Length of Leg Deal Suppressed in bytes
        /// </summary>
        public const int Length = 1;
    }
}