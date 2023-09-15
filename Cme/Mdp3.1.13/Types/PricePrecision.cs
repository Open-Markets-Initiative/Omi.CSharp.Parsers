namespace Cme.Sbe
{
    using System.Runtime.CompilerServices;

    /// <summary>
    ///  Price Precision: One Byte Fixed Width Integer
    /// </summary>

    public struct PricePrecision
    {
        /// <summary>
        ///  Fix Tag for Price Precision
        /// </summary>
        public const ushort FixTag = 2349;

        /// <summary>
        ///  Length of Price Precision in bytes
        /// </summary>
        public const int Length = 1;
    }
}