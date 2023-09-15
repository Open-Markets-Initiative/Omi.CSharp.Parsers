namespace Cme.Sbe
{
    using System.Runtime.CompilerServices;

    /// <summary>
    ///  Par Value: 8 Byte Fixed Width Nullable Integer with 9 Decimal Place Precision
    /// </summary>

    public struct ParValue
    {
        /// <summary>
        ///  Fix Tag for Par Value
        /// </summary>
        public const ushort FixTag = 37723;

        /// <summary>
        ///  Length of Par Value in bytes
        /// </summary>
        public const int Length = 8;

        /// <summary>
        ///  Decimal place factor for Par Value
        /// </summary>
        public const long Factor = 1000000000;

        /// <summary>
        ///  Null value for Par Value
        /// </summary>
        public const long NoValue = 9223372036854775807;
    }
}