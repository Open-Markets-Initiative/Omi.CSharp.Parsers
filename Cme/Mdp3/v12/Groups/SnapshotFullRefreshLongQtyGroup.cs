using System.Runtime.InteropServices;

namespace Cme.Mdp3
{
    /// <summary>
    ///  Snapshot Full Refresh Long Qty Group: Number of entries in Market Data message
    /// </summary>

    public partial class SnapshotFullRefreshLongQtyGroup
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            public MdEntryPxOptional MdEntryPxOptional;
            public MdEntrySizeUInt64Null MdEntrySizeUInt64Null;
            public NumberOfOrdersOptional NumberOfOrdersOptional;
            public MdPriceLevelUInt8Null MdPriceLevelUInt8Null;
            public OpenCloseSettlFlag OpenCloseSettlFlag;
            public MdEntryType MdEntryType;
        };
    };
}