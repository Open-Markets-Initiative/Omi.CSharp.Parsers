using System.Runtime.InteropServices;

namespace Cme.Streamlined;

/// <summary>
///  M D Incremental Refresh Indices Group: Number of entries in Market Data message
/// </summary>

public partial class MDIncrementalRefreshIndicesGroup
{

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Layout
    {
        public MdEntryTypeIndices MdEntryTypeIndices;
        public RptSeq RptSeq;
        public MdEntryPxDecimal MdEntryPxDecimal;
        public MdEntrySizeOptional MdEntrySizeOptional;
        public Symbol Symbol;
        public OpenCloseSettlFlag OpenCloseSettlFlag;
        public YieldType YieldType;
        public Yield Yield;
        public NetChgPrevDay NetChgPrevDay;
        public NetPctChg NetPctChg;
        public PercentTrading PercentTrading;
        public MdEntryCode MdEntryCode;
        public MdEntryDate MdEntryDate;
        public MdEntryTime MdEntryTime;
        public ReferenceId50 ReferenceId50;
    };
};
