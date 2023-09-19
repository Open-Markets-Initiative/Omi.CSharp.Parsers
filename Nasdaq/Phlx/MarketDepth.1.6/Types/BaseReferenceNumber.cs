using System.Buffers.Binary;
using System.Runtime.CompilerServices;

namespace Nasdaq.MarketDepth
{
    /// <summary>
    ///  Base Reference Number: The base reference number
    /// </summary>

    public unsafe struct BaseReferenceNumber
    {
        /// <summary>
        ///  Length of Base Reference Number in bytes
        /// </summary>
        public const int Size = 8;

        /// <summary>
        ///  Read Base Reference Number
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong Decode()
        {
            fixed (byte* pointer = Bytes) { return BinaryPrimitives.ReverseEndianness((ulong)pointer); }
        }

        /// <summary>
        ///  Write Base Reference Number
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(ulong value)
        {
            fixed (byte* pointer = Bytes) { *(ulong *)pointer = BinaryPrimitives.ReverseEndianness(value); }
        }

        /// <summary>
        ///  Base Reference Number as string
        /// </summary>
        public override string ToString()
            => $"{Decode()}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal unsafe fixed byte Bytes[Size];
    }
}