using System.Runtime.CompilerServices;

namespace Cme.Mdp3
{
    /// <summary>
    ///  High Limit Price: Upper price threshold for the instrument
    /// </summary>

    public unsafe struct HighLimitPrice
    {
        /// <summary>
        ///  Fix Tag for High Limit Price
        /// </summary>
        public const ushort FixTag = 1149;

        /// <summary>
        ///  Decimal place factor for High Limit Price
        /// </summary>
        public const long Factor = 1000000000;

        /// <summary>
        ///  Sentinel null value for High Limit Price
        /// </summary>
        public const long NoValue = 9223372036854775807;

        /// <summary>
        ///  Size of High Limit Price in bytes
        /// </summary>
        public const int Size = 8;

        /// <summary>
        ///  Read High Limit Price
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public long Decode()
        {
            fixed (byte* pointer = Bytes) { return ((long)pointer) / Factor; }
        }

        /// <summary>
        ///  Try Read High Limit Price
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryRead(out long value)
        {
            value = Decode();
            return value != NoValue;
        }

        /// <summary>
        ///  Write High Limit Price
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(long value)
        {
            fixed (byte* pointer = Bytes) { *(long *)pointer = value * Factor; }
        }

        /// <summary>
        ///  Set High Limit Price to unused
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Reset()
            => Encode(NoValue);

        /// <summary>
        ///  High Limit Price as string
        /// </summary>
        public override string ToString()
            => $"{Decode()}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal unsafe fixed byte Bytes[Size];
    }
}