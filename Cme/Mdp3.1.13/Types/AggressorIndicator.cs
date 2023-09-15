namespace Cme.Sbe
{
    /// <summary>
    ///  Aggressor Indicator: Aggressor Indicator 1=Aggressor Order 0=Passive Order
    /// </summary>
    public enum AggressorIndicator : byte
    {
        /// <summary>
        ///  Aggressor Indicator 1=Aggressor Order 0=Passive Order
        /// </summary>
        NoValue = 255;

        /// <summary>
        ///  Not Aggressor
        /// </summary>
        NotAggressor = 0;

        /// <summary>
        ///  Aggressor
        /// </summary>
        Aggressor = 1;

    }
}