using System.Runtime.CompilerServices;

namespace Nyse.AmexOptions.BinaryGateway
{
    /// <summary>
    ///  Trading Mpv: Numeric value of the Trading Minimum Price Variation for the
    /// </summary>

    public struct TradingMpv
    {
        /// <summary>
        ///  Decimal place factor for Trading Mpv
        /// </summary>
        public const ulong Factor = 100000000;

        /// <summary>
        ///  Size of Trading Mpv in bytes
        /// </summary>
        public const int Size = 8;

        /// <summary>
        ///  Trading Mpv value
        /// </summary>
        public readonly ulong Value
            => Decode();

        /// <summary>
        ///  Read Trading Mpv
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly ulong Decode()
            => Underlying / Factor;

        /// <summary>
        ///  Write Trading Mpv
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(ulong value)
            => Underlying = value * Factor;

        /// <summary>
        ///  Trading Mpv as string
        /// </summary>
        public readonly override string ToString()
            => $"{Value}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal ulong Underlying;
    }
}