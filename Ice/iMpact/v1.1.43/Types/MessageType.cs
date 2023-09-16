using System.Runtime.CompilerServices;;

namespace Ice.iMpact
{
    /// <summary>
    ///  Message Type
    /// </summary>

    public struct MessageType
    {
        /// <summary>
        ///  The market snapshot message is the same for full order depth and price level snapshot channel.
        /// </summary>
        public const char MarketSnapshotMessage = 'C';

        /// <summary>
        ///  A trade with IsSystemPricedLeg equal to ‘Y’ should not be used for the last price, High, Low and Open. Also please refer to Appendix B on how to handle market stats for given OffTradeMarketType. This message will not be sent for trades in Endex Spot markets.
        /// </summary>
        public const char TradeMessage = 'G';

        /// <summary>
        ///  This message will be sent only upon trade in spot markets and it will be rendered on spot market channels.
        /// </summary>
        public const char SpotMarketTradeMessage = 'Y';

        /// <summary>
        ///  This message is sent when a trade is put under investigation or the investigation is completed. Client can use the market ID and order ID to find and flag the original trade if needed.
        /// </summary>
        public const char InvestigatedTradeMessage = 'H';

        /// <summary>
        ///  This message is sent when a trade is cancelled.
        /// </summary>
        public const char CancelledTradeMessage = 'I';

        /// <summary>
        ///  This is usually sent after a trade or cancelled trade message.
        /// </summary>
        public const char MarketStatisticsMessage = 'J';

        /// <summary>
        ///  Market State Change Message
        /// </summary>
        public const char MarketStateChangeMessage = 'K';

        /// <summary>
        ///  System Text Message
        /// </summary>
        public const char SystemTextMessage = 'L';

        /// <summary>
        ///  Open Interest Message
        /// </summary>
        public const char OpenInterestMessage = 'M';

        /// <summary>
        ///  Open Price Message
        /// </summary>
        public const char OpenPriceMessage = 'N';

        /// <summary>
        ///  Close Price Message
        /// </summary>
        public const char ClosePriceMessage = 'c';

        /// <summary>
        ///  Settlement prices could be official or unofficial. For a given market, the exchange usually sends out unofficial price before the official one.
        /// </summary>
        public const char SettlementPriceMessage = 'O';

        /// <summary>
        ///  The exchange sends out Marker/Index Prices when there is an update.
        /// </summary>
        public const char IndexPricesMessage = 'z';

        /// <summary>
        ///  The message is streamed to client when market is closed and settlement price is available for the current trading day.
        /// </summary>
        public const char EndOfDayMarketSummaryMessage = 'u';

        /// <summary>
        ///  End of Day Market Summary Message
        /// </summary>
        public const char MarketEventMessage = 'f';

        /// <summary>
        ///  This message contains the estimate of what the opening price could be, based on the orders in the market or previous settlement price.
        /// </summary>
        public const char PreOpenPriceIndicatorMessage = 'g';

        /// <summary>
        ///  This message will be sent out if there is strip date change during the trading session. If client does not care about strip date changes, client should ignore these messages.
        /// </summary>
        public const char StripInfoMessage = 'i';

        /// <summary>
        ///  Interval Price Limit (IPL) might be enabled for certain markets. IPL check is to prevent sudden movements (in both directions) in the market during a short period of time.
        /// </summary>
        public const char IntervalPriceLimitNotificationMessage = 'V';

        /// <summary>
        ///  New Futures Strategy Definition messages will be sent out when new UDS markets for futures are created.
        /// </summary>
        public const char NewFuturesStrategyDefinitionMessage = '9';

        /// <summary>
        ///  New Expiry message will be sent out when a new equity market is created during the day.
        /// </summary>
        public const char NewExpiryMessage = 'R';

        /// <summary>
        ///  The Special Field Message is used to send extra information on existing messages.
        /// </summary>
        public const char SpecialFieldMessage = 'b';

        /// <summary>
        ///  When multicast messages become too large to fit within a single packet, their serialized content will be split into byte fragments and sent within this Fragment Wrapper Message
        /// </summary>
        public const char FragmentWrapperMessage = 'Z';

        /// <summary>
        ///  This message is for orders in snapshot only. It is different from the order message for incremental updates.
        /// </summary>
        public const char MarketSnapshotOrderMessage = 'D';

        /// <summary>
        ///  Client should add the order to book if it is not there already. Otherwise, just overwrite the existing order.
        /// </summary>
        public const char AddOrModifyOrderMessage = 'E';

        /// <summary>
        ///  Upon receipt of this message, client should remove the order from its local book.
        /// </summary>
        public const char DeleteOrderMessage = 'F';

        /// <summary>
        ///  This message indicates where a bundle of messages starts or ends.
        /// </summary>
        public const char MessageBundleMarker = 'T';

        /// <summary>
        ///  This message supports ICE Benchmark Administration’s (IBA) electronic Gold Auction and it is disseminated when there is a transition of the fixing market.
        /// </summary>
        public const char FixingTransitionMessage = '3';

        /// <summary>
        ///  This message supports ICE Benchmark Administration’s (IBA) electronic Gold Auction and it is disseminated when there is a transition of the fixing market.
        /// </summary>
        public const char FixingLockdownMessage = '4';

        /// <summary>
        ///  This message supports ICE Benchmark Administration’s (IBA) electronic Gold and Silver Auction and is disseminated at the end of the final auction when the final price is published
        /// </summary>
        public const char FixingIndicativePriceMessage = '0';

        /// <summary>
        ///  This message is for price level in snapshot only.
        /// </summary>
        public const char MarketSnapshotPriceLevelMessage = 'm';

        /// <summary>
        ///  Upon receipt of this message, client should add/insert a price level at the specified position in the book for the given market, and push down the price levels that were previously at or below that position.
        /// </summary>
        public const char AddPriceLevelMessage = 't';

        /// <summary>
        ///  Upon receipt of this message, client should update the price level at the specified position in its book for the given market.
        /// </summary>
        public const char ChangePriceLevelMessage = 's';

        /// <summary>
        ///  Upon receipt of this message, client should remove the price level at the specified position in its book for the given market.
        /// </summary>
        public const char DeletePriceLevelMessage = 'r';

        /// <summary>
        ///  New Options Strategy Definition messages will be sent out when new UDS markets for options are created.
        /// </summary>
        public const char NewOptionsStrategyDefinitionMessage = 'U';

        /// <summary>
        ///  New Options Market Definition messages will be sent out when new options markets are created.
        /// </summary>
        public const char NewOptionsMarketDefinitionMessage = 'l';

        /// <summary>
        ///  Request for Quote Message.
        /// </summary>
        public const char RfqMessage = 'k';

        /// <summary>
        ///  Option Open Interest Message
        /// </summary>
        public const char OptionOpenInterestMessage = 'v';

        /// <summary>
        ///  Option settlement prices could be official or unofficial. For a given market, the exchange usually sends out unofficial price before the official one.
        /// </summary>
        public const char OptionSettlementPriceMessage = 'w';

        /// <summary>
        ///  Option settlement prices could be official or unofficial. For a given market, the exchange usually sends out unofficial price before the official one.
        /// </summary>
        public const char OldStyleOptionsTradeAndMarketStatsMessage = 'W';

        /// <summary>
        ///  Length of Message Type in bytes
        /// </summary>
        public const int Length = 1;
    }
}