using System.Buffers.Binary;
using System.Runtime.CompilerServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  Strike Price: Strike Price of the option. Used in conjunction with the NumDecimalsStrikePrice. This is often different from the premium price decimals.
    /// </summary>

    public unsafe struct StrikePrice
    {
        /// <summary>
        ///  Length of Strike Price in bytes
        /// </summary>
        public const int Size = 8;

        /// <summary>
        ///  Read Strike Price
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public long Decode()
        {
            fixed (byte* pointer = Bytes) { return BinaryPrimitives.ReverseEndianness((long)pointer); }
        }

        /// <summary>
        ///  Write Strike Price
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(long value)
        {
            fixed (byte* pointer = Bytes) { *(long *)pointer = BinaryPrimitives.ReverseEndianness(value); }
        }

        /// <summary>
        ///  Strike Price as string
        /// </summary>
        public override string ToString()
            => $"{Decode()}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal unsafe fixed byte Bytes[Size];
    }
}