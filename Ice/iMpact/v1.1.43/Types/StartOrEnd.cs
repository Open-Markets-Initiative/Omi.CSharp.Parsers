using System.Runtime.CompilerServices;;

namespace Ice.iMpact
{
    /// <summary>
    ///  Start Or End
    /// </summary>

    public struct StartOrEnd
    {
        /// <summary>
        ///  Start Of A Message Bundle
        /// </summary>
        public const char Start = 'S';

        /// <summary>
        ///  End Of A Message Bundle
        /// </summary>
        public const char End = 'E';

        /// <summary>
        ///  Length of Start Or End in bytes
        /// </summary>
        public const int Length = 1;
    }
}