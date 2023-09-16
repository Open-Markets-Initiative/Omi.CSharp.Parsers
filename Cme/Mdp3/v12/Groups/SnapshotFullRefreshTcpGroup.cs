using System.Runtime.InteropServices;

namespace Cme.Mdp3
{
    /// <summary>
    ///  Snapshot Full Refresh Tcp Group: Number of data blocks listed in the Incremental message
    /// </summary>

    public partial class SnapshotFullRefreshTcpGroup
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            MdEntryPxOptional MdEntryPxOptional;
            MdEntrySizeOptional MdEntrySizeOptional;
            TradeableSize TradeableSize;
            NumberOfOrdersOptional NumberOfOrdersOptional;
            MdPriceLevelOptional MdPriceLevelOptional;
            OpenCloseSettlFlag OpenCloseSettlFlag;
            MdEntryType MdEntryType;
            TradingReferenceDate TradingReferenceDate;
            SettlPriceType SettlPriceType;
        };
    };
}