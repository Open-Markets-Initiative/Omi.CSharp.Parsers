using System.Runtime.CompilerServices;

namespace Cme.Mdp3
{
    /// <summary>
    ///  No Chunks: Total number of packets that constitutes a single instrument order book
    /// </summary>

    public unsafe struct NoChunks
    {
        /// <summary>
        ///  Fix Tag for No Chunks
        /// </summary>
        public const ushort FixTag = 37709;

        /// <summary>
        ///  Size of No Chunks in bytes
        /// </summary>
        public const int Size = 4;

        /// <summary>
        ///  Read No Chunks
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Decode()
        {
            fixed (byte* pointer = Bytes) { return (uint)pointer; }
        }

        /// <summary>
        ///  Write No Chunks
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(uint value)
        {
            fixed (byte* pointer = Bytes) { *(uint *)pointer = value; }
        }

        /// <summary>
        ///  No Chunks as string
        /// </summary>
        public readonly override string ToString()
            => $"{Decode()}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal unsafe fixed byte Bytes[Size];
    }
}