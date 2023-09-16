using System.Runtime.CompilerServices;;

namespace Nyse.AmexOptions.BinaryGateway
{
    /// <summary>
    ///  Max Order Quantity: Maximum allowable OrderQty for Order and Cancel/Replace Requests entered on the gateway session.
    /// </summary>

    public unsafe struct MaxOrderQuantity
    {
        /// <summary>
        ///  Length of Max Order Quantity in bytes
        /// </summary>
        public const int Length = 4;

        /// <summary>
        ///  Read Max Order Quantity
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Decode()
            => Value;

        /// <summary>
        ///  Encode Max Order Quantity
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