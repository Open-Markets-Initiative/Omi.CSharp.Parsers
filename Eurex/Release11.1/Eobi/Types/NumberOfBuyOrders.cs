using System.Runtime.CompilerServices;

namespace Eurex.Eobi
{
    /// <summary>
    ///  Number Of Buy Orders
    /// </summary>

    public struct NumberOfBuyOrders
    {
        /// <summary>
        ///  Maximum value for Number Of Buy Orders
        /// </summary>
        public const ushort Maximum = 65534;

        /// <summary>
        ///  Minimum value for Number Of Buy Orders
        /// </summary>
        public const ushort Minimum = 0;

        /// <summary>
        ///  Size of Number Of Buy Orders in bytes
        /// </summary>
        public const int Size = 2;

        /// <summary>
        ///  Number Of Buy Orders value
        /// </summary>
        public readonly ushort Value
            => Decode();

        /// <summary>
        ///  Read Number Of Buy Orders
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly ushort Decode()
            => Underlying;

        /// <summary>
        ///  Write Number Of Buy Orders
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(ushort value)
            => Underlying = value;

        /// <summary>
        ///  Number Of Buy Orders as string
        /// </summary>
        public readonly override string ToString()
            => $"{Value}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal ushort Underlying;
    }
}