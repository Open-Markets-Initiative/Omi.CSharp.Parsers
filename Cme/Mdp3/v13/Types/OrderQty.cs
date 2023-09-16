using System.Runtime.CompilerServices;;

namespace Cme.Mdp3
{
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