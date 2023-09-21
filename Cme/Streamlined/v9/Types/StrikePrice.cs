using System.Runtime.CompilerServices;

namespace Cme.Streamlined
{
    /// <summary>
    ///  Strike Price: Strike Price for an option instrument
    /// </summary>

    public unsafe struct StrikePrice
    {
        /// <summary>
        ///  Fix Tag for Strike Price
        /// </summary>
        public const ushort FixTag = 202;

        /// <summary>
        ///  Decimal place factor for Strike Price
        /// </summary>
        public const long Factor = 10000000;

        /// <summary>
        ///  Sentinel null value for Strike Price
        /// </summary>
        public const long NoValue = 9223372036854775807;

        /// <summary>
        ///  Size of Strike Price in bytes
        /// </summary>
        public const int Size = 8;

        /// <summary>
        ///  Read Strike Price
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public long Decode()
        {
            fixed (byte* pointer = Bytes) { return ((long)pointer) / Factor; }
        }

        /// <summary>
        ///  Try Read Strike Price
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryRead(out long value)
        {
            value = Decode();
            return value != NoValue;
        }

        /// <summary>
        ///  Write Strike Price
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(long value)
        {
            fixed (byte* pointer = Bytes) { *(long *)pointer = value * Factor; }
        }

        /// <summary>
        ///  Set Strike Price to unused
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Reset()
            => Encode(NoValue);

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