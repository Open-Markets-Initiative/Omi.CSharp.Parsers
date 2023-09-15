namespace Cme.Sbe
{
    using System.Runtime.CompilerServices;

    /// <summary>
    ///  Max Bid Ask Constraint: 8 Byte Fixed Width Nullable Integer with 9 Decimal Place Precision
    /// </summary>

    public struct MaxBidAskConstraint
    {
        /// <summary>
        ///  Fix Tag for Max Bid Ask Constraint
        /// </summary>
        public const ushort FixTag = 37743;

        /// <summary>
        ///  Length of Max Bid Ask Constraint in bytes
        /// </summary>
        public const int Length = 8;

        /// <summary>
        ///  Decimal place factor for Max Bid Ask Constraint
        /// </summary>
        public const long Factor = 1000000000;

        /// <summary>
        ///  Null value for Max Bid Ask Constraint
        /// </summary>
        public const long NoValue = 9223372036854775807;
    }
}