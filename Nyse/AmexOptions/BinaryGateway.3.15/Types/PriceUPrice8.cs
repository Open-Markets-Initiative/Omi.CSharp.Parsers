using System.Runtime.CompilerServices;

namespace Nyse.AmexOptions.BinaryGateway
{
    /// <summary>
    ///  Price U Price 8: Order entry Limit price range for the MPVLevel
    /// </summary>

    public unsafe struct PriceUPrice8
    {
        /// <summary>
        ///  Decimal place factor for Price U Price 8
        /// </summary>
        public const ulong Factor = 100000000;

        /// <summary>
        ///  Size of Price U Price 8 in bytes
        /// </summary>
        public const int Size = 8;

        /// <summary>
        ///  Read Price U Price 8
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong Decode()
        {
            fixed (byte* pointer = Bytes) { return ((ulong)pointer)/Factor; }
        }

        /// <summary>
        ///  Write Price U Price 8
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(ulong value)
        {
            fixed (byte* pointer = Bytes) { *(ulong *)pointer = value * Factor; }
        }

        /// <summary>
        ///  Price U Price 8 as string
        /// </summary>
        public readonly override string ToString()
            => $"{Decode()}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal unsafe fixed byte Bytes[Size];
    }
}