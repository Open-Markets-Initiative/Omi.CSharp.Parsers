namespace Eurex.Eobi
{
    /// <summary>
    ///  Trd Type
    /// </summary>
    public enum TrdType : ushort
    {
        /// <summary>
        ///  
        /// </summary>
        BlockTrade = 1,

        /// <summary>
        ///  Exchange For Physical
        /// </summary>
        Efp = 2,

        /// <summary>
        ///  Exchange For Swap
        /// </summary>
        Efs = 12,

        /// <summary>
        ///  Portfolio Compression Trade
        /// </summary>
        PortfolioCompressionTrade = 50,

        /// <summary>
        ///  
        /// </summary>
        Otc = 54,

        /// <summary>
        ///  ExchangeBasisFacility
        /// </summary>
        ExchangeBasisFacility = 55,

        /// <summary>
        ///  
        /// </summary>
        VolaTrade = 1000,

        /// <summary>
        ///  EFP-Fin Trade
        /// </summary>
        EfpFinTrade = 1001,

        /// <summary>
        ///  EFP-Index-Futures Trade
        /// </summary>
        EfpIndexFuturesTrade = 1002,

        /// <summary>
        ///  Block Trade At Market
        /// </summary>
        BlockTradeAtMarket = 1004,

        /// <summary>
        ///  Xetra / Eurex Enlight Triggered Trade
        /// </summary>
        XetraEurexEnlightTriggeredTrade = 1006,

        /// <summary>
        ///  Block QTPIP Trade
        /// </summary>
        BlockQtpipTrade = 1007,

        /// <summary>
        ///  Delta Trade At Market
        /// </summary>
        DeltaTradeAtMarket = 1017,

        /// <summary>
        ///  
        /// </summary>
        TrdTypeMaximumValue = 1017,

        /// <summary>
        ///  
        /// </summary>
        TrdTypeMinimumValue = 1,

    }
}