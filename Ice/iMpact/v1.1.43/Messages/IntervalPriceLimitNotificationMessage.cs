using System.Runtime.InteropServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  Interval Price Limit Notification Message
    /// </summary>

    public partial class IntervalPriceLimitNotificationMessage
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            MarketId MarketId;
            IplHoldType IplHoldType;
            NotificationDateTime NotificationDateTime;
            IsUp IsUp;
            IplHoldDuration IplHoldDuration;
            IplUp IplUp;
            IplDown IplDown;
        };
    };
}