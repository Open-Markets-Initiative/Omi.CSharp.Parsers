using System.Runtime.CompilerServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  Endex Status: Zeroed Character Enum
    /// </summary>

    public struct EndexStatus
    {
        /// <summary>
        ///  Current
        /// </summary>
        public const char Current = 'C';

        /// <summary>
        ///  Default
        /// </summary>
        public const char Default = 'D';

        /// <summary>
        ///  Final
        /// </summary>
        public const char Final = 'F';

        /// <summary>
        ///  Non Endex Spot Market
        /// </summary>
        public const char NonEndexSpotMarket = '';

        /// <summary>
        ///  Length of Endex Status in bytes
        /// </summary>
        public const int Length = 1;
    }
}