using System.Runtime.CompilerServices;

namespace Cme.Streamlined
{
    /// <summary>
    ///  Md Entry Size Optional: Quantity or volume represented by the Market Data Entry
    /// </summary>

    public struct MdEntrySizeOptional
    {
        /// <summary>
        ///  Fix Tag for Md Entry Size Optional
        /// </summary>
        public const ushort FixTag = 271;

        /// <summary>
        ///  Sentinel null value for Md Entry Size Optional
        /// </summary>
        public const ulong NoValue = 18446744073709551615;

        /// <summary>
        ///  Size of Md Entry Size Optional in bytes
        /// </summary>
        public const int Size = 8;

        /// <summary>
        ///  Md Entry Size Optional value
        /// </summary>
        public readonly ulong Value
            => Decode();

        /// <summary>
        ///  Read Md Entry Size Optional
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly ulong Decode()
            => Underlying;

        /// <summary>
        ///  Try Read Md Entry Size Optional
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool TryRead(out ulong value)
        {
            value = Decode();
            return value != NoValue;
        }

        /// <summary>
        ///  Write Md Entry Size Optional
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(ulong value)
            => Underlying = value;

        /// <summary>
        ///  Set Md Entry Size Optional to unused
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Reset()
            => Encode(NoValue);

        /// <summary>
        ///  Md Entry Size Optional as string
        /// </summary>
        public readonly override string ToString()
            => TryRead(out var value) ? $"{value}" : "Not Applicable";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal ulong Underlying;
    }
}