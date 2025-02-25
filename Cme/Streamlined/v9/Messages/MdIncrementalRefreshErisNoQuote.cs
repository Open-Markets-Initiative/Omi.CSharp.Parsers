using System.Runtime.InteropServices;

namespace Cme.Streamlined
{
    /// <summary>
    ///  Md Incremental Refresh Eris No Quote: MDIncrementalRefreshEris
    /// </summary>

    public partial class MdIncrementalRefreshErisNoQuote
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            public TransactTime TransactTime;
            public MatchEventIndicator MatchEventIndicator;
            public BatchTotalMessagesOptional BatchTotalMessagesOptional;
        };
    };
}