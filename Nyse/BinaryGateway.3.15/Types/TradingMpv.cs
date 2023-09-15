namespace Nyse.AmexOptions.Pillar
{
    using System.Runtime.CompilerServices;

    /// <summary>
    ///  Trading Mpv: 8 Byte Fixed Width Integer with 8 Decimal Place Precision
    /// </summary>

    public struct TradingMpv
    {
        /// <summary>
        ///  Length of Trading Mpv in bytes
        /// </summary>
        public const int Length = 8;

        /// <summary>
        ///  Decimal place factor for Trading Mpv
        /// </summary>
        public const int Factor = 100000000;
    }
}