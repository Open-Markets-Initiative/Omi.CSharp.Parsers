namespace Cme.Sbe
{
    using System.Runtime.CompilerServices;

    /// <summary>
    ///  Order Id Optional: Optional 8 Byte Fixed Width Integer
    /// </summary>

    public struct OrderIdOptional
    {
        /// <summary>
        ///  Length of Order Id Optional in bytes
        /// </summary>
        public const int Length = 8;

        /// <summary>
        ///  Null value for Order Id Optional
        /// </summary>
        public const ulong NoValue = 18446744073709551615;
    }
}