namespace Eurex.Eobi
{
    /// <summary>
    ///  Multi Leg Reporting Type
    /// </summary>
    public enum MultiLegReportingType : byte
    {
        /// <summary>
        ///  
        /// </summary>
        SingleSecurity = 1;

        /// <summary>
        ///  
        /// </summary>
        IndividualLegOfAMultiLegSecurity = 2;

        /// <summary>
        ///  
        /// </summary>
        MultiLegSecurity = 3;

        /// <summary>
        ///  
        /// </summary>
        MultiLegReportingTypeMaximumValue = 3;

        /// <summary>
        ///  
        /// </summary>
        MultiLegReportingTypeMinimumValue = 1;

    }
}