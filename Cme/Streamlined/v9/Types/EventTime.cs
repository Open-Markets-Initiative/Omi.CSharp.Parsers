using System.Runtime.CompilerServices;

namespace Cme.Streamlined
{
    /// <summary>
    ///  Event Time: Time of event. This is number of days since unix epoch
    /// </summary>

    public struct EventTime
    {
        /// <summary>
        ///  Fix Tag for Event Time
        /// </summary>
        public const ushort FixTag = 1145;

        /// <summary>
        ///  Size of Event Time in bytes
        /// </summary>
        public const int Size = 8;

        /// <summary>
        ///  Event Time value
        /// </summary>
        public readonly ulong Value
            => Decode();

        /// <summary>
        ///  Read Event Time
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly ulong Decode()
            => Underlying;

        /// <summary>
        ///  Write Event Time
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(ulong value)
            => Underlying = value;

        /// <summary>
        ///  Event Time as string
        /// </summary>
        public readonly override string ToString()
            => $"{Value}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal ulong Underlying;
    }
}