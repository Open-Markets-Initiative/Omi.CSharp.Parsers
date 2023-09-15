namespace Ice.iMpact
{
    using System.Runtime.CompilerServices;

    /// <summary>
    ///  Is System Priced Leg
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