namespace Ice.iMpact
{
    using System.Runtime.CompilerServices;

    /// <summary>
    ///  Is Transaction End
    /// </summary>

    public struct IsTransactionEnd
    {
        /// <summary>
        ///  Transaction End
        /// </summary>
        public const char Yes = 'Y';

        /// <summary>
        ///  Not Transaction End
        /// </summary>
        public const char No = 'N';

        /// <summary>
        ///  Length of Is Transaction End in bytes
        /// </summary>
        public const int Length = 1;
    }
}