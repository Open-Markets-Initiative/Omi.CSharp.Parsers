using System.Runtime.CompilerServices;

namespace Eurex.Eobi
{
    /// <summary>
    ///  Tot No Orders
    /// </summary>

    public struct TotNoOrders
    {
        /// <summary>
        ///  Size of Tot No Orders in bytes
        /// </summary>
        public const int Size = 2;

        /// <summary>
        ///  Tot No Orders value
        /// </summary>
        public readonly ushort Value
            => Decode();

        /// <summary>
        ///  Read Tot No Orders
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly ushort Decode()
            => Underlying;

        /// <summary>
        ///  Write Tot No Orders
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(ushort value)
            => Underlying = value;

        /// <summary>
        ///  Tot No Orders as string
        /// </summary>
        public readonly override string ToString()
            => $"{Value}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal ushort Underlying;
    }
}