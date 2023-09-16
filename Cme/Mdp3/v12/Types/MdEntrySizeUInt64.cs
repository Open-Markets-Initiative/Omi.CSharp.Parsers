using System.Runtime.CompilerServices;;

namespace Cme.Mdp3
{
    /// <summary>
    ///  Md Entry Size u Int 64: Consolidated trade quantity, notional
    /// </summary>

    public unsafe struct MdEntrySizeUInt64
    {
        /// <summary>
        ///  Fix Tag for Md Entry Size u Int 64
        /// </summary>
        public const ushort FixTag = 271;

        /// <summary>
        ///  Length of Md Entry Size u Int 64 in bytes
        /// </summary>
        public const int Length = 8;

        /// <summary>
        ///  Read Md Entry Size u Int 64
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong Decode()
            => Value;

        /// <summary>
        ///  Encode Md Entry Size u Int 64
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(ulong value)
            => Value = value;

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal ulong Value;
    }
}