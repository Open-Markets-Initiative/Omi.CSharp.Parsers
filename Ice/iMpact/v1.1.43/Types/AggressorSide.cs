using System.Runtime.CompilerServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  Aggressor Side: Zeroed Character Enum
    /// </summary>

    public struct AggressorSide
    {
        /// <summary>
        ///  None
        /// </summary>
        public const char None = '';

        /// <summary>
        ///  Buy
        /// </summary>
        public const char Buy = '1';

        /// <summary>
        ///  Sell
        /// </summary>
        public const char Sell = '2';

        /// <summary>
        ///  Length of Aggressor Side in bytes
        /// </summary>
        public const int Length = 1;
    }
}