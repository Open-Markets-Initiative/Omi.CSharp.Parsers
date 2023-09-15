namespace Cme.Sbe
{
    using System.Runtime.CompilerServices;

    /// <summary>
    ///  Open Interest Qty: Optional 4 Byte Fixed Width Integer
    /// </summary>

    public struct OpenInterestQty
    {
        /// <summary>
        ///  Length of Open Interest Qty in bytes
        /// </summary>
        public const int Length = 4;

        /// <summary>
        ///  Null value for Open Interest Qty
        /// </summary>
        public const int NoValue = 2147483647;
    }
}