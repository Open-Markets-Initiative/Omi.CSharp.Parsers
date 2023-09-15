using System.Runtime.InteropServices;

namespace Cme.Sbe
{
    /// <summary>
    ///  M D Incremental Refresh Book Group: Number of entries in Market Data message
    /// </summary>

    public partial class MDIncrementalRefreshBookGroup
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            MdEntryPxOptional MdEntryPxOptional;
            MdEntrySizeOptional MdEntrySizeOptional;
            SecurityId SecurityId;
            RptSeq RptSeq;
            NumberOfOrdersOptional NumberOfOrdersOptional;
            MdPriceLevel MdPriceLevel;
            MdUpdateAction MdUpdateAction;
            MdEntryTypeBook MdEntryTypeBook;
            TradeableSize TradeableSize;
            Padding1 Padding1;
        };
    };
}