namespace Ice.iMpact
{
    using System.Runtime.CompilerServices;

    /// <summary>
    ///  Investigation Status
    /// </summary>

    public struct InvestigationStatus
    {
        /// <summary>
        ///  Under Investigation
        /// </summary>
        public const char UnderInvestigation = '1';

        /// <summary>
        ///  Investigation Completed
        /// </summary>
        public const char InvestigationCompleted = '2';

        /// <summary>
        ///  Length of Investigation Status in bytes
        /// </summary>
        public const int Length = 1;
    }
}