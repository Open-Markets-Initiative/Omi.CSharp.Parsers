using System.Runtime.CompilerServices;

namespace Eurex.Eobi
{
    /// <summary>
    ///  Imbalance Qty: 8 Byte Fixed Width Integer with 4 Decimal Place Precision
    /// </summary>

    public struct ImbalanceQty
    {
        /// <summary>
        ///  Length of Imbalance Qty in bytes
        /// </summary>
        public const int Length = 8;

        /// <summary>
        ///  Decimal place factor for Imbalance Qty
        /// </summary>
        public const int Factor = 10000;
    }
}