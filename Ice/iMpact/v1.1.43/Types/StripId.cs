using System.Buffers.Binary;
using System.Runtime.CompilerServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  Strip Id: StripID
    /// </summary>

    public unsafe struct StripId
    {
        /// <summary>
        ///  Length of Strip Id in bytes
        /// </summary>
        public const int Size = 4;

        /// <summary>
        ///  Read Strip Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int Decode()
        {
            fixed (byte* pointer = Bytes) { return BinaryPrimitives.ReverseEndianness((int)pointer); }
        }

        /// <summary>
        ///  Write Strip Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(int value)
        {
            fixed (byte* pointer = Bytes) { *(int *)pointer = BinaryPrimitives.ReverseEndianness(value); }
        }

        /// <summary>
        ///  Strip Id as string
        /// </summary>
        public override string ToString()
            => $"{Decode()}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal unsafe fixed byte Bytes[Size];
    }
}