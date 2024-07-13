using System.Buffers.Binary;
using System.Runtime.CompilerServices;

namespace Nasdaq.TotalView
{
    /// <summary>
    ///  Far Price: A hypothetical auction-clearing price for cross orders only. Refer to Data Types for field processing notes.
    /// </summary>

    public struct FarPrice
    {
        /// <summary>
        ///  Decimal place factor for Far Price
        /// </summary>
        public const uint Factor = 10000;

        /// <summary>
        ///  Size of Far Price in bytes
        /// </summary>
        public const int Size = 4;

        /// <summary>
        ///  Far Price value
        /// </summary>
        public readonly uint Value
            => Decode();

        /// <summary>
        ///  Read Far Price
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly uint Decode()
            => BinaryPrimitives.ReverseEndianness(Underlying) / Factor;

        /// <summary>
        ///  Write Far Price
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(uint value)
            => Underlying = BinaryPrimitives.ReverseEndianness(value) * Factor;

        /// <summary>
        ///  Set Far Price to unused
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Reset()
            => Encode(NoValue);

        /// <summary>
        ///  Far Price as string
        /// </summary>
        public readonly override string ToString()
            => $"{Value}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal uint Underlying;
    }
}