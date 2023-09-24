using System.Buffers.Binary;
using System.Runtime.CompilerServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  Off Exchange Increment Option Price: Off exchange options increment price. NumDecimalsOptionsPrice should be applied to this field
    /// </summary>

    public unsafe struct OffExchangeIncrementOptionPrice
    {
        /// <summary>
        ///  Length of Off Exchange Increment Option Price in bytes
        /// </summary>
        public const int Size = 4;

        /// <summary>
        ///  Read Off Exchange Increment Option Price
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int Decode()
        {
            fixed (byte* pointer = Bytes) { return BinaryPrimitives.ReverseEndianness((int)pointer); }
        }

        /// <summary>
        ///  Write Off Exchange Increment Option Price
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(int value)
        {
            fixed (byte* pointer = Bytes) { *(int *)pointer = BinaryPrimitives.ReverseEndianness(value); }
        }

        /// <summary>
        ///  Off Exchange Increment Option Price as string
        /// </summary>
        public readonly override string ToString()
            => $"{Decode()}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal unsafe fixed byte Bytes[Size];
    }
}