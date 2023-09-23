using System.Runtime.CompilerServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  Options Expiration Type: Zeroed Character Enum
    /// </summary>

    public struct OptionsExpirationType
    {
        /// <summary>
        ///  Monthly
        /// </summary>
        public const char Monthly = 'M';

        /// <summary>
        ///  Daily
        /// </summary>
        public const char Daily = 'D';

        /// <summary>
        ///  Length of Options Expiration Type in bytes
        /// </summary>
        public const int Length = 1;
    }
}