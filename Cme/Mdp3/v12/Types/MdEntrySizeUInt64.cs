using System.Runtime.CompilerServices;

namespace Cme.Mdp3
{
    /// <summary>
    ///  Md Entry Size u Int 64: Consolidated trade quantity, notional
    /// </summary>

    public unsafe struct MdEntrySizeUInt64
    {
        /// <summary>
        ///  Fix Tag for Md Entry Size u Int 64
        /// </summary>
        public const ushort FixTag = 271;

        /// <summary>
        ///  Size of Md Entry Size u Int 64 in bytes
        /// </summary>
        public const int Size = 8;

        /// <summary>
        ///  Read Md Entry Size u Int 64
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong Decode()
        {
            fixed (byte* pointer = Bytes) { return (ulong)pointer; }
        }

        /// <summary>
        ///  Write Md Entry Size u Int 64
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(ulong value)
        {
            fixed (byte* pointer = Bytes) { *(ulong *)pointer = value; }
        }

        /// <summary>
        ///  Md Entry Size u Int 64 as string
        /// </summary>
        public readonly override string ToString()
            => $"{Decode()}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal unsafe fixed byte Bytes[Size];
    }
}