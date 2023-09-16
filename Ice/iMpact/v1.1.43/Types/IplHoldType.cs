using System.Runtime.CompilerServices;;

namespace Ice.iMpact
{
    /// <summary>
    ///  Ipl Hold Type
    /// </summary>

    public struct IplHoldType
    {
        /// <summary>
        ///  Interval Price Limit Hold Start
        /// </summary>
        public const char IplHoldStart = 'S';

        /// <summary>
        ///  Interval Price Limit Hold End
        /// </summary>
        public const char IplHoldEnd = 'E';

        /// <summary>
        ///  Length of Ipl Hold Type in bytes
        /// </summary>
        public const int Length = 1;
    }
}