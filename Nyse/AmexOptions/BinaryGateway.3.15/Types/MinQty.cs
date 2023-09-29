using System.Runtime.CompilerServices;

namespace Nyse.AmexOptions.BinaryGateway
{
    /// <summary>
    ///  Min Qty: 0 = no MinQty
    /// </summary>

    public struct MinQty
    {
        /// <summary>
        ///  Size of Min Qty in bytes
        /// </summary>
        public const int Size = 4;

        /// <summary>
        ///  Min Qty value
        /// </summary>
        public readonly uint Value
            => Decode();

        /// <summary>
        ///  Read Min Qty
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly uint Decode()
            => Underlying;

        /// <summary>
        ///  Write Min Qty
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(uint value)
            => Underlying = value;

        /// <summary>
        ///  Min Qty as string
        /// </summary>
        public readonly override string ToString()
            => $"{Value}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal uint Underlying;
    }
}