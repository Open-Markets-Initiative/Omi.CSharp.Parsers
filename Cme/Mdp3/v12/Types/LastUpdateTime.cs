using System.Runtime.CompilerServices;;

namespace Cme.Mdp3
{
    /// <summary>
    ///  Last Update Time: UTC Date and time of last Security Definition add, update or delete on a given Market Data channel
    /// </summary>

    public unsafe struct LastUpdateTime
    {
        /// <summary>
        ///  Fix Tag for Last Update Time
        /// </summary>
        public const ushort FixTag = 779;

        /// <summary>
        ///  Length of Last Update Time in bytes
        /// </summary>
        public const int Length = 8;

        /// <summary>
        ///  Read Last Update Time
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong Decode()
            => Value;

        /// <summary>
        ///  Encode Last Update Time
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