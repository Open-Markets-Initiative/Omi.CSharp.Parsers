using System.Buffers.Binary;
using System.Runtime.CompilerServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  Ipl Hold Duration: Hold duration, in milliseconds. N/A when IPLHoldNotifyType = ‘E’
    /// </summary>

    public unsafe struct IplHoldDuration
    {
        /// <summary>
        ///  Length of Ipl Hold Duration in bytes
        /// </summary>
        public const int Size = 4;

        /// <summary>
        ///  Read Ipl Hold Duration
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int Decode()
        {
            fixed (byte* pointer = Bytes) { return BinaryPrimitives.ReverseEndianness((int)pointer); }
        }

        /// <summary>
        ///  Write Ipl Hold Duration
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(int value)
        {
            fixed (byte* pointer = Bytes) { *(int *)pointer = BinaryPrimitives.ReverseEndianness(value); }
        }

        /// <summary>
        ///  Ipl Hold Duration as string
        /// </summary>
        public override string ToString()
            => $"{Decode()}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal unsafe fixed byte Bytes[Size];
    }
}