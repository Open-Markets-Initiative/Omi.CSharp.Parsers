using System.Runtime.CompilerServices;;

namespace Cme.Mdp3
{
    /// <summary>
    ///  Sending Time: Packet Sending Time
    /// </summary>

    public unsafe struct SendingTime
    {
        /// <summary>
        ///  Length of Sending Time in bytes
        /// </summary>
        public const int Length = 8;

        /// <summary>
        ///  Read Sending Time
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong Decode()
            => Value;

        /// <summary>
        ///  Encode Sending Time
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