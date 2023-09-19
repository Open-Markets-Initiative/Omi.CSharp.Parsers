using System.Runtime.CompilerServices;;

namespace Nasdaq.MarketDepth
{
    /// <summary>
    ///  Expiration Year: One Byte Fixed Width Integer
    /// </summary>

    public struct ExpirationYear
    {
        /// <summary>
        ///  Length of Expiration Year in bytes
        /// </summary>
        public const int Size = 1;

        /// <summary>
        ///  Read Expiration Year
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public byte Decode()
            => Byte;

        /// <summary>
        ///  Write Expiration Year
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(byte value)
            => Byte = value;

        /// <summary>
        ///  Expiration Year as string
        /// </summary>
        public override string ToString()
            => $"{Decode()}";

        /// <summary>
        ///  Underlying byte
        /// </summary>
        internal byte Byte;
    }
}