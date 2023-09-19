using System.Buffers.Binary;
using System.Runtime.CompilerServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  Volume: Electronic trade volume only, excluding block and other volumes.
    /// </summary>

    public unsafe struct Volume
    {
        /// <summary>
        ///  Length of Volume in bytes
        /// </summary>
        public const int Size = 4;

        /// <summary>
        ///  Read Volume
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int Decode()
        {
            fixed (byte* pointer = Bytes) { return BinaryPrimitives.ReverseEndianness((int)pointer); }
        }

        /// <summary>
        ///  Write Volume
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(int value)
        {
            fixed (byte* pointer = Bytes) { *(int *)pointer = BinaryPrimitives.ReverseEndianness(value); }
        }

        /// <summary>
        ///  Volume as string
        /// </summary>
        public override string ToString()
            => $"{Decode()}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal unsafe fixed byte Bytes[Size];
    }
}