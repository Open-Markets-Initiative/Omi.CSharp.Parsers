using System.Runtime.CompilerServices;

namespace Eurex.Eobi
{
    /// <summary>
    ///  Offer Px
    /// </summary>

    public unsafe struct OfferPx
    {
        /// <summary>
        ///  Decimal place factor for Offer Px
        /// </summary>
        public const ulong Factor = 100000000;

        /// <summary>
        ///  Size of Offer Px in bytes
        /// </summary>
        public const int Size = 8;

        /// <summary>
        ///  Read Offer Px
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong Decode()
        {
            fixed (byte* pointer = Bytes) { return ((ulong)pointer)/Factor; }
        }

        /// <summary>
        ///  Write Offer Px
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(ulong value)
        {
            fixed (byte* pointer = Bytes) { *(ulong *)pointer = value * Factor; }
        }

        /// <summary>
        ///  Offer Px as string
        /// </summary>
        public readonly override string ToString()
            => $"{Decode()}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal unsafe fixed byte Bytes[Size];
    }
}