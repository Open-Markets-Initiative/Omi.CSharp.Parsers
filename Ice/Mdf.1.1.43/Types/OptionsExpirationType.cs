namespace Ice.iMpact
{
    using System.Runtime.CompilerServices;

    /// <summary>
    ///  Options Expiration Type
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