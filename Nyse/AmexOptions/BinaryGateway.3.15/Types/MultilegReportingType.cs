namespace Nyse.AmexOptions.BinaryGateway
{
    /// <summary>
    ///  Multileg Reporting Type: Indicates the type of Execution Report. (e.g.: used with multi-leg securities, such as option strategies, spreads, etc.).
    /// </summary>
    public enum MultilegReportingType : byte
    {
        /// <summary>
        ///  Not Applicable
        /// </summary>
        NotApplicable = 0,

        /// <summary>
        ///  Singleleg Security
        /// </summary>
        SinglelegSecurity = 1,

        /// <summary>
        ///  Individual Leg Of A Multileg Security
        /// </summary>
        IndividualLegOfAMultilegSecurity = 2,

        /// <summary>
        ///  Multileg Security
        /// </summary>
        MultilegSecurity = 3,

    }
}