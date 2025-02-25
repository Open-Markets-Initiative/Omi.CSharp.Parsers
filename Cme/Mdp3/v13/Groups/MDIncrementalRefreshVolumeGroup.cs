using System.Runtime.InteropServices;

namespace Cme.Mdp3
{
    /// <summary>
    ///  M D Incremental Refresh Volume Group: Number of entries in Market Data message
    /// </summary>

    public partial class MDIncrementalRefreshVolumeGroup
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            public MdEntrySize MdEntrySize;
            public SecurityId SecurityId;
            public RptSeq RptSeq;
            public MdUpdateAction MdUpdateAction;
            public Padding3 Padding3;
        };
    };
}