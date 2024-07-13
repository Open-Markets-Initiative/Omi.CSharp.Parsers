using System.Buffers.Binary;
using System.Runtime.CompilerServices;

namespace Nasdaq.TotalView
{
    /// <summary>
    ///  Current Reference Price: The price at which the NOII shares are being calculated.   Refer to Data Types for field processing notes.
    /// </summary>

    public struct CurrentReferencePrice
    {
        /// <summary>
        ///  Decimal place factor for Current Reference Price
        /// </summary>
        public const uint Factor = 10000;

        /// <summary>
        ///  Size of Current Reference Price in bytes
        /// </summary>
        public const int Size = 4;

        /// <summary>
        ///  Current Reference Price value
        /// </summary>
        public readonly uint Value
            => Decode();

        /// <summary>
        ///  Read Current Reference Price
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly uint Decode()
            => BinaryPrimitives.ReverseEndianness(Underlying) / Factor;

        /// <summary>
        ///  Write Current Reference Price
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(uint value)
            => Underlying = BinaryPrimitives.ReverseEndianness(value) * Factor;

        /// <summary>
        ///  Set Current Reference Price to unused
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Reset()
            => Encode(NoValue);

        /// <summary>
        ///  Current Reference Price as string
        /// </summary>
        public readonly override string ToString()
            => $"{Value}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal uint Underlying;
    }
}