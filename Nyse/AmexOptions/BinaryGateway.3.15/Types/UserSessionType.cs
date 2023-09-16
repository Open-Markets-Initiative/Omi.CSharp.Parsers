namespace Nyse.AmexOptions.BinaryGateway
{
    /// <summary>
    ///  User Session Type: Defines the permission type assigned to the gateway session. UserSessionType controls the message types and values available to the session.
    /// </summary>
    public enum UserSessionType : byte
    {
        /// <summary>
        ///  All Asset Clases Andor Equities Market Maker
        /// </summary>
        AllAssetClasesAndorEquitiesMarketMaker = 1;

        /// <summary>
        ///  Service Bureau
        /// </summary>
        ServiceBureau = 2;

        /// <summary>
        ///  Designated Market Maker
        /// </summary>
        DesignatedMarketMaker = 3;

        /// <summary>
        ///  Options Market Maker
        /// </summary>
        OptionsMarketMaker = 4;

        /// <summary>
        ///  Third Party Algo Vendor
        /// </summary>
        ThirdPartyAlgoVendor = 5;

        /// <summary>
        ///  Nyse Floor Broker
        /// </summary>
        NyseFloorBroker = 6;

        /// <summary>
        ///  Direct To Nyse Floor Broker
        /// </summary>
        DirectToNyseFloorBroker = 7;

        /// <summary>
        ///  Risk Admin
        /// </summary>
        RiskAdmin = 12;

    }
}