namespace Nyse.AmexOptions.Pillar
{
    /// <summary>
    ///  Ioc Attribution: IOCAttribution
    /// </summary>
    public enum IocAttribution : byte
    {
        /// <summary>
        ///  Not Applicable
        /// </summary>
        NotApplicable = 0;

        /// <summary>
        ///  Include Ioc And Gtx Orders In Activitybased Calculations And Cancellations
        /// </summary>
        IncludeIocAndGtxOrdersInActivitybasedCalculationsAndCancellations = 1;

        /// <summary>
        ///  Exclude Ioc And Gtx Orders From Activitybased Calculations And Cancellations
        /// </summary>
        ExcludeIocAndGtxOrdersFromActivitybasedCalculationsAndCancellations = 2;

    }
}