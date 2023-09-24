using System.Runtime.CompilerServices;

namespace Cme.Mdp3
{
    /// <summary>
    ///  Current Chunk: Chunk sequence
    /// </summary>

    public unsafe struct CurrentChunk
    {
        /// <summary>
        ///  Fix Tag for Current Chunk
        /// </summary>
        public const ushort FixTag = 37710;

        /// <summary>
        ///  Size of Current Chunk in bytes
        /// </summary>
        public const int Size = 4;

        /// <summary>
        ///  Read Current Chunk
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Decode()
        {
            fixed (byte* pointer = Bytes) { return (uint)pointer; }
        }

        /// <summary>
        ///  Write Current Chunk
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(uint value)
        {
            fixed (byte* pointer = Bytes) { *(uint *)pointer = value; }
        }

        /// <summary>
        ///  Current Chunk as string
        /// </summary>
        public readonly override string ToString()
            => $"{Decode()}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal unsafe fixed byte Bytes[Size];
    }
}