using System.Runtime.CompilerServices;;

namespace Cme.Streamlined
{
    /// <summary>
    ///  Number Of Orders: Optional 4 Byte Fixed Width Integer
    /// </summary>

    public struct NumberOfOrders
    {
        /// <summary>
        ///  Length of Number Of Orders in bytes
        /// </summary>
        public const int Length = 4;

        /// <summary>
        ///  Null value for Number Of Orders
        /// </summary>
        public const int NoValue = 2147483647;
    }
}