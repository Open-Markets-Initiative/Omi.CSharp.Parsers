using System.Runtime.CompilerServices;

namespace Nyse.AmexOptions.BinaryGateway
{
    /// <summary>
    ///  Rpimpv: Numeric value of the Minimum Price Variation for Retail Price Improvement (RPI) orders for securities belonging to the MPVClass.
    /// </summary>

    public unsafe struct Rpimpv
    {
        /// <summary>
        ///  Decimal place factor for Rpimpv
        /// </summary>
        public const ulong Factor = 100000000;

        /// <summary>
        ///  Size of Rpimpv in bytes
        /// </summary>
        public const int Size = 8;

        /// <summary>
        ///  Read Rpimpv
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong Decode()
        {
            fixed (byte* pointer = Bytes) { return ((ulong)pointer)/Factor; }
        }

        /// <summary>
        ///  Write Rpimpv
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(ulong value)
        {
            fixed (byte* pointer = Bytes) { *(ulong *)pointer = value * Factor; }
        }

        /// <summary>
        ///  Rpimpv as string
        /// </summary>
        public readonly override string ToString()
            => $"{Decode()}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal unsafe fixed byte Bytes[Size];
    }
}