using using System.Runtime.CompilerServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  Deal Price Denominator: Denominator for the deal price fields in the market. For most markets, this is the same as OrderPriceDenominator. However, it could be different for some crack or spread markets.
    /// </summary>

    public struct DealPriceDenominator
    {
        /// <summary>
        ///  Size of Deal Price Denominator in bytes
        /// </summary>
        public const int Size = 1;

        /// <summary>
        ///  Deal Price Denominator value
        /// </summary>
        public readonly string Value
            => (char)Byte;

        /// <summary>
        ///  Write Deal Price Denominator
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(char value)
            => Byte = (byte)value;
        /// <summary>
        ///  Deal Price Denominator as string
        /// </summary>
        public override string ToString()
            => Value;

        /// <summary>
        ///  Underlying byte
        /// </summary>
        internal byte Byte;
    }
}