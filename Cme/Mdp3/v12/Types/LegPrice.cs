using System.Runtime.CompilerServices;;

namespace Cme.Mdp3
{
    /// <summary>
    ///  Leg Price: 8 Byte Fixed Width Nullable Integer with 9 Decimal Place Precision
    /// </summary>

    public struct LegPrice
    {
        /// <summary>
        ///  Fix Tag for Leg Price
        /// </summary>
        public const ushort FixTag = 566;

        /// <summary>
        ///  Length of Leg Price in bytes
        /// </summary>
        public const int Length = 8;

        /// <summary>
        ///  Decimal place factor for Leg Price
        /// </summary>
        public const long Factor = 1000000000;

        /// <summary>
        ///  Null value for Leg Price
        /// </summary>
        public const long NoValue = 9223372036854775807;
    }
}