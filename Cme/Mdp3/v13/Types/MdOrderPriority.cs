using System.Runtime.CompilerServices;

namespace Cme.Mdp3
{
    /// <summary>
    ///  Md Order Priority: Order priority for execution on the order book
    /// </summary>

    public unsafe struct MdOrderPriority
    {
        /// <summary>
        ///  Fix Tag for Md Order Priority
        /// </summary>
        public const ushort FixTag = 37707;

        /// <summary>
        ///  Size of Md Order Priority in bytes
        /// </summary>
        public const int Size = 8;

        /// <summary>
        ///  Read Md Order Priority
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong Decode()
        {
            fixed (byte* pointer = Bytes) { return (ulong)pointer; }
        }

        /// <summary>
        ///  Write Md Order Priority
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(ulong value)
        {
            fixed (byte* pointer = Bytes) { *(ulong *)pointer = value; }
        }

        /// <summary>
        ///  Md Order Priority as string
        /// </summary>
        public override string ToString()
            => $"{Decode()}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal unsafe fixed byte Bytes[Size];
    }
}