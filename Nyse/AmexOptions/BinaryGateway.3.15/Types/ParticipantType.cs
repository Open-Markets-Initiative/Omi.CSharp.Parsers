namespace Nyse.AmexOptions.BinaryGateway
{
    /// <summary>
    ///  Participant Type: ParticipantType
    /// </summary>
    public enum ParticipantType : byte
    {
        /// <summary>
        ///  Not Applicable
        /// </summary>
        NotApplicable = 0,

        /// <summary>
        ///  Customer
        /// </summary>
        Customer = 1,

        /// <summary>
        ///  Market Maker Lmm
        /// </summary>
        MarketMakerLmm = 2,

        /// <summary>
        ///  Dmm
        /// </summary>
        Dmm = 3,

        /// <summary>
        ///  Slp
        /// </summary>
        Slp = 4,

        /// <summary>
        ///  Nyse Floor Broker Nyse Chicago Ib
        /// </summary>
        NyseFloorBrokerNyseChicagoIb = 5,

    }
}