using System.Runtime.CompilerServices;

namespace Nasdaq.MarketDepth
{
    /// <summary>
    ///  Expiration Month: Expiration Month (1-12)
    /// </summary>

    public struct ExpirationMonth
    {
        /// <summary>
        ///  Length of Expiration Month in bytes
        /// </summary>
        public const int Size = 1;

        /// <summary>
        ///  Read Expiration Month
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public byte Decode()
            => Byte;

        /// <summary>
        ///  Write Expiration Month
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(byte value)
            => Byte = value;

        /// <summary>
        ///  Expiration Month as string
        /// </summary>
        public readonly override string ToString()
            => $"{Decode()}";

        /// <summary>
        ///  Underlying byte
        /// </summary>
        internal byte Byte;
    }
}