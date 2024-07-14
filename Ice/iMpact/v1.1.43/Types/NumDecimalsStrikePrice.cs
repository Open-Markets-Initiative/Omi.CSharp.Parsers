using System.Runtime.CompilerServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  Num Decimals Strike Price: Denominator for the strike price field.
    /// </summary>

    public struct NumDecimalsStrikePrice
    {
        /// <summary>
        ///  Size of Num Decimals Strike Price in bytes
        /// </summary>
        public const int Size = 1;

        /// <summary>
        ///  Num Decimals Strike Price value
        /// </summary>
        public readonly char Value
            => (char)Byte;

        /// <summary>
        ///  Write Num Decimals Strike Price
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(char value)
            => Byte = (byte)value;

        /// <summary>
        ///  Num Decimals Strike Price as string
        /// </summary>
        public readonly override string ToString()
            => $"{Value}";

        /// <summary>
        ///  Underlying byte
        /// </summary>
        internal byte Byte;
    }
}