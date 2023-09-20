using System.Runtime.CompilerServices;

namespace Cme.Mdp3
{
    /// <summary>
    ///  Alt Price Increment Constraint: 8 Byte Fixed Width Nullable Integer with 9 Decimal Place Precision
    /// </summary>

    public struct AltPriceIncrementConstraint
    {
        /// <summary>
        ///  Fix Tag for Alt Price Increment Constraint
        /// </summary>
        public const ushort FixTag = 37742;

        /// <summary>
        ///  Length of Alt Price Increment Constraint in bytes
        /// </summary>
        public const int Length = 8;

        /// <summary>
        ///  Decimal place factor for Alt Price Increment Constraint
        /// </summary>
        public const long Factor = 1000000000;

        /// <summary>
        ///  Null value for Alt Price Increment Constraint
        /// </summary>
        public const long NoValue = 9223372036854775807;
    }
}