using System.Runtime.CompilerServices;

namespace Nyse.AmexOptions.BinaryGateway
{
    /// <summary>
    ///  Luldmpv: Numeric value of the Minimum Price Variation for LULD bands for securities belonging to the MPVClass.
    /// </summary>

    public unsafe struct Luldmpv
    {
        /// <summary>
        ///  Decimal place factor for Luldmpv
        /// </summary>
        public const ulong Factor = 100000000;

        /// <summary>
        ///  Size of Luldmpv in bytes
        /// </summary>
        public const int Size = 8;

        /// <summary>
        ///  Read Luldmpv
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong Decode()
        {
            fixed (byte* pointer = Bytes) { return ((ulong)pointer)/Factor; }
        }

        /// <summary>
        ///  Write Luldmpv
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(ulong value)
        {
            fixed (byte* pointer = Bytes) { *(ulong *)pointer = value * Factor; }
        }

        /// <summary>
        ///  Luldmpv as string
        /// </summary>
        public readonly override string ToString()
            => $"{Decode()}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal unsafe fixed byte Bytes[Size];
    }
}