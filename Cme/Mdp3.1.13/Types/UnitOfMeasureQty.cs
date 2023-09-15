namespace Cme.Sbe
{
    using System.Runtime.CompilerServices;

    /// <summary>
    ///  Unit Of Measure Qty: 8 Byte Fixed Width Nullable Integer with 9 Decimal Place Precision
    /// </summary>

    public struct UnitOfMeasureQty
    {
        /// <summary>
        ///  Fix Tag for Unit Of Measure Qty
        /// </summary>
        public const ushort FixTag = 1147;

        /// <summary>
        ///  Length of Unit Of Measure Qty in bytes
        /// </summary>
        public const int Length = 8;

        /// <summary>
        ///  Decimal place factor for Unit Of Measure Qty
        /// </summary>
        public const long Factor = 1000000000;

        /// <summary>
        ///  Null value for Unit Of Measure Qty
        /// </summary>
        public const long NoValue = 9223372036854775807;
    }
}