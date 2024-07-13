using System.Runtime.CompilerServices;

namespace Eurex.Eobi
{
    /// <summary>
    ///  Trading Hhi Indicator
    /// </summary>

    public struct TradingHhiIndicator
    {
        /// <summary>
        ///  Maximum value for Trading Hhi Indicator
        /// </summary>
        public const byte Maximum = 100;

        /// <summary>
        ///  Minimum value for Trading Hhi Indicator
        /// </summary>
        public const byte Minimum = 0;

        /// <summary>
        ///  Length of Trading Hhi Indicator in bytes
        /// </summary>
        public const int Size = 1;

        /// <summary>
        ///  Read Trading Hhi Indicator
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public byte Decode()
            => Byte;

        /// <summary>
        ///  Write Trading Hhi Indicator
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(byte value)
            => Byte = value;

        /// <summary>
        ///  Trading Hhi Indicator as string
        /// </summary>
        public readonly override string ToString()
            => $"{Decode()}";

        /// <summary>
        ///  Underlying byte
        /// </summary>
        internal byte Byte;
    }
}