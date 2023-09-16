using System.Runtime.CompilerServices;;

namespace Nasdaq.MarketDepth
{
    /// <summary>
    ///  Event Code
    /// </summary>

    public struct EventCode
    {
        /// <summary>
        ///  After 400 Am
        /// </summary>
        public const char StartOfMessagesThisIsAlwaysTheFirstMessageSentInAnyTradingDay = 'O';

        /// <summary>
        ///  700 Am
        /// </summary>
        public const char StartOfSystemHoursThisMessageIndicatesThatPhlx®IsOpenAndReadyToStartAcceptingOrders = 'S';

        /// <summary>
        ///  93000 Am
        /// </summary>
        public const char StartOfOpeningProcessThisMessageIsIntendedToIndicateThatPhlx®HasStartedItsOpeningAuctionProcess = 'Q';

        /// <summary>
        ///  40000 Pm
        /// </summary>
        public const char EndOfNormalHoursProcessingThisMessageIsIntendedToIndicateThatPhlx®WillNoLongerAcceptAnyNewOrdersOrChangesToExistingOrdersForOptionsThatTradeDuringNormalTradingHours = 'N';

        /// <summary>
        ///  41500 Pm
        /// </summary>
        public const char EndOfLateHoursProcessingThisMessageIsIntendedToIndicateThatPhlx®WillNoLongerAcceptAnyNewOrdersOrChangesToExistingOrdersForOptionsThatTradeDuringExtendedHours = 'L';

        /// <summary>
        ///  515 Pm
        /// </summary>
        public const char EndOfSystemHoursThisMessageIndicatesThatPhlx®OptionsSystemIsNowClosed = 'E';

        /// <summary>
        ///  520 Pm
        /// </summary>
        public const char EndOfMessagesThisIsAlwaysTheLastMessageSentInAnyTradingDay = 'C';

        /// <summary>
        ///  1200 Noon
        /// </summary>
        public const char EndOfWcoEarlyClosingThisMessageIsIntendedToIndicateThatTheExchangeWillNoLongerAcceptAnyNewOrdersOrChangesToExistingOrdersOnLastTradingDateOfWcoOptions = 'W';

        /// <summary>
        ///  Length of Event Code in bytes
        /// </summary>
        public const int Length = 1;
    }
}