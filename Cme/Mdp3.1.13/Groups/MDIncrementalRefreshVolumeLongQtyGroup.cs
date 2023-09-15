using System.Runtime.InteropServices;

namespace Cme.Sbe
{
    /// <summary>
    ///  M D Incremental Refresh Volume Long Qty Group: Number of entries in Market Data message
    /// </summary>

    public partial class MDIncrementalRefreshVolumeLongQtyGroup
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            MdEntrySizeUInt64 MdEntrySizeUInt64;
            SecurityId SecurityId;
            RptSeq RptSeq;
            MdUpdateAction MdUpdateAction;
            Padding7 Padding7;
        };
    };
}