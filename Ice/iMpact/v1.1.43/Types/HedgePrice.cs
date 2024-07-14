using System.Buffers.Binary;
using System.Runtime.CompilerServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  Hedge Price: HedgePrice
    /// </summary>

    public struct HedgePrice
    {
        /// <summary>
        ///  Size of Hedge Price in bytes
        /// </summary>
        public const int Size = 8;

        /// <summary>
        ///  Hedge Price value
        /// </summary>
        public readonly long Value
            => Decode();

        /// <summary>
        ///  Read Hedge Price
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly long Decode()
            => BinaryPrimitives.ReverseEndianness(Underlying);

        /// <summary>
        ///  Write Hedge Price
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(long value)
            => Underlying = BinaryPrimitives.ReverseEndianness(value);

        /// <summary>
        ///  Hedge Price as string
        /// </summary>
        public readonly override string ToString()
            => $"{Value}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal long Underlying;
    }
}