using System.Runtime.CompilerServices;

namespace Cme.Streamlined
{
    /// <summary>
    ///  Md Entry Px Optional: Price of the Market Data Entry
    /// </summary>

    public struct MdEntryPxOptional
    {
        /// <summary>
        ///  Fix Tag for Md Entry Px Optional
        /// </summary>
        public const ushort FixTag = 270;

        /// <summary>
        ///  Decimal place factor for Md Entry Px Optional
        /// </summary>
        public const long Factor = 10000000;

        /// <summary>
        ///  Sentinel null value for Md Entry Px Optional
        /// </summary>
        public const long NoValue = 9223372036854775807;

        /// <summary>
        ///  Size of Md Entry Px Optional in bytes
        /// </summary>
        public const int Size = 8;

        /// <summary>
        ///  Md Entry Px Optional value
        /// </summary>
        public readonly long Value
            => Decode();

        /// <summary>
        ///  Does Md Entry Px Optional field contain a value?
        /// </summary>
        public readonly bool HasValue
            => Underlying != NoValue;

        /// <summary>
        ///  Read Md Entry Px Optional
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly long Decode()
            => Underlying / Factor;

        /// <summary>
        ///  Try Read Md Entry Px Optional
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool TryRead(out long value)
        {
            if (HasValue)
            {
                value = Decode();
                return true;
            }

            value = default;
            return false;
        }

        /// <summary>
        ///  Write Md Entry Px Optional
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(long value)
            => Underlying = value * Factor;

        /// <summary>
        ///  Set Md Entry Px Optional to unused
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Reset()
            => Encode(NoValue);

        /// <summary>
        ///  Md Entry Px Optional as string
        /// </summary>
        public readonly override string ToString()
            => TryRead(out var value) ? $"{value}" : "Not Applicable";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal long Underlying;
    }
}