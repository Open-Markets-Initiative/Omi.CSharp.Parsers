using System.Runtime.InteropServices;

namespace Nasdaq.TotalView
{
    /// <summary>
    ///  System Event Message: Reflects the number of seconds past midnight that the Timestamp message was generated.
    /// </summary>

    public partial class SystemEventMessage
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            StockLocate StockLocate;
            TrackingNumber TrackingNumber;
            Timestamp Timestamp;
            EventCode EventCode;
        };
    };
}