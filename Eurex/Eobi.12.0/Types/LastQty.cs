namespace Eurex.T7
{
    using System.Runtime.CompilerServices;

    /// <summary>
    ///  Last Qty: 8 Byte Fixed Width Integer with 4 Decimal Place Precision
    /// </summary>

    public struct LastQty
    {
        /// <summary>
        ///  Length of Last Qty in bytes
        /// </summary>
        public const int Length = 8;

        /// <summary>
        ///  Decimal place factor for Last Qty
        /// </summary>
        public const int Factor = 10000;
    }
}