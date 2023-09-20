using System.Runtime.CompilerServices;

namespace Nasdaq.MarketDepth
{
    /// <summary>
    ///  Printable
    /// </summary>

    public struct Printable
    {
        /// <summary>
        ///  Nonprintable
        /// </summary>
        public const char Nonprintable = 'N';

        /// <summary>
        ///  Printable
        /// </summary>
        public const char Printable = 'Y';

        /// <summary>
        ///  Length of Printable in bytes
        /// </summary>
        public const int Length = 1;
    }
}