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
            MdEntryPxOptional MdEntryPxOptional;
            MdEntrySizeOptional MdEntrySizeOptional;
            SecurityId SecurityId;
            RptSeq RptSeq;
            TradingReferenceDate TradingReferenceDate;
            SettlPriceType SettlPriceType;
            MdUpdateAction MdUpdateAction;
            MdEntryTypeDailyStatistics MdEntryTypeDailyStatistics;
            Padding7 Padding7;
        };
    };
}