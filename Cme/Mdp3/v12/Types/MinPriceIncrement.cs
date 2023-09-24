using System.Runtime.CompilerServices;

namespace Cme.Mdp3
{
    /// <summary>
    ///  Min Price Increment: Minimum constant tick for the instrument, sent only if instrument is non-VTT (Variable Tick table) eligible
    /// </summary>

    public unsafe struct MinPriceIncrement
    {
        /// <summary>
        ///  Fix Tag for Min Price Increment
        /// </summary>
        public const ushort FixTag = 969;

        /// <summary>
        ///  Decimal place factor for Min Price Increment
        /// </summary>
        public const long Factor = 1000000000;

        /// <summary>
        ///  Size of Min Price Increment in bytes
        /// </summary>
        public const int Size = 8;

        /// <summary>
        ///  Read Min Price Increment
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public long Decode()
        {
            fixed (byte* pointer = Bytes) { return ((long)pointer)/Factor; }
        }

        /// <summary>
        ///  Write Min Price Increment
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(long value)
        {
            fixed (byte* pointer = Bytes) { *(long *)pointer = value * Factor; }
        }

        /// <summary>
        ///  Min Price Increment as string
        /// </summary>
        public readonly override string ToString()
            => $"{Decode()}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal unsafe fixed byte Bytes[Size];
    }
}