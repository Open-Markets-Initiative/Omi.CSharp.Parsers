using System.Buffers.Binary;
using System.Runtime.CompilerServices;

namespace Nasdaq.MarketDepth
{
    /// <summary>
    ///  Imbalance Volume: The imbalance contracts.
    /// </summary>

    public struct ImbalanceVolume
    {
        /// <summary>
        ///  Size of Imbalance Volume in bytes
        /// </summary>
        public const int Size = 4;

        /// <summary>
        ///  Imbalance Volume value
        /// </summary>
        public readonly uint Value
            => Decode();

        /// <summary>
        ///  Read Imbalance Volume
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly uint Decode()
            => BinaryPrimitives.ReverseEndianness(Underlying);

        /// <summary>
        ///  Write Imbalance Volume
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(uint value)
            => Underlying = BinaryPrimitives.ReverseEndianness(value);

        /// <summary>
        ///  Imbalance Volume as string
        /// </summary>
        public readonly override string ToString()
            => $"{Value}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal uint Underlying;
    }
}