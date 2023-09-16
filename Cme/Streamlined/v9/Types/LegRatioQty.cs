using System.Runtime.CompilerServices;;

namespace Cme.Streamlined
{
    /// <summary>
    ///  Leg Ratio Qty: Optional 4 Byte Fixed Width Integer
    /// </summary>

    public struct LegRatioQty
    {
        /// <summary>
        ///  Length of Leg Ratio Qty in bytes
        /// </summary>
        public const int Length = 4;

        /// <summary>
        ///  Null value for Leg Ratio Qty
        /// </summary>
        public const int NoValue = 2147483647;
    }
}