using System.Runtime.CompilerServices;

namespace Eurex.Eobi
{
    /// <summary>
    ///  Resting Hidden Qty
    /// </summary>

    public unsafe struct RestingHiddenQty
    {
        /// <summary>
        ///  Decimal place factor for Resting Hidden Qty
        /// </summary>
        public const ulong Factor = 10000;

        /// <summary>
        ///  Size of Resting Hidden Qty in bytes
        /// </summary>
        public const int Size = 8;

        /// <summary>
        ///  Read Resting Hidden Qty
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong Decode()
        {
            fixed (byte* pointer = Bytes) { return ((ulong)pointer)/Factor; }
        }

        /// <summary>
        ///  Write Resting Hidden Qty
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(ulong value)
        {
            fixed (byte* pointer = Bytes) { *(ulong *)pointer = value * Factor; }
        }

        /// <summary>
        ///  Resting Hidden Qty as string
        /// </summary>
        public readonly override string ToString()
            => $"{Decode()}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal unsafe fixed byte Bytes[Size];
    }
}