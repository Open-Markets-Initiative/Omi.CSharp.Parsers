using System.Runtime.CompilerServices;

namespace Nyse.AmexOptions.BinaryGateway
{
    /// <summary>
    ///  Trading Mpv: Numeric value of the Trading Minimum Price Variation for the
    /// </summary>

    public unsafe struct TradingMpv
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
        ///  Read Trading Mpv
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong Decode()
        {
            fixed (byte* pointer = Bytes) { return ((ulong)pointer)/Factor; }
        }

        /// <summary>
        ///  Write Trading Mpv
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(ulong value)
        {
            fixed (byte* pointer = Bytes) { *(ulong *)pointer = value * Factor; }
        }

        /// <summary>
        ///  Trading Mpv as string
        /// </summary>
        public override string ToString()
            => $"{Decode()}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal unsafe fixed byte Bytes[Size];
    }
}