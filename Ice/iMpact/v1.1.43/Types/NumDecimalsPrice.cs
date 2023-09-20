using System.Runtime.CompilerServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  Num Decimals Price: Number of decimals to use for Prices
    /// </summary>

    public struct NumDecimalsPrice
    {
        /// <summary>
        ///  Size of Num Decimals Price in bytes
        /// </summary>
        public const int Size = 1;

        /// <summary>
        ///  Read Num Decimals Price
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public sbyte Decode()
            => (sbyte)Byte;

        /// <summary>
        ///  Write Num Decimals Price
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(sbyte value)
            => Byte = (byte)value;

        /// <summary>
        ///  Num Decimals Price as string
        /// </summary>
        public override string ToString()
            => $"{{Decode()}}";

        /// <summary>
        ///  Underlying byte
        /// </summary>
        internal byte Byte;
    }
}