using System.Runtime.CompilerServices;

namespace Cme.Streamlined
{
    /// <summary>
    ///  Notional Percentage Outstanding: Indicates the notional percentage of the deal that is still outstanding based on the remaining components of the index
    /// </summary>

    public struct NotionalPercentageOutstanding
    {
        /// <summary>
        ///  Fix Tag for Notional Percentage Outstanding
        /// </summary>
        public const ushort FixTag = 1451;

        /// <summary>
        ///  Decimal place factor for Notional Percentage Outstanding
        /// </summary>
        public const int Factor = 10000;

        /// <summary>
        ///  Sentinel null value for Notional Percentage Outstanding
        /// </summary>
        public const int NoValue = 2147483647;

        /// <summary>
        ///  Size of Notional Percentage Outstanding in bytes
        /// </summary>
        public const int Size = 4;

        /// <summary>
        ///  Notional Percentage Outstanding value
        /// </summary>
        public readonly int Value
            => Decode();

        /// <summary>
        ///  Read Notional Percentage Outstanding
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly int Decode()
            => Underlying / Factor;

        /// <summary>
        ///  Try Read Notional Percentage Outstanding
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryRead(out int value)
        {
            value = Decode();
            return value != NoValue;
        }

        /// <summary>
        ///  Write Notional Percentage Outstanding
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(int value)
            => Underlying = value * Factor;

        /// <summary>
        ///  Set Notional Percentage Outstanding to unused
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Reset()
            => Encode(NoValue);

        /// <summary>
        ///  Notional Percentage Outstanding as string
        /// </summary>
        public readonly override string ToString()
            => TryRead(out var value) ? $"{value}" : "Not Applicable";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal int Underlying;
    }
}