using System.Runtime.CompilerServices;;

namespace Nyse.AmexOptions.BinaryGateway
{
    /// <summary>
    ///  Leaves Qty: 0 - 999,999
    /// </summary>

    public unsafe struct LeavesQty
    {
        /// <summary>
        ///  Length of Leaves Qty in bytes
        /// </summary>
        public const int Length = 4;

        /// <summary>
        ///  Read Leaves Qty
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Decode()
            => Value;

        /// <summary>
        ///  Encode Leaves Qty
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