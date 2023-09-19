using System.Runtime.CompilerServices;

namespace Cme.Mdp3
{
    /// <summary>
    ///  Md Entry Size: Cumulative traded volume
    /// </summary>

    public unsafe struct MdEntrySize
    {
        /// <summary>
        ///  Fix Tag for Md Entry Size
        /// </summary>
        public const ushort FixTag = 271;

        /// <summary>
        ///  Size of Md Entry Size in bytes
        /// </summary>
        public const int Size = 4;

        /// <summary>
        ///  Read Md Entry Size
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int Decode()
        {
            fixed (byte* pointer = Bytes) { return (int)pointer; }
        }

        /// <summary>
        ///  Write Md Entry Size
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(int value)
        {
            fixed (byte* pointer = Bytes) { *(int *)pointer = value; }
        }

        /// <summary>
        ///  Md Entry Size as string
        /// </summary>
        public override string ToString()
            => $"{Decode()}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal unsafe fixed byte Bytes[Size];
    }
}