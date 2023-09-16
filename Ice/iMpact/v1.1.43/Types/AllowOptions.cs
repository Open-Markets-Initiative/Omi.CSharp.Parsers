using System.Runtime.CompilerServices;;

namespace Ice.iMpact
{
    /// <summary>
    ///  Allow Options
    /// </summary>

    public struct AllowOptions
    {
        /// <summary>
        ///  Supports Option Markets
        /// </summary>
        public const char Yes = 'Y';

        /// <summary>
        ///  Does Not Support Option Markets
        /// </summary>
        public const char No = 'N';

        /// <summary>
        ///  Length of Allow Options in bytes
        /// </summary>
        public const int Length = 1;
    }
}