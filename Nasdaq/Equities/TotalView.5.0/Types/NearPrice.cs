using System.Buffers.Binary;
using System.Runtime.CompilerServices;

namespace Nasdaq.TotalView
{
    /// <summary>
    ///  Near Price: A hypothetical auction-clearing price for cross orders as well as continuous orders. Refer to Data Types for field processing notes.
    /// </summary>

    public struct NearPrice
    {
        /// <summary>
        ///  Decimal place factor for Near Price
        /// </summary>
        public const uint Factor = 10000;

        /// <summary>
        ///  Size of Near Price in bytes
        /// </summary>
        public const int Size = 4;

        /// <summary>
        ///  Near Price value
        /// </summary>
        public readonly uint Value
            => Decode();

        /// <summary>
        ///  Read Near Price
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly uint Decode()
            => BinaryPrimitives.ReverseEndianness(Underlying) / Factor;

        /// <summary>
        ///  Write Near Price
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(uint value)
            => Underlying = BinaryPrimitives.ReverseEndianness(value) * Factor;

        /// <summary>
        ///  Set Near Price to unused
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Reset()
            => Encode(NoValue);

        /// <summary>
        ///  Near Price as string
        /// </summary>
        public readonly override string ToString()
            => $"{Value}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal uint Underlying;
    }
}