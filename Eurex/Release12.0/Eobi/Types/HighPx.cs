using System.Runtime.CompilerServices;

namespace Eurex.Eobi
{
    /// <summary>
    ///  High Px
    /// </summary>

    public unsafe struct HighPx
    {
        /// <summary>
        ///  Decimal place factor for High Px
        /// </summary>
        public const ulong Factor = 100000000;

        /// <summary>
        ///  Size of High Px in bytes
        /// </summary>
        public const int Size = 8;

        /// <summary>
        ///  Read High Px
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong Decode()
        {
            fixed (byte* pointer = Bytes) { return ((ulong)pointer)/Factor; }
        }

        /// <summary>
        ///  Write High Px
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(ulong value)
        {
            fixed (byte* pointer = Bytes) { *(ulong *)pointer = value * Factor; }
        }

        /// <summary>
        ///  High Px as string
        /// </summary>
        public readonly override string ToString()
            => $"{Decode()}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal unsafe fixed byte Bytes[Size];
    }
}