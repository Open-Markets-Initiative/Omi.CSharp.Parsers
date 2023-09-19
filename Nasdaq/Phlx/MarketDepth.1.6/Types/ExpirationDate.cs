using System.Runtime.CompilerServices;;

namespace Nasdaq.MarketDepth
{
    /// <summary>
    ///  Expiration Date: One Byte Fixed Width Integer
    /// </summary>

    public struct ExpirationDate
    {
        /// <summary>
        ///  Length of Expiration Date in bytes
        /// </summary>
        public const int Size = 1;

        /// <summary>
        ///  Read Expiration Date
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public byte Decode()
            => Byte;

        /// <summary>
        ///  Write Expiration Date
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(byte value)
            => Byte = value;

        /// <summary>
        ///  Expiration Date as string
        /// </summary>
        public override string ToString()
            => $"{Decode()}";

        /// <summary>
        ///  Underlying byte
        /// </summary>
        internal byte Byte;
    }
}