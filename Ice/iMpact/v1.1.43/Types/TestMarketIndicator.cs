using System.Runtime.CompilerServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  Test Market Indicator: Zeroed Character Enum
    /// </summary>

    public struct TestMarketIndicator
    {
        /// <summary>
        ///  Test Market
        /// </summary>
        public const char Yes = 'Y';

        /// <summary>
        ///  Non Test Market
        /// </summary>
        public const char No = 'N';

        /// <summary>
        ///  Length of Test Market Indicator in bytes
        /// </summary>
        public const int Length = 1;
    }
}