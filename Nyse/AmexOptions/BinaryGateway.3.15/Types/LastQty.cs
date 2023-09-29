using System.Runtime.CompilerServices;

namespace Nyse.AmexOptions.BinaryGateway
{
    /// <summary>
    ///  Last Qty: Quantity of current partial fill or fill message 1 - 999,999
    /// </summary>

    public struct LastQty
    {
        /// <summary>
        ///  Size of Last Qty in bytes
        /// </summary>
        public const int Size = 4;

        /// <summary>
        ///  Last Qty value
        /// </summary>
        public readonly uint Value
            => Decode();

        /// <summary>
        ///  Read Last Qty
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly uint Decode()
            => Underlying;

        /// <summary>
        ///  Write Last Qty
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(uint value)
            => Underlying = value;

        /// <summary>
        ///  Last Qty as string
        /// </summary>
        public readonly override string ToString()
            => $"{Value}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal uint Underlying;
    }
}