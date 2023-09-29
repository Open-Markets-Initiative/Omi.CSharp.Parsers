using System.Runtime.CompilerServices;

namespace Nyse.AmexOptions.BinaryGateway
{
    /// <summary>
    ///  Cum Qty: 1 - 999,999
    /// </summary>

    public struct CumQty
    {
        /// <summary>
        ///  Size of Cum Qty in bytes
        /// </summary>
        public const int Size = 4;

        /// <summary>
        ///  Cum Qty value
        /// </summary>
        public readonly uint Value
            => Decode();

        /// <summary>
        ///  Read Cum Qty
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly uint Decode()
            => Underlying;

        /// <summary>
        ///  Write Cum Qty
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(uint value)
            => Underlying = value;

        /// <summary>
        ///  Cum Qty as string
        /// </summary>
        public readonly override string ToString()
            => $"{Value}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal uint Underlying;
    }
}