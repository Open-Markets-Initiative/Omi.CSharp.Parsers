using System.Runtime.CompilerServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  Fixing Status
    /// </summary>

    public struct FixingStatus
    {
        /// <summary>
        ///  Closed
        /// </summary>
        public const char Closed = 'C';

        /// <summary>
        ///  Preopen
        /// </summary>
        public const char Preopen = 'P';

        /// <summary>
        ///  Lockdown
        /// </summary>
        public const char Lockdown = 'L';

        /// <summary>
        ///  Length of Fixing Status in bytes
        /// </summary>
        public const int Length = 1;
    }
}