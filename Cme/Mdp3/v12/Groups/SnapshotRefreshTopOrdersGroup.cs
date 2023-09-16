using System.Runtime.InteropServices;

namespace Cme.Mdp3
{
    /// <summary>
    ///  Snapshot Refresh Top Orders Group: Number of data blocks following
    /// </summary>

    public partial class SnapshotRefreshTopOrdersGroup
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            OrderId OrderId;
            MdOrderPriority MdOrderPriority;
            MdEntryPx MdEntryPx;
            MdDisplayQty MdDisplayQty;
            MdEntryTypeBook MdEntryTypeBook;
        };
    };
}