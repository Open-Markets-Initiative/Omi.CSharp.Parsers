using System.Runtime.CompilerServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  Mifid Regulated Market: Zeroed Character Enum
    /// </summary>

    public struct MifidRegulatedMarket
    {
        /// <summary>
        ///  Mifid Regulated Market
        /// </summary>
        public const char Yes = 'Y';

        /// <summary>
        ///  Not Mifid Regulated Market
        /// </summary>
        public const char No = 'N';

        /// <summary>
        ///  Length of Mifid Regulated Market in bytes
        /// </summary>
        public const int Length = 1;
    }
}