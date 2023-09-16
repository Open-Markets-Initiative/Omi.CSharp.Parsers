using System.Runtime.CompilerServices;;

namespace Cme.Mdp3
{
    /// <summary>
    ///  Transact Time: Start of event processing time in number of nanoseconds since Unix epoch
    /// </summary>

    public unsafe struct TransactTime
    {
        /// <summary>
        ///  Fix Tag for Transact Time
        /// </summary>
        public const ushort FixTag = 60;

        /// <summary>
        ///  Length of Transact Time in bytes
        /// </summary>
        public const int Length = 8;

        /// <summary>
        ///  Read Transact Time
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong Decode()
            => Value;

        /// <summary>
        ///  Encode Transact Time
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