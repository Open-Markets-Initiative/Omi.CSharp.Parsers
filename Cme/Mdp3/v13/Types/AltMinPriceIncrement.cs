using System.Runtime.CompilerServices;

namespace Cme.Mdp3
{
    /// <summary>
    ///  Alt Min Price Increment: New sub-tick which is only available for order entry when certain conditions are met, tick value which corresponds to the Alt Min Quote Life
    /// </summary>

    public unsafe struct AltMinPriceIncrement
    {
        /// <summary>
        ///  Fix Tag for Alt Min Price Increment
        /// </summary>
        public const ushort FixTag = 37739;

        /// <summary>
        ///  Decimal place factor for Alt Min Price Increment
        /// </summary>
        public const long Factor = 1000000000;

        /// <summary>
        ///  Sentinel null value for Alt Min Price Increment
        /// </summary>
        public const long NoValue = 9223372036854775807;

        /// <summary>
        ///  Size of Alt Min Price Increment in bytes
        /// </summary>
        public const int Size = 8;

        /// <summary>
        ///  Read Alt Min Price Increment
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public long Decode()
        {
            fixed (byte* pointer = Bytes) { return ((long)pointer) / Factor; }
        }

        /// <summary>
        ///  Try Read Alt Min Price Increment
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryRead(out long value)
        {
            value = Decode();
            return value != NoValue;
        }

        /// <summary>
        ///  Write Alt Min Price Increment
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(long value)
        {
            fixed (byte* pointer = Bytes) { *(long *)pointer = value * Factor; }
        }

        /// <summary>
        ///  Set Alt Min Price Increment to unused
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Reset()
            => Encode(NoValue);

        /// <summary>
        ///  Alt Min Price Increment as string
        /// </summary>
        public readonly override string ToString()
            => $"{Decode()}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal unsafe fixed byte Bytes[Size];
    }
}