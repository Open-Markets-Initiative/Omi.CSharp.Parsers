using System.Runtime.CompilerServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  Num Decimals Options Price: Only used for OffExchangeIncrementOptionPrice.
    /// </summary>

    public struct NumDecimalsOptionsPrice
    {
        /// <summary>
        ///  Size of Num Decimals Options Price in bytes
        /// </summary>
        public const int Size = 1;

        /// <summary>
        ///  Num Decimals Options Price value
        /// </summary>
        public readonly char Value
            => (char)Byte;

        /// <summary>
        ///  Write Num Decimals Options Price
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(char value)
            => Byte = (byte)value;

        /// <summary>
        ///  Num Decimals Options Price as string
        /// </summary>
        public readonly override string ToString()
            => $"{Value}";

        /// <summary>
        ///  Underlying byte
        /// </summary>
        internal byte Byte;
    }
}