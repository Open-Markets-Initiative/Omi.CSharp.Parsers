using System.Runtime.CompilerServices;;

namespace Eurex.Eobi
{
    /// <summary>
    ///  Tot No Orders:
    /// </summary>

    public unsafe struct TotNoOrders
    {
        /// <summary>
        ///  Length of Tot No Orders in bytes
        /// </summary>
        public const int Length = 2;

        /// <summary>
        ///  Read Tot No Orders
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ushort Decode()
            => Value;

        /// <summary>
        ///  Encode Tot No Orders
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(ushort value)
            => Value = value;

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal ushort Value;
    }
}