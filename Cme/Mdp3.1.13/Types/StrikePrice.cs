namespace Cme.Sbe
{
    using System.Runtime.CompilerServices;

    /// <summary>
    ///  Strike Price: 8 Byte Fixed Width Nullable Integer with 9 Decimal Place Precision
    /// </summary>

    public struct StrikePrice
    {
        /// <summary>
        ///  Fix Tag for Strike Price
        /// </summary>
        public const ushort FixTag = 202;

        /// <summary>
        ///  Length of Strike Price in bytes
        /// </summary>
        public const int Length = 8;

        /// <summary>
        ///  Decimal place factor for Strike Price
        /// </summary>
        public const long Factor = 1000000000;

        /// <summary>
        ///  Null value for Strike Price
        /// </summary>
        public const long NoValue = 9223372036854775807;
    }
}