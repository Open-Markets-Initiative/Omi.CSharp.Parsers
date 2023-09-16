namespace Nyse.AmexOptions.BinaryGateway
{
    /// <summary>
    ///  Cancel Scope: Orders only
    /// </summary>
    public enum CancelScope : byte
    {
        /// <summary>
        ///  Orders Only
        /// </summary>
        OrdersOnly = 0;

        /// <summary>
        ///  Options Mm Quotes Only
        /// </summary>
        OptionsMmQuotesOnly = 1;

        /// <summary>
        ///  Both Orders And Options Mm Quotes
        /// </summary>
        BothOrdersAndOptionsMmQuotes = 2;

    }
}