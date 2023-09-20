using System.Runtime.CompilerServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  Trading Status
    /// </summary>

    public struct TradingStatus
    {
        /// <summary>
        ///  Open
        /// </summary>
        public const char Open = 'O';

        /// <summary>
        ///  Close
        /// </summary>
        public const char Close = 'C';

        /// <summary>
        ///  Expired
        /// </summary>
        public const char Expired = 'E';

        /// <summary>
        ///  Pre Open
        /// </summary>
        public const char PreOpen = '1';

        /// <summary>
        ///  Pre Close
        /// </summary>
        public const char PreClose = '2';

        /// <summary>
        ///  Length of Trading Status in bytes
        /// </summary>
        public const int Length = 1;
    }
}