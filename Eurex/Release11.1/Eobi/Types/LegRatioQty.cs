using System.Runtime.CompilerServices;

namespace Eurex.Eobi
{
    /// <summary>
    ///  Leg Ratio Qty
    /// </summary>

    public struct LegRatioQty
    {
        /// <summary>
        ///  Maximum value for Leg Ratio Qty
        /// </summary>
        public const int Maximum = 2147483647;

        /// <summary>
        ///  Minimum value for Leg Ratio Qty
        /// </summary>
        public const int Minimum = -2147483647;

        /// <summary>
        ///  Size of Leg Ratio Qty in bytes
        /// </summary>
        public const int Size = 4;

        /// <summary>
        ///  Leg Ratio Qty value
        /// </summary>
        public readonly int Value
            => Decode();

        /// <summary>
        ///  Read Leg Ratio Qty
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly int Decode()
            => Underlying;

        /// <summary>
        ///  Write Leg Ratio Qty
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(int value)
            => Underlying = value;

        /// <summary>
        ///  Leg Ratio Qty as string
        /// </summary>
        public readonly override string ToString()
            => $"{Value}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal int Underlying;
    }
}