using System.Runtime.CompilerServices;

namespace Nyse.AmexOptions.BinaryGateway
{
    /// <summary>
    ///  Leg Ratio Qty: The ratio of quantity for this individual leg.
    /// </summary>

    public struct LegRatioQty
    {
        /// <summary>
        ///  Size of Leg Ratio Qty in bytes
        /// </summary>
        public const int Size = 2;

        /// <summary>
        ///  Leg Ratio Qty value
        /// </summary>
        public readonly ushort Value
            => Decode();

        /// <summary>
        ///  Read Leg Ratio Qty
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly ushort Decode()
            => Underlying;

        /// <summary>
        ///  Write Leg Ratio Qty
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(ushort value)
            => Underlying = value;

        /// <summary>
        ///  Leg Ratio Qty as string
        /// </summary>
        public readonly override string ToString()
            => $"{Value}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal ushort Underlying;
    }
}