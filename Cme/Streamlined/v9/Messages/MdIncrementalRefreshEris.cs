using System.Runtime.InteropServices;

namespace Cme.Streamlined
{
    /// <summary>
    ///  Md Incremental Refresh Eris: MDIncrementalRefreshEris
    /// </summary>

    public partial class MdIncrementalRefreshEris
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            TransactTime TransactTime;
            MatchEventIndicator MatchEventIndicator;
            BatchTotalMessagesOptional BatchTotalMessagesOptional;
        };
    };
}