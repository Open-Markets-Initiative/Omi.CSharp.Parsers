using System.Runtime.CompilerServices;

namespace Cme.Mdp3
{
    /// <summary>
    ///  Md Entry Size Optional: Market Data entry size
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
        public const int NoValue = 2147483647;

        /// <summary>
        ///  Size of Md Entry Size Optional in bytes
        /// </summary>
        public const int Size = 4;

        /// <summary>
        ///  Md Entry Size Optional value
        /// </summary>
        public readonly int Value
            => Decode();

        /// <summary>
        ///  Does Md Entry Size Optional field contain a value?
        /// </summary>
        public readonly bool HasValue
            => Underlying != NoValue;

        /// <summary>
        ///  Read Md Entry Size Optional
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly int Decode()
            => Underlying;

        /// <summary>
        ///  Try Read Md Entry Size Optional
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool TryRead(out int value)
        {
            value = Decode();
            return HasValue;
        }

        /// <summary>
        ///  Write Md Entry Size Optional
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(int value)
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
        internal int Underlying;
    }
}