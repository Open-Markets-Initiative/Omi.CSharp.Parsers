using System.Runtime.InteropServices;

namespace Cme.Mdp3
{
    /// <summary>
    ///  Md Incremental Refresh Book: MDIncrementalRefreshBook
    /// </summary>

    public partial class MdIncrementalRefreshBook
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            TransactTime TransactTime;
            MatchEventIndicator MatchEventIndicator;
            Padding2 Padding2;
        };
    };
}