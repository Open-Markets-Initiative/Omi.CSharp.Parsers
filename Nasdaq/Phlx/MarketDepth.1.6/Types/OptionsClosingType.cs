using System.Runtime.CompilerServices;;

namespace Nasdaq.MarketDepth
{
    /// <summary>
    ///  Options Closing Type
    /// </summary>

    public struct OptionsClosingType
    {
        /// <summary>
        ///  Normal Hours
        /// </summary>
        public const char Normal = 'N';

        /// <summary>
        ///  Late Hours
        /// </summary>
        public const char Late = 'L';

        /// <summary>
        ///  Wco Early Closing At 1200 Noon
        /// </summary>
        public const char WcoEarlyClosing = 'W';

        /// <summary>
        ///  Length of Options Closing Type in bytes
        /// </summary>
        public const int Length = 1;
    }
}