using System.Runtime.CompilerServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  Settle Price Denominator: Denominator for the settlement price fields in the market. For most markets, this is the same as DealPriceDenominator.
    /// </summary>

    public struct SettlePriceDenominator
    {
        /// <summary>
        ///  Size of Settle Price Denominator in bytes
        /// </summary>
        public const int Size = 1;

        /// <summary>
        ///  Settle Price Denominator value
        /// </summary>
        public readonly char Value
            => (char)Byte;

        /// <summary>
        ///  Write Settle Price Denominator
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(char value)
            => Byte = (byte)value;

        /// <summary>
        ///  Settle Price Denominator as string
        /// </summary>
        public readonly override string ToString()
            => $"{Value}";

        /// <summary>
        ///  Underlying byte
        /// </summary>
        internal byte Byte;
    }
}