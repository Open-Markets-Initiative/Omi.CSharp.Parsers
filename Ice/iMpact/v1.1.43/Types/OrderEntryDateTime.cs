using System.Buffers.Binary;
using System.Runtime.CompilerServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  Order Entry Date Time: Order entry date time. Milliseconds since Jan 1st, 1970, 00:00:00 GMT.
    /// </summary>

    public unsafe struct OrderEntryDateTime
    {
        /// <summary>
        ///  Length of Order Entry Date Time in bytes
        /// </summary>
        public const int Size = 8;

        /// <summary>
        ///  Read Order Entry Date Time
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public long Decode()
        {
            fixed (byte* pointer = Bytes) { return BinaryPrimitives.ReverseEndianness((long)pointer); }
        }

        /// <summary>
        ///  Write Order Entry Date Time
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(long value)
        {
            fixed (byte* pointer = Bytes) { *(long *)pointer = BinaryPrimitives.ReverseEndianness(value); }
        }

        /// <summary>
        ///  Order Entry Date Time as string
        /// </summary>
        public override string ToString()
            => $"{Decode()}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal unsafe fixed byte Bytes[Size];
    }
}