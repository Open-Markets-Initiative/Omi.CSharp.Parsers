using System.Runtime.CompilerServices;

namespace Eurex.Eobi
{
    /// <summary>
    ///  Offer Px: 8 Byte Fixed Width Integer with 8 Decimal Place Precision
    /// </summary>

    public struct OfferPx
    {
        /// <summary>
        ///  Length of Offer Px in bytes
        /// </summary>
        public const int Length = 8;

        /// <summary>
        ///  Decimal place factor for Offer Px
        /// </summary>
        public const int Factor = 100000000;
    }
}