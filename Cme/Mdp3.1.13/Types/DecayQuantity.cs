namespace Cme.Sbe
{
    using System.Runtime.CompilerServices;

    /// <summary>
    ///  Decay Quantity: Optional 4 Byte Fixed Width Integer
    /// </summary>

    public struct DecayQuantity
    {
        /// <summary>
        ///  Length of Decay Quantity in bytes
        /// </summary>
        public const int Length = 4;

        /// <summary>
        ///  Null value for Decay Quantity
        /// </summary>
        public const int NoValue = 2147483647;
    }
}