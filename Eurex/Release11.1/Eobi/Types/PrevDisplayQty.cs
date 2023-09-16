using System.Runtime.CompilerServices;;

namespace Eurex.Eobi
{
    /// <summary>
    ///  Prev Display Qty: 8 Byte Fixed Width Integer with 4 Decimal Place Precision
    /// </summary>

    public struct PrevDisplayQty
    {
        /// <summary>
        ///  Length of Prev Display Qty in bytes
        /// </summary>
        public const int Length = 8;

        /// <summary>
        ///  Decimal place factor for Prev Display Qty
        /// </summary>
        public const int Factor = 10000;
    }
}