using System.Buffers.Binary;
using System.Runtime.CompilerServices;

namespace Nasdaq.TotalView
{
    /// <summary>
    ///  Order Reference Number: The unique reference number assigned to the new order at the time of receipt.
    /// </summary>

    public struct OrderReferenceNumber
    {
        /// <summary>
        ///  Size of Order Reference Number in bytes
        /// </summary>
        public const int Size = 8;

        /// <summary>
        ///  Order Reference Number value
        /// </summary>
        public readonly ulong Value
            => Decode();

        /// <summary>
        ///  Read Order Reference Number
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly ulong Decode()
            => BinaryPrimitives.ReverseEndianness(Underlying);

        /// <summary>
        ///  Write Order Reference Number
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(ulong value)
            => Underlying = BinaryPrimitives.ReverseEndianness(value);

        /// <summary>
        ///  Set Order Reference Number to unused
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Reset()
            => Encode(NoValue);

        /// <summary>
        ///  Order Reference Number as string
        /// </summary>
        public readonly override string ToString()
            => $"{Value}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal ulong Underlying;
    }
}