using System.Runtime.CompilerServices;

namespace Cme.Streamlined
{
    /// <summary>
    ///  Unit Of Measure Qty Optional: 8 Byte Fixed Width Nullable Integer with 7 Decimal Place Precision
    /// </summary>

    public struct UnitOfMeasureQtyOptional
    {
        /// <summary>
        ///  Fix Tag for Unit Of Measure Qty Optional
        /// </summary>
        public const ushort FixTag = 1147;

        /// <summary>
        ///  Length of Unit Of Measure Qty Optional in bytes
        /// </summary>
        public const int Length = 8;

        /// <summary>
        ///  Decimal place factor for Unit Of Measure Qty Optional
        /// </summary>
        public const long Factor = 10000000;

        /// <summary>
        ///  Null value for Unit Of Measure Qty Optional
        /// </summary>
        public const long NoValue = 9223372036854775807;
    }
}