namespace Cme.Sbe
{
    using System.Runtime.CompilerServices;

    /// <summary>
    ///  Order Qty: Optional 4 Byte Fixed Width Integer
    /// </summary>

    public struct OrderQty
    {
        /// <summary>
        ///  Length of Order Qty in bytes
        /// </summary>
        public const int Length = 4;

        /// <summary>
        ///  Null value for Order Qty
        /// </summary>
        public const int NoValue = 2147483647;
    }
}