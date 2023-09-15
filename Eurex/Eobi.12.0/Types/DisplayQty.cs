namespace Eurex.T7
{
    using System.Runtime.CompilerServices;

    /// <summary>
    ///  Display Qty: 8 Byte Fixed Width Integer with 4 Decimal Place Precision
    /// </summary>

    public struct DisplayQty
    {
        /// <summary>
        ///  Length of Display Qty in bytes
        /// </summary>
        public const int Length = 8;

        /// <summary>
        ///  Decimal place factor for Display Qty
        /// </summary>
        public const int Factor = 10000;
    }
}