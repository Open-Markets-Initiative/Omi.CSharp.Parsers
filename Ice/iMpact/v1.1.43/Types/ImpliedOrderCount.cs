using System.Buffers.Binary;
using System.Runtime.CompilerServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  Implied Order Count: Number of implied orders at the price level
    /// </summary>

    public struct ImpliedOrderCount
    {
        /// <summary>
        ///  Size of Implied Order Count in bytes
        /// </summary>
        public const int Size = 2;

        /// <summary>
        ///  Implied Order Count value
        /// </summary>
        public readonly short Value
            => Decode();

        /// <summary>
        ///  Read Implied Order Count
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly short Decode()
            => BinaryPrimitives.ReverseEndianness(Underlying);

        /// <summary>
        ///  Write Implied Order Count
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(short value)
            => Underlying = BinaryPrimitives.ReverseEndianness(value);

        /// <summary>
        ///  Implied Order Count as string
        /// </summary>
        public readonly override string ToString()
            => $"{Value}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal short Underlying;
    }
}