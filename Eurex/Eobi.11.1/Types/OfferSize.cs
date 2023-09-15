namespace Eurex.T7
{
    using System.Runtime.CompilerServices;

    /// <summary>
    ///  Offer Size: 8 Byte Fixed Width Integer with 4 Decimal Place Precision
    /// </summary>

    public struct OfferSize
    {
        /// <summary>
        ///  Length of Offer Size in bytes
        /// </summary>
        public const int Length = 8;

        /// <summary>
        ///  Decimal place factor for Offer Size
        /// </summary>
        public const int Factor = 10000;
    }
}