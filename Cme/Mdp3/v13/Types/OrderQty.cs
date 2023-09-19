using System.Runtime.CompilerServices;

namespace Cme.Mdp3
{
    /// <summary>
    ///  Order Qty: Quantity requested
    /// </summary>

    public unsafe struct OrderQty
    {
        /// <summary>
        ///  Fix Tag for Order Qty
        /// </summary>
        public const ushort FixTag = 38;

        /// <summary>
        ///  Length of Order Qty in bytes
        /// </summary>
        public const int Length = 4;

        /// <summary>
        ///  Sentinel null value for Order Qty
        /// </summary>
        public const int NoValue = 2147483647;

        /// <summary>
        ///  Size of Order Qty in bytes
        /// </summary>
        public const int Size = 4;

        /// <summary>
        ///  Read Order Qty
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int Decode()
        {
            fixed (byte* pointer = Bytes) { return (int)pointer; }
        }

        /// <summary>
        ///  Write Order Qty
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(int value)
        {
            fixed (byte* pointer = Bytes) { *(int *)pointer = value; }
        }

        /// <summary>
        ///  Order Qty as string
        /// </summary>
        public override string ToString()
            => $"{Decode()}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal unsafe fixed byte Bytes[Size];
    }
}