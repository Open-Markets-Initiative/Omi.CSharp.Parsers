using System.Buffers.Binary;
using System.Runtime.CompilerServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  Leg Strategy Code: Leg Strategy Code
    /// </summary>

    public unsafe struct LegStrategyCode
    {
        /// <summary>
        ///  Length of Leg Strategy Code in bytes
        /// </summary>
        public const int Size = 2;

        /// <summary>
        ///  Read Leg Strategy Code
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public short Decode()
        {
            fixed (byte* pointer = Bytes) { return BinaryPrimitives.ReverseEndianness((short)pointer); }
        }

        /// <summary>
        ///  Write Leg Strategy Code
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(short value)
        {
            fixed (byte* pointer = Bytes) { *(short *)pointer = BinaryPrimitives.ReverseEndianness(value); }
        }

        /// <summary>
        ///  Leg Strategy Code as string
        /// </summary>
        public override string ToString()
            => $"{Decode()}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal unsafe fixed byte Bytes[Size];
    }
}