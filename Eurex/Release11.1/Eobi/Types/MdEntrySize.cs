using System.Runtime.CompilerServices;

namespace Eurex.Eobi
{
    /// <summary>
    ///  Md Entry Size
    /// </summary>

    public unsafe struct MdEntrySize
    {
        /// <summary>
        ///  Decimal place factor for Md Entry Size
        /// </summary>
        public const ulong Factor = 10000;

        /// <summary>
        ///  Size of Md Entry Size in bytes
        /// </summary>
        public const int Size = 8;

        /// <summary>
        ///  Read Md Entry Size
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong Decode()
        {
            fixed (byte* pointer = Bytes) { return ((ulong)pointer)/Factor; }
        }

        /// <summary>
        ///  Write Md Entry Size
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(ulong value)
        {
            fixed (byte* pointer = Bytes) { *(ulong *)pointer = value * Factor; }
        }

        /// <summary>
        ///  Md Entry Size as string
        /// </summary>
        public readonly override string ToString()
            => $"{Decode()}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal unsafe fixed byte Bytes[Size];
    }
}