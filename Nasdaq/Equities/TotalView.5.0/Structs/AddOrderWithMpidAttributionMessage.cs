using System.Runtime.InteropServices;

namespace Nasdaq.TotalView
{
    /// <summary>
    ///  Add Order With Mpid Attribution Message: This message will be generated for attributed orders and quotations accepted by the NASDAQ system.
    /// </summary>

    public partial class AddOrderWithMpidAttributionMessage
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            StockLocate StockLocate;
            TrackingNumber TrackingNumber;
            Timestamp Timestamp;
            OrderReferenceNumber OrderReferenceNumber;
            BuySellIndicator BuySellIndicator;
            Shares Shares;
            Stock Stock;
            Price Price;
            Attribution Attribution;
        };
    };
}