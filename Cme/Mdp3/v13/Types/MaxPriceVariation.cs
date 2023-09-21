using System.Runtime.CompilerServices;

namespace Cme.Mdp3
{
    /// <summary>
    ///  Max Price Variation: Differential value for price banding
    /// </summary>

    public unsafe struct MaxPriceVariation
    {
        /// <summary>
        ///  Fix Tag for Max Price Variation
        /// </summary>
        public const ushort FixTag = 1143;

        /// <summary>
        ///  Decimal place factor for Max Price Variation
        /// </summary>
        public const long Factor = 1000000000;

        /// <summary>
        ///  Sentinel null value for Max Price Variation
        /// </summary>
        public const long NoValue = 9223372036854775807;

        /// <summary>
        ///  Size of Max Price Variation in bytes
        /// </summary>
        public const int Size = 8;

        /// <summary>
        ///  Read Max Price Variation
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public long Decode()
        {
            fixed (byte* pointer = Bytes) { return ((long)pointer) / Factor; }
        }

        /// <summary>
        ///  Try Read Max Price Variation
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryRead(out long value)
        {
            value = Decode();
            return value != NoValue;
        }

        /// <summary>
        ///  Write Max Price Variation
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(long value)
        {
            fixed (byte* pointer = Bytes) { *(long *)pointer = value * Factor; }
        }

        /// <summary>
        ///  Set Max Price Variation to unused
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Reset()
            => Encode(NoValue);

        /// <summary>
        ///  Max Price Variation as string
        /// </summary>
        public override string ToString()
            => $"{Decode()}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal unsafe fixed byte Bytes[Size];
    }
}