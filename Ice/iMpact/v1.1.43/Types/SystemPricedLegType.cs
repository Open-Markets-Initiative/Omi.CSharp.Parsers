using System.Runtime.CompilerServices;;

namespace Ice.iMpact
{
    /// <summary>
    ///  System Priced Leg Type
    /// </summary>

    public struct SystemPricedLegType
    {
        /// <summary>
        ///  System Priced Crack Spread Leg
        /// </summary>
        public const char SystemPricedCrackSpreadLeg = 'C';

        /// <summary>
        ///  System Priced Leg
        /// </summary>
        public const char SystemPricedLeg = 'S';

        /// <summary>
        ///  Length of System Priced Leg Type in bytes
        /// </summary>
        public const int Length = 1;
    }
}