using System.Runtime.CompilerServices;;

namespace Cme.Streamlined
{
    /// <summary>
    ///  Event Time: Time of event. This is number of days since unix epoch
    /// </summary>

    public unsafe struct EventTime
    {
        /// <summary>
        ///  Fix Tag for Event Time
        /// </summary>
        public const ushort FixTag = 1145;

        /// <summary>
        ///  Length of Event Time in bytes
        /// </summary>
        public const int Length = 8;

        /// <summary>
        ///  Read Event Time
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong Decode()
            => Value;

        /// <summary>
        ///  Encode Event Time
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