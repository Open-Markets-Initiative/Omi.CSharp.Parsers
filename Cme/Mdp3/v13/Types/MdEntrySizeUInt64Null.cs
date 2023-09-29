using System.Runtime.CompilerServices;

namespace Cme.Mdp3
{
    /// <summary>
    ///  Md Entry Size u Int 64 Null: Aggregate booked qty at price level, notional
    /// </summary>

    public struct MdEntrySizeUInt64Null
    {
        /// <summary>
        ///  Fix Tag for Md Entry Size u Int 64 Null
        /// </summary>
        public const ushort FixTag = 271;

        /// <summary>
        ///  Sentinel null value for Md Entry Size u Int 64 Null
        /// </summary>
        public const ulong NoValue = 18446744073709551615;

        /// <summary>
        ///  Size of Md Entry Size u Int 64 Null in bytes
        /// </summary>
        public const int Size = 8;

        /// <summary>
        ///  Md Entry Size u Int 64 Null value
        /// </summary>
        public readonly ulong Value
            => Decode();

        /// <summary>
        ///  Does Md Entry Size u Int 64 Null field contain a value?
        /// </summary>
        public readonly bool HasValue
            => Underlying != NoValue;

        /// <summary>
        ///  Read Md Entry Size u Int 64 Null
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly ulong Decode()
            => Underlying;

        /// <summary>
        ///  Try Read Md Entry Size u Int 64 Null
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool TryRead(out ulong value)
        {
            value = Decode();
            return HasValue;
        }

        /// <summary>
        ///  Write Md Entry Size u Int 64 Null
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(ulong value)
            => Underlying = value;

        /// <summary>
        ///  Set Md Entry Size u Int 64 Null to unused
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Reset()
            => Encode(NoValue);

        /// <summary>
        ///  Md Entry Size u Int 64 Null as string
        /// </summary>
        public readonly override string ToString()
            => TryRead(out var value) ? $"{value}" : "Not Applicable";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal ulong Underlying;
    }
}