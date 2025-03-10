using System.Runtime.InteropServices;

namespace Cme.Mdp3;

/// <summary>
///  M D Incremental Refresh Limits Banding Group: Number of entries in Market Data message
/// </summary>

public partial class MDIncrementalRefreshLimitsBandingGroup
{

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Layout
    {
        public HighLimitPrice HighLimitPrice;
        public LowLimitPrice LowLimitPrice;
        public MaxPriceVariation MaxPriceVariation;
        public SecurityId SecurityId;
        public RptSeq RptSeq;
    };
};
