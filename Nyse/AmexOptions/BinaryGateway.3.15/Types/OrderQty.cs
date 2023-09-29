using System.Runtime.CompilerServices;

namespace Nyse.AmexOptions.BinaryGateway
{
    /// <summary>
    ///  Order Qty: 1 - 999,999
    /// </summary>

    public struct OrderQty
    {
        /// <summary>
        ///  Size of Order Qty in bytes
        /// </summary>
        public const int Size = 4;

        /// <summary>
        ///  Order Qty value
        /// </summary>
        public readonly uint Value
            => Decode();

        /// <summary>
        ///  Read Order Qty
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly uint Decode()
            => Underlying;

        /// <summary>
        ///  Write Order Qty
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(uint value)
            => Underlying = value;

        /// <summary>
        ///  Order Qty as string
        /// </summary>
        public readonly override string ToString()
            => $"{Value}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal uint Underlying;
    }
}