using System.Runtime.CompilerServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  Hedge Price Denominator: Hedge Price Denominator
    /// </summary>

    public struct HedgePriceDenominator
    {
        /// <summary>
        ///  Size of Hedge Price Denominator in bytes
        /// </summary>
        public const int Size = 1;

        /// <summary>
        ///  Hedge Price Denominator value
        /// </summary>
        public readonly char Value
            => (char)Byte;

        /// <summary>
        ///  Write Hedge Price Denominator
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(char value)
            => Byte = (byte)value;

        /// <summary>
        ///  Hedge Price Denominator as string
        /// </summary>
        public readonly override string ToString()
            => $"{Value}";

        /// <summary>
        ///  Underlying byte
        /// </summary>
        internal byte Byte;
    }
}