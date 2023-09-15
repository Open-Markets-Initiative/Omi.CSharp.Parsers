using System.Runtime.InteropServices;

namespace Eurex.T7
{
    /// <summary>
    ///  Md Trade Entry Grp Comp
    /// </summary>

    public partial class MdTradeEntryGrpComp
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            MdEntryPx MdEntryPx;
            MdEntrySize MdEntrySize;
            MdEntryType MdEntryType;
            Pad7 Pad7;
        };
    };
}