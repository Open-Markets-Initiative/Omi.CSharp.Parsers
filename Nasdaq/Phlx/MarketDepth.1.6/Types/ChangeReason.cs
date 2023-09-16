using System.Runtime.CompilerServices;;

namespace Nasdaq.MarketDepth
{
    /// <summary>
    ///  Change Reason
    /// </summary>

    public struct ChangeReason
    {
        /// <summary>
        ///  User
        /// </summary>
        public const char User = 'U';

        /// <summary>
        ///  Reprice
        /// </summary>
        public const char Reprice = 'R';

        /// <summary>
        ///  Suspend
        /// </summary>
        public const char Suspend = 'S';

        /// <summary>
        ///  Exhausted
        /// </summary>
        public const char Exhausted = 'E';

        /// <summary>
        ///  Length of Change Reason in bytes
        /// </summary>
        public const int Length = 1;
    }
}