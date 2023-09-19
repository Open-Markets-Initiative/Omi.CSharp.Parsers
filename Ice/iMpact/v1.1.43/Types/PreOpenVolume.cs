using System.Buffers.Binary;
using System.Runtime.CompilerServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  Pre Open Volume: Indicative volume that would trade at the preOpenPrice
    /// </summary>

    public unsafe struct PreOpenVolume
    {
        /// <summary>
        ///  Length of Pre Open Volume in bytes
        /// </summary>
        public const int Size = 4;

        /// <summary>
        ///  Read Pre Open Volume
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int Decode()
        {
            fixed (byte* pointer = Bytes) { return BinaryPrimitives.ReverseEndianness((int)pointer); }
        }

        /// <summary>
        ///  Write Pre Open Volume
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(int value)
        {
            fixed (byte* pointer = Bytes) { *(int *)pointer = BinaryPrimitives.ReverseEndianness(value); }
        }

        /// <summary>
        ///  Pre Open Volume as string
        /// </summary>
        public override string ToString()
            => $"{Decode()}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal unsafe fixed byte Bytes[Size];
    }
}