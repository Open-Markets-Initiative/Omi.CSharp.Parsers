using System.Runtime.InteropServices;

namespace Cme.Mdp3
{
    /// <summary>
    ///  Snapshot Full Refresh Tc P Long Qty Group: Number of entries in Market Data message
    /// </summary>

    public partial class SnapshotFullRefreshTcPLongQtyGroup
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            MdEntryPxOptional MdEntryPxOptional;
            MdEntrySizeUInt64Null MdEntrySizeUInt64Null;
            NumberOfOrdersOptional NumberOfOrdersOptional;
            MdPriceLevelUInt8Null MdPriceLevelUInt8Null;
            OpenCloseSettlFlag OpenCloseSettlFlag;
            MdEntryType MdEntryType;
        };
    };
}