using System.Runtime.CompilerServices;

namespace Cme.Mdp3
{
    /// <summary>
    ///  Md Entry Type Daily Statistics: Zeroed Character Enum
    /// </summary>

    public struct MdEntryTypeDailyStatistics
    {
        /// <summary>
        ///  Settlement Price
        /// </summary>
        public const char SettlementPrice = '6';

        /// <summary>
        ///  Cleared Volume
        /// </summary>
        public const char ClearedVolume = 'B';

        /// <summary>
        ///  Open Interest
        /// </summary>
        public const char OpenInterest = 'C';

        /// <summary>
        ///  Fixing Price
        /// </summary>
        public const char FixingPrice = 'W';

        /// <summary>
        ///  Fix Tag for Md Entry Type Daily Statistics
        /// </summary>
        public const ushort FixTag = 269;

        /// <summary>
        ///  Length of Md Entry Type Daily Statistics in bytes
        /// </summary>
        public const int Length = 1;
    }
}