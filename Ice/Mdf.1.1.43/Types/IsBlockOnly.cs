namespace Ice.iMpact
{
    using System.Runtime.CompilerServices;

    /// <summary>
    ///  Is Block Only
    /// </summary>

    public struct IsBlockOnly
    {
        /// <summary>
        ///  Only Tradable Via Ice Block Trade
        /// </summary>
        public const char Yes = 'Y';

        /// <summary>
        ///  Not Only Tradable Via Ice Block Trade
        /// </summary>
        public const char No = 'N';

        /// <summary>
        ///  Length of Is Block Only in bytes
        /// </summary>
        public const int Length = 1;
    }
}