using System.Runtime.CompilerServices;;

namespace Ice.iMpact
{
    /// <summary>
    ///  Is Tradable
    /// </summary>

    public struct IsTradable
    {
        /// <summary>
        ///  Indicates The Contract Is Tradable
        /// </summary>
        public const char Yes = 'Y';

        /// <summary>
        ///  Indicates The Contract Is Not Tradable
        /// </summary>
        public const char No = 'N';

        /// <summary>
        ///  Length of Is Tradable in bytes
        /// </summary>
        public const int Length = 1;
    }
}