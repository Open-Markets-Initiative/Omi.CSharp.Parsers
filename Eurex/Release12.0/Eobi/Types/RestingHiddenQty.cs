using System.Runtime.CompilerServices;

namespace Eurex.Eobi
{
    /// <summary>
    ///  Resting Hidden Qty: 8 Byte Fixed Width Integer with 4 Decimal Place Precision
    /// </summary>

    public struct RestingHiddenQty
    {
        /// <summary>
        ///  Length of Resting Hidden Qty in bytes
        /// </summary>
        public const int Length = 8;

        /// <summary>
        ///  Decimal place factor for Resting Hidden Qty
        /// </summary>
        public const int Factor = 10000;
    }
}