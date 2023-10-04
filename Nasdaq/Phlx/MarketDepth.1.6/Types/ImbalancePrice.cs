using System.Buffers.Binary;
using System.Runtime.CompilerServices;

namespace Nasdaq.MarketDepth
{
    /// <summary>
    ///  Imbalance Price: The imbalance price.
    /// </summary>

    public struct ImbalancePrice
    {
        /// <summary>
        ///  Decimal place factor for Imbalance Price
        /// </summary>
        public const int Factor = 10000;

        /// <summary>
        ///  Size of Imbalance Price in bytes
        /// </summary>
        public const int Size = 4;

        /// <summary>
        ///  Imbalance Price value
        /// </summary>
        public readonly int Value
            => Decode();

        /// <summary>
        ///  Read Imbalance Price
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly int Decode()
            => BinaryPrimitives.ReverseEndianness(Underlying) / Factor;

        /// <summary>
        ///  Write Imbalance Price
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(int value)
            => Underlying = BinaryPrimitives.ReverseEndianness(value) * Factor;

        /// <summary>
        ///  Set Imbalance Price to unused
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Reset()
            => Encode(NoValue);

        /// <summary>
        ///  Imbalance Price as string
        /// </summary>
        public readonly override string ToString()
            => $"{Value}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal int Underlying;
    }
}