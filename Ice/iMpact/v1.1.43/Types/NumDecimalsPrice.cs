using System.Runtime.CompilerServices;;

namespace Ice.iMpact
{
    /// <summary>
    ///  Num Decimals Price: One Byte Fixed Width Integer
    /// </summary>

    public struct NumDecimalsPrice
    {
        /// <summary>
        ///  Length of Num Decimals Price in bytes
        /// </summary>
        public const int Size = 1;

        /// <summary>
        ///  Read Num Decimals Price
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public sbyte Decode()
            => Byte;

        /// <summary>
        ///  Write Num Decimals Price
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(sbyte value)
            => Byte = value;

        /// <summary>
        ///  Num Decimals Price as string
        /// </summary>
        public override string ToString()
            => $"{Decode()}";

        /// <summary>
        ///  Underlying byte
        /// </summary>
        internal byte Byte;
    }
}