using System.Runtime.CompilerServices;

namespace Cme.Streamlined
{
    /// <summary>
    ///  Unit Of Measure Qty Optional: This field contains the notional value for each instrument. The notional value is equivalent to the corresponding premium-quoted contract
    /// </summary>

    public struct UnitOfMeasureQtyOptional
    {
        /// <summary>
        ///  Fix Tag for Unit Of Measure Qty Optional
        /// </summary>
        public const ushort FixTag = 1147;

        /// <summary>
        ///  Decimal place factor for Unit Of Measure Qty Optional
        /// </summary>
        public const long Factor = 10000000;

        /// <summary>
        ///  Sentinel null value for Unit Of Measure Qty Optional
        /// </summary>
        public const long NoValue = 9223372036854775807;

        /// <summary>
        ///  Size of Unit Of Measure Qty Optional in bytes
        /// </summary>
        public const int Size = 8;

        /// <summary>
        ///  Unit Of Measure Qty Optional value
        /// </summary>
        public readonly long Value
            => Decode();

        /// <summary>
        ///  Does Unit Of Measure Qty Optional field contain a value?
        /// </summary>
        public readonly bool HasValue
            => Underlying != NoValue;

        /// <summary>
        ///  Read Unit Of Measure Qty Optional
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly long Decode()
            => Underlying / Factor;

        /// <summary>
        ///  Try Read Unit Of Measure Qty Optional
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
        ///  Write Unit Of Measure Qty Optional
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(long value)
            => Underlying = value * Factor;

        /// <summary>
        ///  Set Unit Of Measure Qty Optional to unused
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Reset()
            => Encode(NoValue);

        /// <summary>
        ///  Unit Of Measure Qty Optional as string
        /// </summary>
        public readonly override string ToString()
            => TryRead(out var value) ? $"{value}" : "Not Applicable";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal long Underlying;
    }
}