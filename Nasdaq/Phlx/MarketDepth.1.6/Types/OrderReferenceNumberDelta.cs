using System.Buffers.Binary;
using System.Runtime.CompilerServices;

namespace Nasdaq.MarketDepth
{
    /// <summary>
    ///  Order Reference Number Delta: The unique reference number delta assigned to the new order. The order reference number is Increasing, but not necessarily sequential.
    /// </summary>

    public unsafe struct OrderReferenceNumberDelta
    {
        /// <summary>
        ///  Length of Order Reference Number Delta in bytes
        /// </summary>
        public const int Size = 4;

        /// <summary>
        ///  Read Order Reference Number Delta
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Decode()
        {
            fixed (byte* pointer = Bytes) { return BinaryPrimitives.ReverseEndianness((uint)pointer); }
        }

        /// <summary>
        ///  Write Order Reference Number Delta
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(uint value)
        {
            fixed (byte* pointer = Bytes) { *(uint *)pointer = BinaryPrimitives.ReverseEndianness(value); }
        }

        /// <summary>
        ///  Order Reference Number Delta as string
        /// </summary>
        public override string ToString()
            => $"{Decode()}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal unsafe fixed byte Bytes[Size];
    }
}