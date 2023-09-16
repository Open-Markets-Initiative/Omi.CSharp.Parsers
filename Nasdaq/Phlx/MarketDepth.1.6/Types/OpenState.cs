using System.Runtime.CompilerServices;;

namespace Nasdaq.MarketDepth
{
    /// <summary>
    ///  Open State
    /// </summary>

    public struct OpenState
    {
        /// <summary>
        ///  Open For Auto Execution
        /// </summary>
        public const char Open = 'Y';

        /// <summary>
        ///  Closed For Auto Execution
        /// </summary>
        public const char Closed = 'N';

        /// <summary>
        ///  Length of Open State in bytes
        /// </summary>
        public const int Length = 1;
    }
}