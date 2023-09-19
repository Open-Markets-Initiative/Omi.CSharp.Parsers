using System.Buffers.Binary;
using System.Runtime.CompilerServices;

namespace Nasdaq.MarketDepth
{
    /// <summary>
    ///  Original Ask Reference Number Delta: The original ask reference number delta associated with the order being replaced.
    /// </summary>

    public unsafe struct OriginalAskReferenceNumberDelta
    {
        /// <summary>
        ///  Length of Original Ask Reference Number Delta in bytes
        /// </summary>
        public const int Size = 4;

        /// <summary>
        ///  Read Original Ask Reference Number Delta
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Decode()
        {
            fixed (byte* pointer = Bytes) { return BinaryPrimitives.ReverseEndianness((uint)pointer); }
        }

        /// <summary>
        ///  Write Original Ask Reference Number Delta
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(uint value)
        {
            fixed (byte* pointer = Bytes) { *(uint *)pointer = BinaryPrimitives.ReverseEndianness(value); }
        }

        /// <summary>
        ///  Original Ask Reference Number Delta as string
        /// </summary>
        public override string ToString()
            => $"{Decode()}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal unsafe fixed byte Bytes[Size];
    }
}