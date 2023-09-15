namespace Cme.Sbe
{
    /// <summary>
    ///  Md Stream Id: Source of the Clean Price
    /// </summary>
    public enum MdStreamId : byte
    {
        /// <summary>
        ///  Source of the Clean Price
        /// </summary>
        NoValue = 255;

        /// <summary>
        ///  Globex Market Surveillance team
        /// </summary>
        MarketPlaceAssistant = 0;

        /// <summary>
        ///  Globex Trading Activity
        /// </summary>
        Globex = 1;

        /// <summary>
        ///  Refinitiv
        /// </summary>
        Refinitiv = 2;

        /// <summary>
        ///  Icap Market Data Feed
        /// </summary>
        Icap = 3;

    }
}