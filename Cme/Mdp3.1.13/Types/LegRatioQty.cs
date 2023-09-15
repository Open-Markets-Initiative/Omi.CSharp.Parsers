namespace Cme.Sbe
{
    using System.Runtime.CompilerServices;

    /// <summary>
    ///  Leg Ratio Qty: One Byte Fixed Width Integer
    /// </summary>

    public struct LegRatioQty
    {
        /// <summary>
        ///  Fix Tag for Leg Ratio Qty
        /// </summary>
        public const ushort FixTag = 623;

        /// <summary>
        ///  Length of Leg Ratio Qty in bytes
        /// </summary>
        public const int Length = 1;
    }
}