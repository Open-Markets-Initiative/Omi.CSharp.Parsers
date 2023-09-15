namespace Eurex.T7
{
    using System.Runtime.CompilerServices;

    /// <summary>
    ///  Prev Price: 8 Byte Fixed Width Integer with 8 Decimal Place Precision
    /// </summary>

    public struct PrevPrice
    {
        /// <summary>
        ///  Length of Prev Price in bytes
        /// </summary>
        public const int Length = 8;

        /// <summary>
        ///  Decimal place factor for Prev Price
        /// </summary>
        public const int Factor = 100000000;
    }
}