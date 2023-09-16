namespace Cme.Mdp3
{
    /// <summary>
    ///  Md Security Trading Status: Identifies the current trading state of the instrument
    /// </summary>
    public enum MdSecurityTradingStatus : byte
    {
        /// <summary>
        ///  Identifies the current trading state of the instrument
        /// </summary>
        NoValue = 255;

        /// <summary>
        ///  Trading Halt
        /// </summary>
        TradingHalt = 2;

        /// <summary>
        ///  Close
        /// </summary>
        Close = 4;

        /// <summary>
        ///  New Price Indication
        /// </summary>
        NewPriceIndication = 15;

        /// <summary>
        ///  Ready To Trade
        /// </summary>
        ReadyToTrade = 17;

        /// <summary>
        ///  Not Available For Trading
        /// </summary>
        NotAvailableForTrading = 18;

        /// <summary>
        ///  Unknown or Invalid
        /// </summary>
        UnknownorInvalid = 20;

        /// <summary>
        ///  Pre Open
        /// </summary>
        PreOpen = 21;

        /// <summary>
        ///  Pre Cross
        /// </summary>
        PreCross = 24;

        /// <summary>
        ///  Cross
        /// </summary>
        Cross = 25;

        /// <summary>
        ///  Post Close
        /// </summary>
        PostClose = 26;

        /// <summary>
        ///  No Change
        /// </summary>
        NoChange = 103;

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