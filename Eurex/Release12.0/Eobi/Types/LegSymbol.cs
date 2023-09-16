using System.Runtime.CompilerServices;;

namespace Eurex.Eobi
{
    /// <summary>
    ///  Leg Symbol:
    /// </summary>

    public unsafe struct LegSymbol
    {
        /// <summary>
        ///  Length of Leg Symbol in bytes
        /// </summary>
        public const int Length = 4;

        /// <summary>
        ///  Read Leg Symbol
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int Decode()
            => Value;

        /// <summary>
        ///  Encode Leg Symbol
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