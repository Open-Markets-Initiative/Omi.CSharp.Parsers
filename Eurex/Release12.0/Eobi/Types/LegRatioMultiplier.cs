using System.Runtime.CompilerServices;

namespace Eurex.Eobi
{
    /// <summary>
    ///  Leg Ratio Multiplier
    /// </summary>

    public struct LegRatioMultiplier
    {
        /// <summary>
        ///  Maximum value for Leg Ratio Multiplier
        /// </summary>
        public const uint Maximum = 2147483647;

        /// <summary>
        ///  Minimum value for Leg Ratio Multiplier
        /// </summary>
        public const uint Minimum = 1;

        /// <summary>
        ///  Size of Leg Ratio Multiplier in bytes
        /// </summary>
        public const int Size = 4;

        /// <summary>
        ///  Leg Ratio Multiplier value
        /// </summary>
        public readonly uint Value
            => Decode();

        /// <summary>
        ///  Read Leg Ratio Multiplier
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly uint Decode()
            => Underlying;

        /// <summary>
        ///  Write Leg Ratio Multiplier
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(uint value)
            => Underlying = value;

        /// <summary>
        ///  Leg Ratio Multiplier as string
        /// </summary>
        public readonly override string ToString()
            => $"{Value}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal uint Underlying;
    }
}