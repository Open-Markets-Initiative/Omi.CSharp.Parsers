namespace Cme.Sbe
{
    using System.Runtime.CompilerServices;

    /// <summary>
    ///  Trading Reference Price: 8 Byte Fixed Width Nullable Integer with 9 Decimal Place Precision
    /// </summary>

    public struct TradingReferencePrice
    {
        /// <summary>
        ///  Fix Tag for Trading Reference Price
        /// </summary>
        public const ushort FixTag = 1150;

        /// <summary>
        ///  Length of Trading Reference Price in bytes
        /// </summary>
        public const int Length = 8;

        /// <summary>
        ///  Decimal place factor for Trading Reference Price
        /// </summary>
        public const long Factor = 1000000000;

        /// <summary>
        ///  Null value for Trading Reference Price
        /// </summary>
        public const long NoValue = 9223372036854775807;
    }
}