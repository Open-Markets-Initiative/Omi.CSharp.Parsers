using System.Buffers.Binary;
using System.Runtime.CompilerServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  Num Of Book Entries: Number of book entries in the market. It is the number of order messages followed for full order depth snapshot channel. In case of price level snapshot, it is the number of price level messages that followed for the market.
    /// </summary>

    public struct NumOfBookEntries
    {
        /// <summary>
        ///  Size of Num Of Book Entries in bytes
        /// </summary>
        public const int Size = 4;

        /// <summary>
        ///  Num Of Book Entries value
        /// </summary>
        public readonly int Value
            => Decode();

        /// <summary>
        ///  Read Num Of Book Entries
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly int Decode()
            => BinaryPrimitives.ReverseEndianness(Underlying);

        /// <summary>
        ///  Write Num Of Book Entries
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(int value)
            => Underlying = BinaryPrimitives.ReverseEndianness(value);

        /// <summary>
        ///  Num Of Book Entries as string
        /// </summary>
        public readonly override string ToString()
            => $"{Value}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal int Underlying;
    }
}