namespace Cme.Sbe
{
    /// <summary>
    ///  Workup Trading Status: Identifies the trading status applicable to the instrument
    /// </summary>
    public enum WorkupTradingStatus : byte
    {
        /// <summary>
        ///  Ready To Trade
        /// </summary>
        ReadyToTrade = 17;

        /// <summary>
        ///  Not Available For Trading
        /// </summary>
        NotAvailableForTrading = 18;

        /// <summary>
        ///  Private Workup
        /// </summary>
        PrivateWorkup = 201;

        /// <summary>
        ///  Public Workup
        /// </summary>
        PublicWorkup = 202;

    }
}