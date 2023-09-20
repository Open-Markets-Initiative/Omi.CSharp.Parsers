using System.Runtime.CompilerServices;

namespace Nasdaq.MarketDepth
{
    /// <summary>
    ///  Short Ask Price: 2 Byte Fixed Width Integer with 2 Decimal Place Precision
    /// </summary>

    public struct ShortAskPrice
    {
        /// <summary>
        ///  Length of Short Ask Price in bytes
        /// </summary>
        public const int Length = 2;

        /// <summary>
        ///  Decimal place factor for Short Ask Price
        /// </summary>
        public const int Factor = 100;
    }
}