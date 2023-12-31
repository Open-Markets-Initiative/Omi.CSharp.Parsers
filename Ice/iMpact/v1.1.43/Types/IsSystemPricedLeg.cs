using System.Runtime.CompilerServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  Is System Priced Leg: Zeroed Character Enum
    /// </summary>

    public struct IsSystemPricedLeg
    {
        /// <summary>
        ///  Leg Is
        /// </summary>
        public const char Yes = 'Y';

        /// <summary>
        ///  Settle Price Is Not Official
        /// </summary>
        public const char No = 'N';

        /// <summary>
        ///  Length of Is System Priced Leg in bytes
        /// </summary>
        public const int Length = 1;
    }
}