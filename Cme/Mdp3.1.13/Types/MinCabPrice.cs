namespace Cme.Sbe
{
    using System.Runtime.CompilerServices;

    /// <summary>
    ///  Min Cab Price: 8 Byte Fixed Width Nullable Integer with 9 Decimal Place Precision
    /// </summary>

    public struct MinCabPrice
    {
        /// <summary>
        ///  Fix Tag for Min Cab Price
        /// </summary>
        public const ushort FixTag = 9850;

        /// <summary>
        ///  Length of Min Cab Price in bytes
        /// </summary>
        public const int Length = 8;

        /// <summary>
        ///  Decimal place factor for Min Cab Price
        /// </summary>
        public const long Factor = 1000000000;

        /// <summary>
        ///  Null value for Min Cab Price
        /// </summary>
        public const long NoValue = 9223372036854775807;
    }
}