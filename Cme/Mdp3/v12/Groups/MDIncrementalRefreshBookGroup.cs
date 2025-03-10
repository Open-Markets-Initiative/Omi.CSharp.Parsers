using System.Runtime.InteropServices;

namespace Cme.Mdp3;

/// <summary>
///  M D Incremental Refresh Book Group: Number of entries in Market Data message
/// </summary>

public partial class MDIncrementalRefreshBookGroup
{

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Layout
    {
        public MdEntryPxOptional MdEntryPxOptional;
        public MdEntrySizeOptional MdEntrySizeOptional;
        public SecurityId SecurityId;
        public RptSeq RptSeq;
        public NumberOfOrdersOptional NumberOfOrdersOptional;
        public MdPriceLevel MdPriceLevel;
        public MdUpdateAction MdUpdateAction;
        public MdEntryTypeBook MdEntryTypeBook;
        public TradeableSize TradeableSize;
        public Padding1 Padding1;
    };
};
