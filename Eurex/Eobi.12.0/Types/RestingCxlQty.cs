namespace Eurex.T7
{
    using System.Runtime.CompilerServices;

    /// <summary>
    ///  Resting Cxl Qty: 8 Byte Fixed Width Integer with 4 Decimal Place Precision
    /// </summary>

    public struct RestingCxlQty
    {
        /// <summary>
        ///  Length of Resting Cxl Qty in bytes
        /// </summary>
        public const int Length = 8;

        /// <summary>
        ///  Decimal place factor for Resting Cxl Qty
        /// </summary>
        public const int Factor = 10000;
    }
}