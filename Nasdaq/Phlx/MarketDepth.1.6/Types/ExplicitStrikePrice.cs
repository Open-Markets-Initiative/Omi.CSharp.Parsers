using System.Buffers.Binary;
using System.Runtime.CompilerServices;

namespace Nasdaq.MarketDepth
{
    /// <summary>
    ///  Explicit Strike Price: Explicit strike price. Refer to Data Types for field processing notes.
    /// </summary>

    public struct ExplicitStrikePrice
    {
        /// <summary>
        ///  Decimal place factor for Explicit Strike Price
        /// </summary>
        public const int Factor = 10000;

        /// <summary>
        ///  Size of Explicit Strike Price in bytes
        /// </summary>
        public const int Size = 4;

        /// <summary>
        ///  Explicit Strike Price value
        /// </summary>
        public readonly int Value
            => Decode();

        /// <summary>
        ///  Read Explicit Strike Price
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly int Decode()
            => BinaryPrimitives.ReverseEndianness(Underlying) / Factor;

        /// <summary>
        ///  Write Explicit Strike Price
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(int value)
            => Underlying = BinaryPrimitives.ReverseEndianness(value) * Factor;

        /// <summary>
        ///  Explicit Strike Price as string
        /// </summary>
        public readonly override string ToString()
            => $"{Value}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal int Underlying;
    }
}