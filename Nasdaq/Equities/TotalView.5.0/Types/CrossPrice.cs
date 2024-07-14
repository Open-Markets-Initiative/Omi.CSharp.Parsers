using System.Buffers.Binary;
using System.Runtime.CompilerServices;

namespace Nasdaq.TotalView
{
    /// <summary>
    ///  Cross Price: The price at which the cross occurred.  Refer to Data Types for field processing notes.
    /// </summary>

    public struct CrossPrice
    {
        /// <summary>
        ///  Decimal place factor for Cross Price
        /// </summary>
        public const uint Factor = 10000;

        /// <summary>
        ///  Size of Cross Price in bytes
        /// </summary>
        public const int Size = 4;

        /// <summary>
        ///  Cross Price value
        /// </summary>
        public readonly uint Value
            => Decode();

        /// <summary>
        ///  Read Cross Price
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly uint Decode()
            => BinaryPrimitives.ReverseEndianness(Underlying) / Factor;

        /// <summary>
        ///  Write Cross Price
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(uint value)
            => Underlying = BinaryPrimitives.ReverseEndianness(value) * Factor;

        /// <summary>
        ///  Cross Price as string
        /// </summary>
        public readonly override string ToString()
            => $"{Value}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal uint Underlying;
    }
}