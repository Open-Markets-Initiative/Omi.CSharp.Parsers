using System.Runtime.InteropServices;

namespace Cme.Mdp3
{
    /// <summary>
    ///  M D Incremental Refresh Daily Statistics Group: Number of entries in Market Data message
    /// </summary>

    public partial class MDIncrementalRefreshDailyStatisticsGroup
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            public MdEntryPxOptional MdEntryPxOptional;
            public MdEntrySizeOptional MdEntrySizeOptional;
            public SecurityId SecurityId;
            public RptSeq RptSeq;
            public TradingReferenceDate TradingReferenceDate;
            public SettlPriceType SettlPriceType;
            public MdUpdateAction MdUpdateAction;
            public MdEntryTypeDailyStatistics MdEntryTypeDailyStatistics;
            public Padding7 Padding7;
        };
    };
}