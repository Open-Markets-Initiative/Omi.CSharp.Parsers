using System.Runtime.InteropServices;

namespace Cme.Mdp3
{
    /// <summary>
    ///  Snapshot Full Refresh Group: Number of entries in Market Data message
    /// </summary>

    public partial class SnapshotFullRefreshGroup
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            MdEntryPxOptional MdEntryPxOptional;
            MdEntrySizeOptional MdEntrySizeOptional;
            NumberOfOrdersOptional NumberOfOrdersOptional;
            MdPriceLevelOptional MdPriceLevelOptional;
            TradingReferenceDate TradingReferenceDate;
            OpenCloseSettlFlag OpenCloseSettlFlag;
            SettlPriceType SettlPriceType;
            MdEntryType MdEntryType;
        };
    };
}