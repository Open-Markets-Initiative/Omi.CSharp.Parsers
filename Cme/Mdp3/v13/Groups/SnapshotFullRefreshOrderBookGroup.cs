using System.Runtime.InteropServices;

namespace Cme.Mdp3
{
    /// <summary>
    ///  Snapshot Full Refresh Order Book Group: Number of entries in Market Data message
    /// </summary>

    public partial class SnapshotFullRefreshOrderBookGroup
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            OrderId OrderId;
            MdOrderPriorityOptional MdOrderPriorityOptional;
            MdEntryPx MdEntryPx;
            MdDisplayQty MdDisplayQty;
            MdEntryTypeBook MdEntryTypeBook;
        };
    };
}