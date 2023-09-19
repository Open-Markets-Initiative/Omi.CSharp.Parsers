using System.Runtime.CompilerServices;

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
        ///  Size of Transact Time in bytes
        /// </summary>
        public const int Size = 8;

        /// <summary>
        ///  Read Transact Time
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong Decode()
        {
            fixed (byte* pointer = Bytes) { return (ulong)pointer; }
        }

        /// <summary>
        ///  Write Transact Time
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(ulong value)
        {
            fixed (byte* pointer = Bytes) { *(ulong *)pointer = value; }
        }

        /// <summary>
        ///  Transact Time as string
        /// </summary>
        public override string ToString()
            => $"{Decode()}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal unsafe fixed byte Bytes[Size];
    }
}