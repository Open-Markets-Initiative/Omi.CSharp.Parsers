using System.Runtime.InteropServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  Market Statistics Message: This is usually sent after a trade or cancelled trade message.
    /// </summary>

    public partial class MarketStatisticsMessage
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            MarketId MarketId;
            Volume Volume;
            BlockVolume BlockVolume;
            EfsVolume EfsVolume;
            EfpVolume EfpVolume;
            High High;
            Low Low;
            Vwap Vwap;
            MessageDateTime MessageDateTime;
        };
    };
}