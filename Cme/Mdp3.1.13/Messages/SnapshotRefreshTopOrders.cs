using System.Runtime.InteropServices;

namespace Cme.Sbe
{
    /// <summary>
    ///  Snapshot Refresh Top Orders: SnapshotRefreshTopOrders
    /// </summary>

    public partial class SnapshotRefreshTopOrders
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            TransactTime TransactTime;
            MatchEventIndicator MatchEventIndicator;
            SecurityId SecurityId;
        };
    };
}