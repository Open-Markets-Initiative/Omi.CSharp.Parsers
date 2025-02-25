using System.Runtime.InteropServices;

namespace Eurex.Eobi
{
    /// <summary>
    ///  Md Trade Entry Grp Comp
    /// </summary>

    public partial class MdTradeEntryGrpComp
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            public MdEntryPx MdEntryPx;
            public MdEntrySize MdEntrySize;
            public MdEntryType MdEntryType;
            public Pad7 Pad7;
        };
    };
}