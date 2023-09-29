using System.Runtime.CompilerServices;

namespace Cme.Mdp3
{
    /// <summary>
    ///  Md Entry Px: Trade price
    /// </summary>

    public struct MdEntryPx
    {
        /// <summary>
        ///  Fix Tag for Md Entry Px
        /// </summary>
        public const ushort FixTag = 270;

        /// <summary>
        ///  Decimal place factor for Md Entry Px
        /// </summary>
        public const long Factor = 1000000000;

        /// <summary>
        ///  Size of Md Entry Px in bytes
        /// </summary>
        public const int Size = 8;

        /// <summary>
        ///  Md Entry Px value
        /// </summary>
        public readonly long Value
            => Decode();

        /// <summary>
        ///  Read Md Entry Px
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly long Decode()
            => Underlying / Factor;

        /// <summary>
        ///  Write Md Entry Px
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(long value)
            => Underlying = value * Factor;

        /// <summary>
        ///  Md Entry Px as string
        /// </summary>
        public readonly override string ToString()
            => $"{Value}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal long Underlying;
    }
}