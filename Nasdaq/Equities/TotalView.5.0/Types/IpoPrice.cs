using System.Buffers.Binary;
using System.Runtime.CompilerServices;

namespace Nasdaq.TotalView
{
    /// <summary>
    ///  Ipo Price: Denotes the IPO price to be used for intraday net change calculations. Prices are given in decimal format with 6 whole number places followed by 4 decimal digits.
    /// </summary>

    public struct IpoPrice
    {
        /// <summary>
        ///  Decimal place factor for Ipo Price
        /// </summary>
        public const uint Factor = 10000;

        /// <summary>
        ///  Size of Ipo Price in bytes
        /// </summary>
        public const int Size = 4;

        /// <summary>
        ///  Ipo Price value
        /// </summary>
        public readonly uint Value
            => Decode();

        /// <summary>
        ///  Read Ipo Price
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly uint Decode()
            => BinaryPrimitives.ReverseEndianness(Underlying) / Factor;

        /// <summary>
        ///  Write Ipo Price
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(uint value)
            => Underlying = BinaryPrimitives.ReverseEndianness(value) * Factor;

        /// <summary>
        ///  Set Ipo Price to unused
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Reset()
            => Encode(NoValue);

        /// <summary>
        ///  Ipo Price as string
        /// </summary>
        public readonly override string ToString()
            => $"{Value}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal uint Underlying;
    }
}