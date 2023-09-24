using System.Runtime.CompilerServices;

namespace Nasdaq.MarketDepth
{
    /// <summary>
    ///  Expiration Date: Day of the Month of expiration (1- 31)
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
        public readonly override string ToString()
            => $"{Decode()}";

        /// <summary>
        ///  Underlying byte
        /// </summary>
        internal byte Byte;
    }
}