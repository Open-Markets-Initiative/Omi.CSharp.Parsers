using System.Runtime.CompilerServices;

namespace Cme.Streamlined
{
    /// <summary>
    ///  Md Entry Px 9: Price of the Market Data Entry
    /// </summary>

    public struct MdEntryPx9
    {
        /// <summary>
        ///  Fix Tag for Md Entry Px 9
        /// </summary>
        public const ushort FixTag = 270;

        /// <summary>
        ///  Decimal place factor for Md Entry Px 9
        /// </summary>
        public const long Factor = 1000000000;

        /// <summary>
        ///  Sentinel null value for Md Entry Px 9
        /// </summary>
        public const long NoValue = 9223372036854775807;

        /// <summary>
        ///  Size of Md Entry Px 9 in bytes
        /// </summary>
        public const int Size = 8;

        /// <summary>
        ///  Md Entry Px 9 value
        /// </summary>
        public readonly long Value
            => Decode();

        /// <summary>
        ///  Read Md Entry Px 9
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly long Decode()
            => Underlying / Factor;

        /// <summary>
        ///  Try Read Md Entry Px 9
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryRead(out long value)
        {
            value = Decode();
            return value != NoValue;
        }

        /// <summary>
        ///  Write Md Entry Px 9
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(long value)
            => Underlying = value * Factor;

        /// <summary>
        ///  Set Md Entry Px 9 to unused
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Reset()
            => Encode(NoValue);

        /// <summary>
        ///  Md Entry Px 9 as string
        /// </summary>
        public readonly override string ToString()
            => TryRead(out var value) ? $"{value}" : "Not Applicable";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal long Underlying;
    }
}