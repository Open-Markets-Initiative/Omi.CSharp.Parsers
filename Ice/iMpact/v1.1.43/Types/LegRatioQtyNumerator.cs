using System.Buffers.Binary;
using System.Runtime.CompilerServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  Leg Ratio Qty Numerator: Leg Ratio Qty Numerator
    /// </summary>

    public unsafe struct LegRatioQtyNumerator
    {
        /// <summary>
        ///  Length of Leg Ratio Qty Numerator in bytes
        /// </summary>
        public const int Size = 4;

        /// <summary>
        ///  Read Leg Ratio Qty Numerator
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int Decode()
        {
            fixed (byte* pointer = Bytes) { return BinaryPrimitives.ReverseEndianness((int)pointer); }
        }

        /// <summary>
        ///  Write Leg Ratio Qty Numerator
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(int value)
        {
            fixed (byte* pointer = Bytes) { *(int *)pointer = BinaryPrimitives.ReverseEndianness(value); }
        }

        /// <summary>
        ///  Leg Ratio Qty Numerator as string
        /// </summary>
        public override string ToString()
            => $"{Decode()}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal unsafe fixed byte Bytes[Size];
    }
}