namespace Eurex.T7
{
    using System.Runtime.CompilerServices;

    /// <summary>
    ///  Leg Price: 8 Byte Fixed Width Integer with 8 Decimal Place Precision
    /// </summary>

    public struct LegPrice
    {
        /// <summary>
        ///  Length of Leg Price in bytes
        /// </summary>
        public const int Length = 8;

        /// <summary>
        ///  Decimal place factor for Leg Price
        /// </summary>
        public const int Factor = 100000000;
    }
}