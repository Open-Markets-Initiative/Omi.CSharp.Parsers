using System.Buffers.Binary;
using System.Runtime.CompilerServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  Leg Ratio Price Numerator: Leg Ratio Price Numerator
    /// </summary>

    public unsafe struct LegRatioPriceNumerator
    {
        /// <summary>
        ///  Length of Leg Ratio Price Numerator in bytes
        /// </summary>
        public const int Size = 4;

        /// <summary>
        ///  Read Leg Ratio Price Numerator
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int Decode()
        {
            fixed (byte* pointer = Bytes) { return BinaryPrimitives.ReverseEndianness((int)pointer); }
        }

        /// <summary>
        ///  Write Leg Ratio Price Numerator
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(int value)
        {
            fixed (byte* pointer = Bytes) { *(int *)pointer = BinaryPrimitives.ReverseEndianness(value); }
        }

        /// <summary>
        ///  Leg Ratio Price Numerator as string
        /// </summary>
        public override string ToString()
            => $"{Decode()}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal unsafe fixed byte Bytes[Size];
    }
}