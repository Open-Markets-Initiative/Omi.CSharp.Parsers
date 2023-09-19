using System.Runtime.CompilerServices;;

namespace Nasdaq.MarketDepth
{
    /// <summary>
    ///  Source: One Byte Fixed Width Integer
    /// </summary>

    public struct Source
    {
        /// <summary>
        ///  Length of Source in bytes
        /// </summary>
        public const int Size = 1;

        /// <summary>
        ///  Read Source
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public byte Decode()
            => Byte;

        /// <summary>
        ///  Write Source
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(byte value)
            => Byte = value;

        /// <summary>
        ///  Source as string
        /// </summary>
        public override string ToString()
            => $"{Decode()}";

        /// <summary>
        ///  Underlying byte
        /// </summary>
        internal byte Byte;
    }
}