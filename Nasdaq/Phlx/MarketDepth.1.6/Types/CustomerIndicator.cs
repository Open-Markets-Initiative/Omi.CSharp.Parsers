using System.Runtime.CompilerServices;

namespace Nasdaq.MarketDepth
{
    /// <summary>
    ///  Customer Indicator
    /// </summary>

    public struct CustomerIndicator
    {
        /// <summary>
        ///  Customer
        /// </summary>
        public const char Customer = 'C';

        /// <summary>
        ///  Firm
        /// </summary>
        public const char Firm = 'F';

        /// <summary>
        ///  Onfloor Market Maker
        /// </summary>
        public const char Onfloor = 'M';

        /// <summary>
        ///  Professional Customer
        /// </summary>
        public const char Professional = 'P';

        /// <summary>
        ///  Broker Dealer Non Phlx
        /// </summary>
        public const char NonPhlx = 'B';

        /// <summary>
        ///  Length of Customer Indicator in bytes
        /// </summary>
        public const int Length = 1;
    }
}