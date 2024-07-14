using System.Runtime.CompilerServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  Order Price Denominator: Denominator for the order price fields in this market.
    /// </summary>

    public struct OrderPriceDenominator
    {
        /// <summary>
        ///  Size of Order Price Denominator in bytes
        /// </summary>
        public const int Size = 1;

        /// <summary>
        ///  Order Price Denominator value
        /// </summary>
        public readonly char Value
            => (char)Byte;

        /// <summary>
        ///  Write Order Price Denominator
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(char value)
            => Byte = (byte)value;

        /// <summary>
        ///  Order Price Denominator as string
        /// </summary>
        public readonly override string ToString()
            => $"{Value}";

        /// <summary>
        ///  Underlying byte
        /// </summary>
        internal byte Byte;
    }
}