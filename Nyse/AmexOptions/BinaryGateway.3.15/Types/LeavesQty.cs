using System.Runtime.CompilerServices;

namespace Nyse.AmexOptions.BinaryGateway
{
    /// <summary>
    ///  Leaves Qty: 0 - 999,999
    /// </summary>

    public struct LeavesQty
    {
        /// <summary>
        ///  Size of Leaves Qty in bytes
        /// </summary>
        public const int Size = 4;

        /// <summary>
        ///  Leaves Qty value
        /// </summary>
        public readonly uint Value
            => Decode();

        /// <summary>
        ///  Read Leaves Qty
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly uint Decode()
            => Underlying;

        /// <summary>
        ///  Write Leaves Qty
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(uint value)
            => Underlying = value;

        /// <summary>
        ///  Leaves Qty as string
        /// </summary>
        public readonly override string ToString()
            => $"{Value}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal uint Underlying;
    }
}