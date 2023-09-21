using System.Runtime.CompilerServices;

namespace Eurex.Eobi
{
    /// <summary>
    ///  Prev Display Qty
    /// </summary>

    public unsafe struct PrevDisplayQty
    {
        /// <summary>
        ///  Decimal place factor for Prev Display Qty
        /// </summary>
        public const ulong Factor = 10000;

        /// <summary>
        ///  Size of Prev Display Qty in bytes
        /// </summary>
        public const int Size = 8;

        /// <summary>
        ///  Read Prev Display Qty
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong Decode()
        {
            fixed (byte* pointer = Bytes) { return ((ulong)pointer)/Factor; }
        }

        /// <summary>
        ///  Write Prev Display Qty
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(ulong value)
        {
            fixed (byte* pointer = Bytes) { *(ulong *)pointer = value * Factor; }
        }

        /// <summary>
        ///  Prev Display Qty as string
        /// </summary>
        public override string ToString()
            => $"{Decode()}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal unsafe fixed byte Bytes[Size];
    }
}