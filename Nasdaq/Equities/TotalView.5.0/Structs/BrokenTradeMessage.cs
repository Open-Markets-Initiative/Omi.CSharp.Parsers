using System.Runtime.InteropServices;

namespace Nasdaq.TotalView
{
    /// <summary>
    ///  Broken Trade Message: Firms that use the ITCH feed to create time-and-sales displays or calculate market statistics should be prepared to process the broken trade message.   If a firm is only using the ITCH feed to build a book, however, it may ignore these messages as they have no impact on the current book.
    /// </summary>

    public partial class BrokenTradeMessage
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            StockLocate StockLocate;
            TrackingNumber TrackingNumber;
            Timestamp Timestamp;
            MatchNumber MatchNumber;
        };
    };
}