using System.Runtime.CompilerServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  Is Settle Price Official: Zeroed Character Enum
    /// </summary>

    public struct IsSettlePriceOfficial
    {
        /// <summary>
        ///  Settle Price Is Official
        /// </summary>
        public const char Yes = 'Y';

        /// <summary>
        ///  Settle Price Is Not Official
        /// </summary>
        public const char No = 'N';

        /// <summary>
        ///  Length of Is Settle Price Official in bytes
        /// </summary>
        public const int Length = 1;
    }
}