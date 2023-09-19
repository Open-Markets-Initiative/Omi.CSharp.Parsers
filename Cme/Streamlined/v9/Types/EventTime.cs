using System.Runtime.CompilerServices;

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
        ///  Size of Event Time in bytes
        /// </summary>
        public const int Size = 8;

        /// <summary>
        ///  Read Event Time
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong Decode()
        {
            fixed (byte* pointer = Bytes) { return (ulong)pointer; }
        }

        /// <summary>
        ///  Write Event Time
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(ulong value)
        {
            fixed (byte* pointer = Bytes) { *(ulong *)pointer = value; }
        }

        /// <summary>
        ///  Event Time as string
        /// </summary>
        public override string ToString()
            => $"{Decode()}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal unsafe fixed byte Bytes[Size];
    }
}