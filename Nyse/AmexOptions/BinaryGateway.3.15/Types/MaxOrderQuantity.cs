using System.Runtime.CompilerServices;

namespace Nyse.AmexOptions.BinaryGateway
{
    /// <summary>
    ///  Max Order Quantity: Maximum allowable OrderQty for Order and Cancel/Replace Requests entered on the gateway session.
    /// </summary>

    public struct MaxOrderQuantity
    {
        /// <summary>
        ///  Size of Max Order Quantity in bytes
        /// </summary>
        public const int Size = 4;

        /// <summary>
        ///  Max Order Quantity value
        /// </summary>
        public readonly uint Value
            => Decode();

        /// <summary>
        ///  Read Max Order Quantity
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly uint Decode()
            => Underlying;

        /// <summary>
        ///  Write Max Order Quantity
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(uint value)
            => Underlying = value;

        /// <summary>
        ///  Max Order Quantity as string
        /// </summary>
        public readonly override string ToString()
            => $"{Value}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal uint Underlying;
    }
}