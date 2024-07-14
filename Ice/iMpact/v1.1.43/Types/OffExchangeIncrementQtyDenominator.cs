using System.Runtime.CompilerServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  Off Exchange Increment Qty Denominator: Denominator for OffExchangeIncrementQty.
    /// </summary>

    public struct OffExchangeIncrementQtyDenominator
    {
        /// <summary>
        ///  Size of Off Exchange Increment Qty Denominator in bytes
        /// </summary>
        public const int Size = 1;

        /// <summary>
        ///  Off Exchange Increment Qty Denominator value
        /// </summary>
        public readonly char Value
            => (char)Byte;

        /// <summary>
        ///  Write Off Exchange Increment Qty Denominator
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(char value)
            => Byte = (byte)value;

        /// <summary>
        ///  Off Exchange Increment Qty Denominator as string
        /// </summary>
        public readonly override string ToString()
            => $"{Value}";

        /// <summary>
        ///  Underlying byte
        /// </summary>
        internal byte Byte;
    }
}