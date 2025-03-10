using System.Runtime.InteropServices;

namespace Cme.Mdp3;

/// <summary>
///  M D Incremental Refresh Volume Long Qty Group: Number of entries in Market Data message
/// </summary>

public partial class MDIncrementalRefreshVolumeLongQtyGroup
{

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Layout
    {
        public MdEntrySizeUInt64 MdEntrySizeUInt64;
        public SecurityId SecurityId;
        public RptSeq RptSeq;
        public MdUpdateAction MdUpdateAction;
        public Padding7 Padding7;
    };
};
