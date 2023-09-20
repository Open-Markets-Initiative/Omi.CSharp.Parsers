using System.Runtime.CompilerServices;

namespace Eurex.Eobi
{
    /// <summary>
    ///  Strike Price: 8 Byte Fixed Width Integer with 8 Decimal Place Precision
    /// </summary>

    public struct StrikePrice
    {
        /// <summary>
        ///  Length of Strike Price in bytes
        /// </summary>
        public const int Length = 8;

        /// <summary>
        ///  Decimal place factor for Strike Price
        /// </summary>
        public const int Factor = 100000000;
    }
}