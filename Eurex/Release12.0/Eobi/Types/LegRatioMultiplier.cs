using System.Runtime.CompilerServices;;

namespace Eurex.Eobi
{
    /// <summary>
    ///  Leg Ratio Multiplier:
    /// </summary>

    public unsafe struct LegRatioMultiplier
    {
        /// <summary>
        ///  Length of Leg Ratio Multiplier in bytes
        /// </summary>
        public const int Length = 4;

        /// <summary>
        ///  Read Leg Ratio Multiplier
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Decode()
            => Value;

        /// <summary>
        ///  Encode Leg Ratio Multiplier
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(uint value)
            => Value = value;

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal uint Value;
    }
}