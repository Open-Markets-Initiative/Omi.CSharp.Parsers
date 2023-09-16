using System.Runtime.InteropServices;

namespace Cme.Streamlined
{
    /// <summary>
    ///  M D Incremental Refresh Indices Group: Number of entries in Market Data message
    /// </summary>

    public partial class MDIncrementalRefreshIndicesGroup
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            MdEntryTypeIndices MdEntryTypeIndices;
            RptSeq RptSeq;
            MdEntryPxDecimal MdEntryPxDecimal;
            MdEntrySizeOptional MdEntrySizeOptional;
            Symbol Symbol;
            OpenCloseSettlFlag OpenCloseSettlFlag;
            YieldType YieldType;
            Yield Yield;
            NetChgPrevDay NetChgPrevDay;
            NetPctChg NetPctChg;
            PercentTrading PercentTrading;
            MdEntryCode MdEntryCode;
            MdEntryDate MdEntryDate;
            MdEntryTime MdEntryTime;
            ReferenceId50 ReferenceId50;
        };
    };
}