using System.Runtime.CompilerServices;;

namespace Ice.iMpact
{
    /// <summary>
    ///  Num Decimals Price In Gram: One Byte Fixed Width Integer
    /// </summary>

    public struct NumDecimalsPriceInGram
    {
        /// <summary>
        ///  Length of Num Decimals Price In Gram in bytes
        /// </summary>
        public const int Size = 1;

        /// <summary>
        ///  Read Num Decimals Price In Gram
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public sbyte Decode()
            => Byte;

        /// <summary>
        ///  Write Num Decimals Price In Gram
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(sbyte value)
            => Byte = value;

        /// <summary>
        ///  Num Decimals Price In Gram as string
        /// </summary>
        public override string ToString()
            => $"{Decode()}";

        /// <summary>
        ///  Underlying byte
        /// </summary>
        internal byte Byte;
    }
}