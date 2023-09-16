using System.Runtime.CompilerServices;;

namespace Nyse.AmexOptions.BinaryGateway
{
    /// <summary>
    ///  Order Qty: 1 - 999,999
    /// </summary>

    public unsafe struct OrderQty
    {
        /// <summary>
        ///  Length of Order Qty in bytes
        /// </summary>
        public const int Length = 4;

        /// <summary>
        ///  Read Order Qty
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Decode()
            => Value;

        /// <summary>
        ///  Encode Order Qty
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(uint value)
            => Value = value;

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal uint Value;
    }
}