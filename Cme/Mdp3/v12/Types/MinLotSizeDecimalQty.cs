using System.Runtime.CompilerServices;

namespace Cme.Mdp3
{
    /// <summary>
    ///  Min Lot Size Decimal Qty: 4 Byte Fixed Width Nullable Integer with 4 Decimal Place Precision
    /// </summary>

    public struct MinLotSizeDecimalQty
    {
        /// <summary>
        ///  Fix Tag for Min Lot Size Decimal Qty
        /// </summary>
        public const ushort FixTag = 1231;

        /// <summary>
        ///  Length of Min Lot Size Decimal Qty in bytes
        /// </summary>
        public const int Length = 4;

        /// <summary>
        ///  Decimal place factor for Min Lot Size Decimal Qty
        /// </summary>
        public const int Factor = 10000;

        /// <summary>
        ///  Null value for Min Lot Size Decimal Qty
        /// </summary>
        public const int NoValue = 2147483647;
    }
}