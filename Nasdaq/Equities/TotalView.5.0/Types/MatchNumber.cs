using System.Buffers.Binary;
using System.Runtime.CompilerServices;

namespace Nasdaq.TotalView
{
    /// <summary>
    ///  Match Number: The NASDAQ generated day-unique Match Number of this execution. The match number is also referenced in the Trade Break Message.
    /// </summary>

    public struct MatchNumber
    {
        /// <summary>
        ///  Size of Match Number in bytes
        /// </summary>
        public const int Size = 8;

        /// <summary>
        ///  Match Number value
        /// </summary>
        public readonly ulong Value
            => Decode();

        /// <summary>
        ///  Read Match Number
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly ulong Decode()
            => BinaryPrimitives.ReverseEndianness(Underlying);

        /// <summary>
        ///  Write Match Number
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(ulong value)
            => Underlying = BinaryPrimitives.ReverseEndianness(value);

        /// <summary>
        ///  Match Number as string
        /// </summary>
        public readonly override string ToString()
            => $"{Value}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal ulong Underlying;
    }
}