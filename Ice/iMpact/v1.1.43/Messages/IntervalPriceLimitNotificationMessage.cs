using System.Runtime.InteropServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  Interval Price Limit Notification Message: Interval Price Limit (IPL) might be enabled for certain markets. IPL check is to prevent sudden movements (in both directions) in the market during a short period of time.
    /// </summary>

    public partial class IntervalPriceLimitNotificationMessage
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            public MarketId MarketId;
            public IplHoldType IplHoldType;
            public NotificationDateTime NotificationDateTime;
            public IsUp IsUp;
            public IplHoldDuration IplHoldDuration;
            public IplUp IplUp;
            public IplDown IplDown;
        };
    };
}