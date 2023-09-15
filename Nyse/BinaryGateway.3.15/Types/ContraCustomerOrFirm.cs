namespace Nyse.AmexOptions.Pillar
{
    /// <summary>
    ///  Contra Customer Or Firm: Capacity of the order
    /// </summary>
    public enum ContraCustomerOrFirm : byte
    {
        /// <summary>
        ///  Not Applicable
        /// </summary>
        NotApplicable = 0;

        /// <summary>
        ///  Customer
        /// </summary>
        Customer = 1;

        /// <summary>
        ///  Firm
        /// </summary>
        Firm = 2;

        /// <summary>
        ///  Broker
        /// </summary>
        Broker = 3;

        /// <summary>
        ///  Market Maker
        /// </summary>
        MarketMaker = 4;

        /// <summary>
        ///  Away Market Maker
        /// </summary>
        AwayMarketMaker = 5;

        /// <summary>
        ///  Prof Customer
        /// </summary>
        ProfCustomer = 6;

    }
}