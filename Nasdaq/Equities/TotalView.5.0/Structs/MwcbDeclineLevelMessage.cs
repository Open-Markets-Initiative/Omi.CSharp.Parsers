using System.Runtime.InteropServices;

namespace Nasdaq.TotalView
{
    /// <summary>
    ///  Mwcb Decline Level Message: Informs data recipients what the daily MWCB breach points are set to for the current trading day.
    /// </summary>

    public partial class MwcbDeclineLevelMessage
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            StockLocate StockLocate;
            TrackingNumber TrackingNumber;
            Timestamp Timestamp;
            Level1 Level1;
            Level2 Level2;
            Level3 Level3;
        };
    };
}