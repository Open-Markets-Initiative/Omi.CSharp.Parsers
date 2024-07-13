using System.Runtime.InteropServices;

namespace Nasdaq.TotalView
{
    /// <summary>
    ///  Mwcb Status Level Message: Informs data recipients when a MWCB has breached one of the established levels
    /// </summary>

    public partial class MwcbStatusLevelMessage
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            StockLocate StockLocate;
            TrackingNumber TrackingNumber;
            Timestamp Timestamp;
            BreachedLevel BreachedLevel;
        };
    };
}