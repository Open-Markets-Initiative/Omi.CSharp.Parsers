using System.Runtime.CompilerServices;

namespace Eurex.Eobi
{
    /// <summary>
    ///  Non Disclosed Trade Volume: 8 Byte Fixed Width Integer with 4 Decimal Place Precision
    /// </summary>

    public struct NonDisclosedTradeVolume
    {
        /// <summary>
        ///  Length of Non Disclosed Trade Volume in bytes
        /// </summary>
        public const int Length = 8;

        /// <summary>
        ///  Decimal place factor for Non Disclosed Trade Volume
        /// </summary>
        public const int Factor = 10000;
    }
}