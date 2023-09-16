using System.Runtime.CompilerServices;;

namespace Eurex.Eobi
{
    /// <summary>
    ///  Leg Ratio Qty:
    /// </summary>

    public unsafe struct LegRatioQty
    {
        /// <summary>
        ///  Length of Leg Ratio Qty in bytes
        /// </summary>
        public const int Length = 4;

        /// <summary>
        ///  Read Leg Ratio Qty
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int Decode()
            => Value;

        /// <summary>
        ///  Encode Leg Ratio Qty
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(int value)
            => Value = value;

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal int Value;
    }
}