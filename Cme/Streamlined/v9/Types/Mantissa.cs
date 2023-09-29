using System.Runtime.CompilerServices;

namespace Cme.Streamlined
{
    /// <summary>
    ///  Mantissa: mantissa
    /// </summary>

    public struct Mantissa
    {
        /// <summary>
        ///  Sentinel null value for Mantissa
        /// </summary>
        public const long NoValue = 9223372036854775807;

        /// <summary>
        ///  Size of Mantissa in bytes
        /// </summary>
        public const int Size = 8;

        /// <summary>
        ///  Mantissa value
        /// </summary>
        public readonly long Value
            => Decode();

        /// <summary>
        ///  Does Mantissa field contain a value?
        /// </summary>
        public readonly bool HasValue
            => Underlying != NoValue;

        /// <summary>
        ///  Read Mantissa
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly long Decode()
            => Underlying;

        /// <summary>
        ///  Try Read Mantissa
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool TryRead(out long value)
        {
            value = Decode();
            return HasValue;
        }

        /// <summary>
        ///  Write Mantissa
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(long value)
            => Underlying = value;

        /// <summary>
        ///  Set Mantissa to unused
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Reset()
            => Encode(NoValue);

        /// <summary>
        ///  Mantissa as string
        /// </summary>
        public readonly override string ToString()
            => TryRead(out var value) ? $"{value}" : "Not Applicable";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal long Underlying;
    }
}