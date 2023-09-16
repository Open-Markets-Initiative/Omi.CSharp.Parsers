using System.Runtime.CompilerServices;;

namespace Nasdaq.MarketDepth
{
    /// <summary>
    ///  Message Type
    /// </summary>

    public struct MessageType
    {
        /// <summary>
        ///  This message is sent every second for which at least one PHLX Depth message is being generated.
        /// </summary>
        public const char SecondsMessage = 'T';

        /// <summary>
        ///  The system event message type is used to signal a market or data feed handler event.
        /// </summary>
        public const char SystemEventMessage = 'S';

        /// <summary>
        ///  This message indicates the base reference number to which all the order/quote/trade reference number deltas must be added to obtain the absolute order/quote PHLX reference number.
        /// </summary>
        public const char BaseReferenceMessage = 'L';

        /// <summary>
        ///  At the start of each trading day, the options system disseminates option symbol directory messages for all active option symbols in the PHLX ® options system.
        /// </summary>
        public const char OptionDirectoryMessage = 'R';

        /// <summary>
        ///  The options system uses this administrative message to indicate the current trading status of an index or equity option within the PHLX Options Market.
        /// </summary>
        public const char TradingActionMessage = 'H';

        /// <summary>
        ///  The options system plans to disseminate the Option Open Message for each option as soon as the opening is completed.  Upon receipt of the open state message, firms should be advised that the option denoted in the message is now available for auto execution within the PHLX ® Options Market System.  Upon receipt of the closed state message, firms should be advised that the option is no longer eligible for auto-execution within the Options Market System.
        /// </summary>
        public const char SecurityOpenMessage = 'O';

        /// <summary>
        ///  An Add Order Message indicates that a new order has been accepted by the options system and was added to the displayable book. The message includes a day-unique Order Reference Number used by options system to track the order.
        /// </summary>
        public const char AddOrderShortMessage = 'a';

        /// <summary>
        ///  An Add Order Message indicates that a new order has been accepted by the options system and was added to the displayable book. The message includes a day-unique Order Reference Number used by options system to track the order.
        /// </summary>
        public const char AddOrderLongMessage = 'A';

        /// <summary>
        ///  An Add Quote Message indicates that a new quote has been accepted by the PHLX ® options system and was added to the displayable book. The message includes a unique Bid/Ask Reference Numbers used by the options system to track the quote.
        /// </summary>
        public const char AddQuoteShortMessage = 'j';

        /// <summary>
        ///  An Add Quote Message indicates that a new quote has been accepted by the PHLX ® options system and was added to the displayable book. The message includes a unique Bid/Ask Reference Numbers used by the options system to track the quote.
        /// </summary>
        public const char AddQuoteLongMessage = 'J';

        /// <summary>
        ///  This message is sent whenever a Side order is executed in whole or in part. It is possible to receive several Single Side Executed Messages for the same Side order if that Side order is executed in several parts. The multiple Single Side Executed Messages on the same order are cumulative. By combining the executions received separately via two types of Single Side Executed Messages and Trade Messages, it is possible to build a complete view of all non-auction executions that happen on PHLX ®. Auction execution information is available in one bulk print via the Auction Trade Message.
        /// </summary>
        public const char SingleSideExecutedMessage = 'E';

        /// <summary>
        ///  This message is sent whenever an incoming Side order is executed against the book in whole or in part at a price different from the initial display price. Since the execution price is different than the display price of the original Add/Replace, the options system includes a price field within this execution message. It is possible to receive multiple Single Side Executed and Single Side Executed with Price messages for the same Side order if that Side order is executed in several parts. The multiple Single Side Executed messages on the same Side order are cumulative.
        /// </summary>
        public const char SingleSideExecutedWithPriceMessage = 'C';

        /// <summary>
        ///  This message is sent whenever an order or a side of a quote on the book is modified as a result of a partial cancellation.
        /// </summary>
        public const char SingleSideCancelMessage = 'X';

        /// <summary>
        ///  This message is sent whenever one side of a quote on the book is replaced. The replacement has a new reference number and replaces the prior reference number.
        /// </summary>
        public const char SingleSideReplaceShortMessage = 'u';

        /// <summary>
        ///  This message is sent whenever one side of a quote on the book is replaced. The replacement has a new reference number and replaces the prior reference number.
        /// </summary>
        public const char SingleSideReplaceLongMessage = 'U';

        /// <summary>
        ///  This message is sent whenever an order on the book is replaced. The replacement has a new reference number and replaces the prior reference number.
        /// </summary>
        public const char OrderReplaceShortMessage = 'v';

        /// <summary>
        ///  This message is sent whenever an order on the book is replaced. The replacement has a new reference number and replaces the prior reference number.
        /// </summary>
        public const char OrderReplaceLongMessage = 'V';

        /// <summary>
        ///  The message is sent when an order or a side of a quote is being cancelled. All remaining contracts are no longer accessible so the side should be removed from the book.
        /// </summary>
        public const char SingleSideDeleteMessage = 'D';

        /// <summary>
        ///  This message is sent whenever an order or a side of a quote is being updated for price and (or) contracts. The reference number associated with the order quote is unchanged.
        /// </summary>
        public const char SingleSideUpdateMessage = 'G';

        /// <summary>
        ///  This message is sent whenever a quote on the book is replaced. The replaced quote has new reference numbers on both sides.
        /// </summary>
        public const char QuoteReplaceShortMessage = 'k';

        /// <summary>
        ///  This message is sent whenever a quote on the book is replaced. The replaced quote has new reference numbers on both sides.
        /// </summary>
        public const char QuoteReplaceLongMessage = 'K';

        /// <summary>
        ///  The message is sent when a single quote is being cancelled. All remaining contracts are no longer accessible so the quote should be removed from the book.
        /// </summary>
        public const char QuoteDeleteMessage = 'Y';

        /// <summary>
        ///  This message contains a block of Single Side Deletes. Each reference number inside the block represents an order or a side of a quote that is being cancelled. All remaining contracts are no longer accessible so the side should be removed from the book.
        /// </summary>
        public const char BlockDeleteMessage = 'Z';

        /// <summary>
        ///  This Options Trade Message is designed to provide execution details for match events involving non-displayable order types and Complex orders. (Note: There is a separate message for Option auction events.)
        /// </summary>
        public const char NonAuctionOptionsTradeMessage = 'P';

        /// <summary>
        ///  Options Auction Trade message is sent for every option when an auction in that option is completed. The message indicates the bulk volume associated with the auction event.
        /// </summary>
        public const char OptionsCrossTradeMessage = 'Q';

        /// <summary>
        ///  The Broken Trade Message is sent whenever an execution on PHLX ® is broken. An execution may be broken if it is found to be “clearly erroneous” pursuant to PHLX ® Clearly Erroneous Policy. A trade break is final; once a trade is broken, it cannot be reinstated.
        /// </summary>
        public const char BrokenTradeOrderExecutedMessage = 'B';

        /// <summary>
        ///  This message is also sent as notification that there is an exposed buy (sell) order available for execution at the National Best Offer (Bid).
        /// </summary>
        public const char AuctionNotificationMessage = 'I';

        /// <summary>
        ///  Length of Message Type in bytes
        /// </summary>
        public const int Length = 1;
    }
}