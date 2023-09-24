using System.Runtime.CompilerServices;

namespace Cme.Mdp3
{
    /// <summary>
    ///  Min Price Increment Amount: Monetary value equivalent to the minimum price fluctuation
    /// </summary>

    public unsafe struct MinPriceIncrementAmount
    {
        /// <summary>
        ///  Fix Tag for Min Price Increment Amount
        /// </summary>
        public const ushort FixTag = 1146;

        /// <summary>
        ///  Decimal place factor for Min Price Increment Amount
        /// </summary>
        public const long Factor = 1000000000;

        /// <summary>
        ///  Sentinel null value for Min Price Increment Amount
        /// </summary>
        public const long NoValue = 9223372036854775807;

        /// <summary>
        ///  Size of Min Price Increment Amount in bytes
        /// </summary>
        public const int Size = 8;

        /// <summary>
        ///  Read Min Price Increment Amount
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public long Decode()
        {
            fixed (byte* pointer = Bytes) { return ((long)pointer) / Factor; }
        }

        /// <summary>
        ///  Try Read Min Price Increment Amount
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryRead(out long value)
        {
            value = Decode();
            return value != NoValue;
        }

        /// <summary>
        ///  Write Min Price Increment Amount
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(long value)
        {
            fixed (byte* pointer = Bytes) { *(long *)pointer = value * Factor; }
        }

        /// <summary>
        ///  Set Min Price Increment Amount to unused
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Reset()
            => Encode(NoValue);

        /// <summary>
        ///  Min Price Increment Amount as string
        /// </summary>
        public readonly override string ToString()
            => $"{Decode()}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal unsafe fixed byte Bytes[Size];
    }
}