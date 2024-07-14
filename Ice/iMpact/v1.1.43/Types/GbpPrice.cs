using System.Buffers.Binary;
using System.Runtime.CompilerServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  Gbp Price: Obsolete. The price will be published via the Fixing Indicative Price Message.
    /// </summary>

    public struct GbpPrice
    {
        /// <summary>
        ///  Size of Gbp Price in bytes
        /// </summary>
        public const int Size = 8;

        /// <summary>
        ///  Gbp Price value
        /// </summary>
        public readonly long Value
            => Decode();

        /// <summary>
        ///  Read Gbp Price
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly long Decode()
            => BinaryPrimitives.ReverseEndianness(Underlying);

        /// <summary>
        ///  Write Gbp Price
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(long value)
            => Underlying = BinaryPrimitives.ReverseEndianness(value);

        /// <summary>
        ///  Gbp Price as string
        /// </summary>
        public readonly override string ToString()
            => $"{Value}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal long Underlying;
    }
}