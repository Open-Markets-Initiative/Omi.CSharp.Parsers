using System.Runtime.InteropServices;

namespace Cme.Mdp3;

/// <summary>
///  M D Incremental Refresh Book Long Qty Group: Number of entries in Market Data message.
/// </summary>

public partial class MDIncrementalRefreshBookLongQtyGroup
{

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Layout
    {
        public MdEntryPxOptional MdEntryPxOptional;
        public MdEntrySizeUInt64Null MdEntrySizeUInt64Null;
        public SecurityId SecurityId;
        public RptSeq RptSeq;
        public NumberOfOrdersOptional NumberOfOrdersOptional;
        public MdPriceLevel MdPriceLevel;
        public MdUpdateAction MdUpdateAction;
        public MdEntryTypeBook MdEntryTypeBook;
        public Padding1 Padding1;
    };
};
