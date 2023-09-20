namespace Nyse.AmexOptions.BinaryGateway
{
    /// <summary>
    ///  Threshold Breach Level: ThresholdBreachLevel
    /// </summary>
    public enum ThresholdBreachLevel : byte
    {
        /// <summary>
        ///  Not Applicable
        /// </summary>
        NotApplicable = 0,

        /// <summary>
        ///  Greater Than 50 Percent
        /// </summary>
        GreaterThan50Percent = 1,

        /// <summary>
        ///  Greater Than 75 Percent
        /// </summary>
        GreaterThan75Percent = 2,

        /// <summary>
        ///  Greater Than 90 Percent
        /// </summary>
        GreaterThan90Percent = 3,

        /// <summary>
        ///  Greater Than 100 Percent
        /// </summary>
        GreaterThan100Percent = 4,

    }
}