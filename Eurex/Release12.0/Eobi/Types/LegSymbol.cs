using System.Runtime.CompilerServices;

namespace Eurex.Eobi
{
    /// <summary>
    ///  Leg Symbol
    /// </summary>

    public struct LegSymbol
    {
        /// <summary>
        ///  Maximum value for Leg Symbol
        /// </summary>
        public const int Maximum = 2147483647;

        /// <summary>
        ///  Minimum value for Leg Symbol
        /// </summary>
        public const int Minimum = -2147483647;

        /// <summary>
        ///  Size of Leg Symbol in bytes
        /// </summary>
        public const int Size = 4;

        /// <summary>
        ///  Leg Symbol value
        /// </summary>
        public readonly int Value
            => Decode();

        /// <summary>
        ///  Read Leg Symbol
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly int Decode()
            => Underlying;

        /// <summary>
        ///  Write Leg Symbol
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(int value)
            => Underlying = value;

        /// <summary>
        ///  Leg Symbol as string
        /// </summary>
        public readonly override string ToString()
            => $"{Value}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal int Underlying;
    }
}