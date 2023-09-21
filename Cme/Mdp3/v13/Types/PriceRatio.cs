using System.Runtime.CompilerServices;

namespace Cme.Mdp3
{
    /// <summary>
    ///  Price Ratio: Used for price calculation in spread and leg pricing
    /// </summary>

    public unsafe struct PriceRatio
    {
        /// <summary>
        ///  Fix Tag for Price Ratio
        /// </summary>
        public const ushort FixTag = 5770;

        /// <summary>
        ///  Decimal place factor for Price Ratio
        /// </summary>
        public const long Factor = 1000000000;

        /// <summary>
        ///  Sentinel null value for Price Ratio
        /// </summary>
        public const long NoValue = 9223372036854775807;

        /// <summary>
        ///  Size of Price Ratio in bytes
        /// </summary>
        public const int Size = 8;

        /// <summary>
        ///  Read Price Ratio
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public long Decode()
        {
            fixed (byte* pointer = Bytes) { return ((long)pointer) / Factor; }
        }

        /// <summary>
        ///  Try Read Price Ratio
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryRead(out long value)
        {
            value = Decode();
            return value != NoValue;
        }

        /// <summary>
        ///  Write Price Ratio
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(long value)
        {
            fixed (byte* pointer = Bytes) { *(long *)pointer = value * Factor; }
        }

        /// <summary>
        ///  Set Price Ratio to unused
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Reset()
            => Encode(NoValue);

        /// <summary>
        ///  Price Ratio as string
        /// </summary>
        public override string ToString()
            => $"{Decode()}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal unsafe fixed byte Bytes[Size];
    }
}