using System.Runtime.CompilerServices;

namespace Cme.Streamlined
{
    /// <summary>
    ///  Mantissa 32: mantissa
    /// </summary>

    public struct Mantissa32
    {
        /// <summary>
        ///  Sentinel null value for Mantissa 32
        /// </summary>
        public const int NoValue = 2147483647;

        /// <summary>
        ///  Size of Mantissa 32 in bytes
        /// </summary>
        public const int Size = 4;

        /// <summary>
        ///  Mantissa 32 value
        /// </summary>
        public readonly int Value
            => Decode();

        /// <summary>
        ///  Does Mantissa 32 field contain a value?
        /// </summary>
        public readonly bool HasValue
            => Underlying != NoValue;

        /// <summary>
        ///  Read Mantissa 32
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly int Decode()
            => Underlying;

        /// <summary>
        ///  Try Read Mantissa 32
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool TryRead(out int value)
        {
            value = Decode();
            return HasValue;
        }

        /// <summary>
        ///  Write Mantissa 32
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(int value)
            => Underlying = value;

        /// <summary>
        ///  Set Mantissa 32 to unused
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Reset()
            => Encode(NoValue);

        /// <summary>
        ///  Mantissa 32 as string
        /// </summary>
        public readonly override string ToString()
            => TryRead(out var value) ? $"{value}" : "Not Applicable";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal int Underlying;
    }
}