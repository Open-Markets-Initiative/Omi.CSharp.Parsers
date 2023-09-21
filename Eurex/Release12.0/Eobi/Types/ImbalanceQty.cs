using System.Runtime.CompilerServices;

namespace Eurex.Eobi
{
    /// <summary>
    ///  Imbalance Qty
    /// </summary>

    public unsafe struct ImbalanceQty
    {
        /// <summary>
        ///  Decimal place factor for Imbalance Qty
        /// </summary>
        public const ulong Factor = 10000;

        /// <summary>
        ///  Size of Imbalance Qty in bytes
        /// </summary>
        public const int Size = 8;

        /// <summary>
        ///  Read Imbalance Qty
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong Decode()
        {
            fixed (byte* pointer = Bytes) { return ((ulong)pointer)/Factor; }
        }

        /// <summary>
        ///  Write Imbalance Qty
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(ulong value)
        {
            fixed (byte* pointer = Bytes) { *(ulong *)pointer = value * Factor; }
        }

        /// <summary>
        ///  Imbalance Qty as string
        /// </summary>
        public override string ToString()
            => $"{Decode()}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal unsafe fixed byte Bytes[Size];
    }
}