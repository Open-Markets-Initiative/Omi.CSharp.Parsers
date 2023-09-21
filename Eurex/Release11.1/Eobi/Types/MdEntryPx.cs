using System.Runtime.CompilerServices;

namespace Eurex.Eobi
{
    /// <summary>
    ///  Md Entry Px
    /// </summary>

    public unsafe struct MdEntryPx
    {
        /// <summary>
        ///  Decimal place factor for Md Entry Px
        /// </summary>
        public const ulong Factor = 100000000;

        /// <summary>
        ///  Size of Md Entry Px in bytes
        /// </summary>
        public const int Size = 8;

        /// <summary>
        ///  Read Md Entry Px
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong Decode()
        {
            fixed (byte* pointer = Bytes) { return ((ulong)pointer)/Factor; }
        }

        /// <summary>
        ///  Write Md Entry Px
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(ulong value)
        {
            fixed (byte* pointer = Bytes) { *(ulong *)pointer = value * Factor; }
        }

        /// <summary>
        ///  Md Entry Px as string
        /// </summary>
        public override string ToString()
            => $"{Decode()}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal unsafe fixed byte Bytes[Size];
    }
}