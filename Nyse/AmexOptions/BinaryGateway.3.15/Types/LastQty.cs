using System.Runtime.CompilerServices;;

namespace Nyse.AmexOptions.BinaryGateway
{
    /// <summary>
    ///  Last Qty: Quantity of current partial fill or fill message 1 - 999,999
    /// </summary>

    public unsafe struct LastQty
    {
        /// <summary>
        ///  Length of Last Qty in bytes
        /// </summary>
        public const int Length = 4;

        /// <summary>
        ///  Read Last Qty
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Decode()
            => Value;

        /// <summary>
        ///  Encode Last Qty
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