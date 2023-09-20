using System.Runtime.CompilerServices;

namespace Cme.Mdp3
{
    /// <summary>
    ///  High Limit Price: 8 Byte Fixed Width Nullable Integer with 9 Decimal Place Precision
    /// </summary>

    public struct HighLimitPrice
    {
        /// <summary>
        ///  Fix Tag for High Limit Price
        /// </summary>
        public const ushort FixTag = 1149;

        /// <summary>
        ///  Length of High Limit Price in bytes
        /// </summary>
        public const int Length = 8;

        /// <summary>
        ///  Decimal place factor for High Limit Price
        /// </summary>
        public const long Factor = 1000000000;

        /// <summary>
        ///  Null value for High Limit Price
        /// </summary>
        public const long NoValue = 9223372036854775807;
    }
}