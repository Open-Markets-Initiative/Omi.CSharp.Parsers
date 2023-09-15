namespace Cme.Sbe
{
    using System.Runtime.CompilerServices;

    /// <summary>
    ///  Leg Option Delta: 4 Byte Fixed Width Nullable Integer with 4 Decimal Place Precision
    /// </summary>

    public struct LegOptionDelta
    {
        /// <summary>
        ///  Fix Tag for Leg Option Delta
        /// </summary>
        public const ushort FixTag = 1017;

        /// <summary>
        ///  Length of Leg Option Delta in bytes
        /// </summary>
        public const int Length = 4;

        /// <summary>
        ///  Decimal place factor for Leg Option Delta
        /// </summary>
        public const int Factor = 10000;

        /// <summary>
        ///  Null value for Leg Option Delta
        /// </summary>
        public const int NoValue = 2147483647;
    }
}