using System.Runtime.CompilerServices;

namespace Cme.Streamlined
{
    /// <summary>
    ///  Market Depth: Indicated the level on the book traded.
    /// </summary>

    public struct MarketDepth
    {
        /// <summary>
        ///  Fix Tag for Market Depth
        /// </summary>
        public const ushort FixTag = 264;

        /// <summary>
        ///  Sentinel null value for Market Depth
        /// </summary>
        public const byte NoValue = 255;

        /// <summary>
        ///  Length of Market Depth in bytes
        /// </summary>
        public const int Size = 1;

        /// <summary>
        ///  Read Market Depth
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public byte Decode()
            => Byte;

        /// <summary>
        ///  Write Market Depth
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(byte value)
            => Byte = value;

        /// <summary>
        ///  Market Depth as string
        /// </summary>
        public readonly override string ToString()
            => $"{Decode()}";

        /// <summary>
        ///  Underlying byte
        /// </summary>
        internal byte Byte;
    }
}