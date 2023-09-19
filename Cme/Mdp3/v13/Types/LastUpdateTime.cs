using System.Runtime.CompilerServices;

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
        ///  Size of Last Update Time in bytes
        /// </summary>
        public const int Size = 8;

        /// <summary>
        ///  Read Last Update Time
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong Decode()
        {
            fixed (byte* pointer = Bytes) { return (ulong)pointer; }
        }

        /// <summary>
        ///  Write Last Update Time
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(ulong value)
        {
            fixed (byte* pointer = Bytes) { *(ulong *)pointer = value; }
        }

        /// <summary>
        ///  Last Update Time as string
        /// </summary>
        public override string ToString()
            => $"{Decode()}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal unsafe fixed byte Bytes[Size];
    }
}