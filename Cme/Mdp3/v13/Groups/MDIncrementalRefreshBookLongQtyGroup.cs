using System.Runtime.InteropServices;

namespace Cme.Mdp3
{
    /// <summary>
    ///  M D Incremental Refresh Book Long Qty Group: Number of entries in Market Data message.
    /// </summary>

    public partial class MDIncrementalRefreshBookLongQtyGroup
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            MdEntryPxOptional MdEntryPxOptional;
            MdEntrySizeUInt64Null MdEntrySizeUInt64Null;
            SecurityId SecurityId;
            RptSeq RptSeq;
            NumberOfOrdersOptional NumberOfOrdersOptional;
            MdPriceLevel MdPriceLevel;
            MdUpdateAction MdUpdateAction;
            MdEntryTypeBook MdEntryTypeBook;
            Padding1 Padding1;
        };
    };
}