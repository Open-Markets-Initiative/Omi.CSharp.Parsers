namespace Cme.Sbe
{
    /// <summary>
    ///  Template Id:
    /// </summary>
    public enum TemplateId : ushort
    {
        /// <summary>
        ///  ChannelReset
        /// </summary>
        ChannelReset = 4;

        /// <summary>
        ///  AdminHeartbeat
        /// </summary>
        AdminHeartbeat = 12;

        /// <summary>
        ///  AdminLogin
        /// </summary>
        AdminLogin = 15;

        /// <summary>
        ///  AdminLogout
        /// </summary>
        AdminLogout = 16;

        /// <summary>
        ///  SecurityStatus
        /// </summary>
        SecurityStatus = 30;

        /// <summary>
        ///  MDIncrementalRefreshVolume
        /// </summary>
        MdIncrementalRefreshVolume = 37;

        /// <summary>
        ///  QuoteRequest
        /// </summary>
        QuoteRequest = 39;

        /// <summary>
        ///  MDIncrementalRefreshBook
        /// </summary>
        MdIncrementalRefreshBook = 46;

        /// <summary>
        ///  MDIncrementalRefreshOrderBook
        /// </summary>
        MdIncrementalRefreshOrderBook = 47;

        /// <summary>
        ///  MDIncrementalRefreshTradeSummary
        /// </summary>
        MdIncrementalRefreshTradeSummary = 48;

        /// <summary>
        ///  MDIncrementalRefreshDailyStatistics
        /// </summary>
        MdIncrementalRefreshDailyStatistics = 49;

        /// <summary>
        ///  MDIncrementalRefreshLimitsBanding
        /// </summary>
        MdIncrementalRefreshLimitsBanding = 50;

        /// <summary>
        ///  MDIncrementalRefreshSessionStatistics
        /// </summary>
        MdIncrementalRefreshSessionStatistics = 51;

        /// <summary>
        ///  SnapshotFullRefresh
        /// </summary>
        SnapshotFullRefresh = 52;

        /// <summary>
        ///  SnapshotFullRefreshOrderBook
        /// </summary>
        SnapshotFullRefreshOrderBook = 53;

        /// <summary>
        ///  MDInstrumentDefinitionFuture
        /// </summary>
        MdInstrumentDefinitionFuture = 54;

        /// <summary>
        ///  MDInstrumentDefinitionOption
        /// </summary>
        MdInstrumentDefinitionOption = 55;

        /// <summary>
        ///  MDInstrumentDefinitionSpread
        /// </summary>
        MdInstrumentDefinitionSpread = 56;

        /// <summary>
        ///  MDInstrumentDefinitionFixedIncome
        /// </summary>
        MdInstrumentDefinitionFixedIncome = 57;

        /// <summary>
        ///  MDInstrumentDefinitionRepo
        /// </summary>
        MdInstrumentDefinitionRepo = 58;

        /// <summary>
        ///  SnapshotRefreshTopOrders
        /// </summary>
        SnapshotRefreshTopOrders = 59;

        /// <summary>
        ///  SecurityStatusWorkup
        /// </summary>
        SecurityStatusWorkup = 60;

        /// <summary>
        ///  SnapshotFullRefreshTCP
        /// </summary>
        SnapshotFullRefreshTcp = 61;

        /// <summary>
        ///  CollateralMarketValue
        /// </summary>
        CollateralMarketValue = 62;

        /// <summary>
        ///  MDInstrumentDefinitionFX
        /// </summary>
        MdInstrumentDefinitionFx = 63;

        /// <summary>
        ///  MDIncrementalRefreshBookLongQty
        /// </summary>
        MdIncrementalRefreshBookLongQty = 64;

        /// <summary>
        ///  MDIncrementalRefreshTradeSummaryLongQty
        /// </summary>
        MdIncrementalRefreshTradeSummaryLongQty = 65;

        /// <summary>
        ///  MDIncrementalRefreshVolumeLongQty
        /// </summary>
        MdIncrementalRefreshVolumeLongQty = 66;

        /// <summary>
        ///  MDIncrementalRefreshSessionStatisticsLongQty
        /// </summary>
        MdIncrementalRefreshSessionStatisticsLongQty = 67;

        /// <summary>
        ///  SnapshotFullRefreshTCPLongQty
        /// </summary>
        SnapshotFullRefreshTcpLongQty = 68;

        /// <summary>
        ///  SnapshotFullRefreshLongQty
        /// </summary>
        SnapshotFullRefreshLongQty = 69;

    }
}