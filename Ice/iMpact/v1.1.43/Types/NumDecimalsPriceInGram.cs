using System.Runtime.CompilerServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  Num Decimals Price In Gram: Number of decimals to use for PriceInGram
    /// </summary>

    public struct NumDecimalsPriceInGram
    {
        /// <summary>
        ///  Size of Num Decimals Price In Gram in bytes
        /// </summary>
        public const int Size = 1;

        /// <summary>
        ///  Read Num Decimals Price In Gram
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public sbyte Decode()
            => (sbyte)Byte;

        /// <summary>
        ///  Write Num Decimals Price In Gram
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(sbyte value)
            => Byte = (byte)value;

        /// <summary>
        ///  Num Decimals Price In Gram as string
        /// </summary>
        public readonly override string ToString()
            => $"{Decode()}";

        /// <summary>
        ///  Underlying byte
        /// </summary>
        internal byte Byte;
    }
}