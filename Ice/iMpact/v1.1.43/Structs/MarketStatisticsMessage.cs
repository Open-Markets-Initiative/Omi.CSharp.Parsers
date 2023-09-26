using System.Runtime.InteropServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  Market Statistics Message
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