using System.Runtime.InteropServices;

namespace Ice.iMpact;

/// <summary>
///  Market Statistics Message: This is usually sent after a trade or cancelled trade message.
/// </summary>

public partial class MarketStatisticsMessage
{

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Layout
    {
        public MarketId MarketId;
        public Volume Volume;
        public BlockVolume BlockVolume;
        public EfsVolume EfsVolume;
        public EfpVolume EfpVolume;
        public High High;
        public Low Low;
        public Vwap Vwap;
        public MessageDateTime MessageDateTime;
    };
};
